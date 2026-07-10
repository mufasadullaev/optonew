using TashGresOpto.Core.Services;
using TashGresOpto.Core.Models;
using Microsoft.Extensions.DependencyInjection;

namespace TashGresOpto.UI.Forms;

public partial class O2GolMainControl : UserControl
{
    private readonly IServiceProvider _serviceProvider;
    private readonly O2GolService _service;
    private O2GolReport? _currentReport;

    public O2GolMainControl(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _service = serviceProvider.GetRequiredService<O2GolService>();
        
        InitializeComponent();
        InitializeUI();
        ShowDateInput();
    }

    private void InitializeUI()
    {
        lblTitle.Text = "СВОДНЫЙ РАСЧЕТ ПО ВАХТАМ";
        lblDateInputTitle.Text = "Дайте начальную и конечную дату расчета";
        lblStartDate.Text = "С:";
        lblEndDate.Text = "ПО:";
        btnGenerate.Text = "СФОРМИРОВАТЬ ОТЧЕТ";
        btnPrint.Text = "ПЕЧАТЬ";
        btnBack.Text = "НАЗАД В ГЛАВНОЕ МЕНЮ";
        btnBackFromReport.Text = "НАЗАД";
    }

    private void ShowDateInput()
    {
        panelDateInput.Visible = true;
        panelReport.Visible = false;
        panelDateInput.Dock = DockStyle.Fill;
        
        dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        dtpEndDate.Value = DateTime.Now;
    }

    private void ShowReport()
    {
        panelDateInput.Visible = false;
        panelReport.Visible = true;
        panelReport.Dock = DockStyle.Fill;
    }

    private async void btnGenerate_Click(object sender, EventArgs e)
    {
        try
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            // === ВАЛИДАЦИЯ ДИАПАЗОНА ДАТ ===
            var dateValidation = TashGresOpto.UI.Helpers.ValidationHelper.ValidateDateRange(startDate, endDate);
            
            if (!dateValidation.IsValid)
            {
                MessageBox.Show(
                    "Ошибки в выборе периода:\n\n" + dateValidation.GetErrorMessage(),
                    "Ошибка валидации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Показать сообщение о загрузке
            lblLoading.Visible = true;
            lblLoading.Text = "ЖДИТЕ! ИДЕТ ОБРАБОТКА ИНФОРМАЦИИ...";
            Application.DoEvents();

            // Генерация отчета
            _currentReport = await _service.GenerateReportAsync(startDate, endDate);

            lblLoading.Visible = false;

            // Проверка наличия данных
            bool hasData = false;
            for (int i = 0; i < 4; i++)
            {
                if (_currentReport.CountByShift[i] > 0)
                {
                    hasData = true;
                    break;
                }
            }

            if (!hasData)
            {
                MessageBox.Show(
                    $"Информации за указанный период не существует!!!\n\n" +
                    $"Период: {startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy}\n\n" +
                    $"Убедитесь, что за этот период есть данные в модуле \"Расчет по вахтам\".",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Отобразить отчет
            DisplayReport(_currentReport);
            ShowReport();
        }
        catch (Exception ex)
        {
            lblLoading.Visible = false;
            MessageBox.Show($"Ошибка при формировании отчета:\n\n{ex.Message}\n\nПроверьте правильность введенных дат.",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DisplayReport(O2GolReport report)
    {
        lblReportTitle.Text = $"АНАЛИЗ РАСХОДА ТОПЛИВА (В Т У.Т.) ПО БЛОКАМ С {report.StartDate:dd.MM.yyyy} ДО {report.EndDate:dd.MM.yyyy}";
        
        // Очистка таблиц
        dgvByBlock.Rows.Clear();
        dgvByBlock.Columns.Clear();
        dgvByShift.Rows.Clear();
        dgvByShift.Columns.Clear();

        // === ТАБЛИЦА ПО БЛОКАМ ===
        dgvByBlock.Columns.Add("Parameter", "ПОКАЗАТЕЛЬ");
        for (int i = 1; i <= 12; i++)
        {
            dgvByBlock.Columns.Add($"Block{i}", $"{i}");
        }
        dgvByBlock.Columns.Add("Total", "ПО СТАНЦИИ");

        // Выработка (МВт·ч)
        int idx = dgvByBlock.Rows.Add();
        dgvByBlock.Rows[idx].Cells["Parameter"].Value = "ВЫРАБОТКА (МВт·ч)";
        double totalGen = 0;
        for (int i = 0; i < 12; i++)
        {
            dgvByBlock.Rows[idx].Cells[$"Block{i + 1}"].Value = report.GenerationByBlock[i];
            totalGen += report.GenerationByBlock[i];
        }
        dgvByBlock.Rows[idx].Cells["Total"].Value = totalGen;

        // Средняя нагрузка (МВт)
        idx = dgvByBlock.Rows.Add();
        dgvByBlock.Rows[idx].Cells["Parameter"].Value = "СРЕДНЯЯ НАГРУЗКА (МВт)";
        double totalLoad = 0;
        for (int i = 0; i < 12; i++)
        {
            dgvByBlock.Rows[idx].Cells[$"Block{i + 1}"].Value = report.LoadByBlock[i];
            totalLoad += report.LoadByBlock[i];
        }
        dgvByBlock.Rows[idx].Cells["Total"].Value = report.AverageLoad;

        // Расход топлива по видам
        string[] fuelNames = {
            "РАСХОД УГЛЯ",
            "РАСХОД МАЗУТА",
            "РАСХОД ГАЗА",
            "ПОТЕРИ ОТ ТОПКИ",
            "ПОТЕРИ ОТ ПП",
            "РАСХОД НА СН",
            "ПОТЕРИ ОТ ПВД",
            "ВСЕГО",
            "УДЕЛЬНЫЙ РАСХОД"
        };

        for (int fuel = 0; fuel < 9; fuel++)
        {
            idx = dgvByBlock.Rows.Add();
            dgvByBlock.Rows[idx].Cells["Parameter"].Value = fuelNames[fuel];
            
            double total = 0;
            for (int block = 0; block < 12; block++)
            {
                double value = report.FuelByBlock[block, fuel];
                dgvByBlock.Rows[idx].Cells[$"Block{block + 1}"].Value = value;
                if (fuel < 8) total += value;
            }
            
            if (fuel < 8)
                dgvByBlock.Rows[idx].Cells["Total"].Value = report.TotalStation[fuel];
            else if (fuel == 8)
                dgvByBlock.Rows[idx].Cells["Total"].Value = report.TotalStation[8];
        }

        // === ТАБЛИЦА ПО ВАХТАМ ===
        dgvByShift.Columns.Add("Parameter", "ПОКАЗАТЕЛЬ");
        for (int i = 1; i <= 4; i++)
        {
            dgvByShift.Columns.Add($"Shift{i}", $"Вахта {i}");
        }
        dgvByShift.Columns.Add("Total", "ИТОГО");

        // Выработка
        idx = dgvByShift.Rows.Add();
        dgvByShift.Rows[idx].Cells["Parameter"].Value = "ВЫРАБОТКА (МВт·ч)";
        totalGen = 0;
        for (int i = 0; i < 4; i++)
        {
            dgvByShift.Rows[idx].Cells[$"Shift{i + 1}"].Value = report.GenerationByShift[i];
            totalGen += report.GenerationByShift[i];
        }
        dgvByShift.Rows[idx].Cells["Total"].Value = totalGen;

        // Средняя нагрузка
        idx = dgvByShift.Rows.Add();
        dgvByShift.Rows[idx].Cells["Parameter"].Value = "СРЕДНЯЯ НАГРУЗКА (МВт)";
        for (int i = 0; i < 4; i++)
        {
            dgvByShift.Rows[idx].Cells[$"Shift{i + 1}"].Value = report.LoadByShift[i];
        }
        dgvByShift.Rows[idx].Cells["Total"].Value = report.AverageLoad;

        // Расход топлива по видам
        for (int fuel = 0; fuel < 9; fuel++)
        {
            idx = dgvByShift.Rows.Add();
            dgvByShift.Rows[idx].Cells["Parameter"].Value = fuelNames[fuel];
            
            for (int shift = 0; shift < 4; shift++)
            {
                double value = report.FuelByShift[fuel, shift];
                dgvByShift.Rows[idx].Cells[$"Shift{shift + 1}"].Value = value;
            }
            
            if (fuel < 9)
                dgvByShift.Rows[idx].Cells["Total"].Value = report.TotalStation[fuel];
        }

        // Стили для таблиц
        ApplyTableStyles(dgvByBlock);
        ApplyTableStyles(dgvByShift);
    }

    private void ApplyTableStyles(DataGridView dgv)
    {
        dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dgv.RowHeadersVisible = false;
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.ReadOnly = true;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.MultiSelect = false;
        
        // Первый столбец шире
        if (dgv.Columns.Count > 0)
        {
            dgv.Columns[0].Width = 200;
        }
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
        if (_currentReport == null)
        {
            MessageBox.Show("Сначала сформируйте отчет!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        MessageBox.Show("Функция печати будет реализована в следующей версии.",
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        var mainForm = this.FindForm() as MainForm;
        mainForm?.ShowMainMenu();
    }

    private void btnBackFromReport_Click(object sender, EventArgs e)
    {
        ShowDateInput();
    }
}
