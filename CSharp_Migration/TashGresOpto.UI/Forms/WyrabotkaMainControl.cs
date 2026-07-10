using TashGresOpto.Data.Context;
using TashGresOpto.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TashGresOpto.UI.Forms;

public partial class WyrabotkaMainControl : UserControl
{
    private readonly IServiceProvider _serviceProvider;
    private readonly OptoDbContext _context;
    private DateTime _selectedDate;
    private int _currentAction = 0;

    public WyrabotkaMainControl(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _context = serviceProvider.GetRequiredService<OptoDbContext>();
        
        InitializeComponent();
        InitializeUI();
        ShowMainMenu();
    }

    private void InitializeUI()
    {
        lblTitle.Text = "ВЫРАБОТКА ЭЛЕКТРОЭНЕРГИИ";
        btnCalculate.Text = "РАСЧЕТ";
        btnCopy.Text = "COPY";
        btnPrint.Text = "ПЕЧАТЬ";
        btnBack.Text = "НАЗАД В ГЛАВНОЕ МЕНЮ";
    }

    private void ShowMainMenu()
    {
        panelMainMenu.Visible = true;
        panelDateInput.Visible = false;
        panelCalcType.Visible = false;
        panelDataEntry.Visible = false;
        panelMainMenu.Dock = DockStyle.Fill;
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        ShowDateInput();
        _currentAction = 1; // РАСЧ
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Функция копирования данных будет реализована в следующей версии.",
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
        // Количество экземпляров для печати
        var result = MessageBox.Show("Печать отчета выработки электроэнергии?",
            "Печать", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
        if (result == DialogResult.Yes)
        {
            MessageBox.Show("Функция печати будет реализована в следующей версии.",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        var mainForm = this.FindForm() as MainForm;
        mainForm?.ShowMainMenu();
    }

    private void ShowDateInput()
    {
        panelMainMenu.Visible = false;
        panelDateInput.Visible = true;
        panelCalcType.Visible = false;
        panelDataEntry.Visible = false;
        panelDateInput.Dock = DockStyle.Fill;
        
        dtpDate.Value = DateTime.Now;
        lblDateWarning.Visible = false;
    }

    private void btnDateOk_Click(object sender, EventArgs e)
    {
        _selectedDate = dtpDate.Value;
        
        // Проверка: если 1-е число месяца, предупреждение
        if (_selectedDate.Day == 1)
        {
            var result = MessageBox.Show(
                "Уважаемый пользователь!!! ВЫ набрали первое число месяца,\n" +
                "перед этим числом ВЫ должны были запустить в главном меню\n" +
                "режим 'Переход на новый месяц'. ВЫ запустили его?",
                "Внимание!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            
            if (result == DialogResult.No)
            {
                ShowMainMenu();
                return;
            }
        }
        
        ShowCalcTypeSelection();
    }

    private void btnDateCancel_Click(object sender, EventArgs e)
    {
        ShowMainMenu();
    }

    private void ShowCalcTypeSelection()
    {
        panelMainMenu.Visible = false;
        panelDateInput.Visible = false;
        panelCalcType.Visible = true;
        panelDataEntry.Visible = false;
        panelCalcType.Dock = DockStyle.Fill;
        
        lblCalcTypeTitle.Text = "РАСЧет или ПЕРЕрасчет?";
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
        // Первичный расчет
        ShowDataEntry(false);
    }

    private void btnRecalc_Click(object sender, EventArgs e)
    {
        // Перерасчет
        ShowDataEntry(true);
    }

    private void btnCalcTypeCancel_Click(object sender, EventArgs e)
    {
        ShowDateInput();
    }

    private void ShowDataEntry(bool isRecalc)
    {
        panelMainMenu.Visible = false;
        panelDateInput.Visible = false;
        panelCalcType.Visible = false;
        panelDataEntry.Visible = true;
        panelDataEntry.Dock = DockStyle.Fill;
        
        lblDataTitle.Text = isRecalc ? "ПЕРЕРАСЧЕТ ВЫРАБОТКИ" : "РАСЧЕТ ВЫРАБОТКИ";
        lblDateValue.Text = _selectedDate.ToString("dd.MM.yyyy");
        
        LoadDataToGrid();
    }

    private void LoadDataToGrid()
    {
        dgvData.Rows.Clear();
        dgvData.Columns.Clear();
        
        // Настройка колонок
        dgvData.Columns.Add("BlockNumber", "№ блока");
        dgvData.Columns.Add("CounterNumber", "№ счетчика");
        dgvData.Columns.Add("Coefficient", "Коэфф.");
        dgvData.Columns.Add("ReadingStart", "Показ. нач.");
        dgvData.Columns.Add("ReadingEnd", "Показ. кон.");
        dgvData.Columns.Add("Generation", "Выработка");
        dgvData.Columns.Add("Power", "Мощность");
        dgvData.Columns.Add("Hours", "Часы");
        dgvData.Columns.Add("SN", "СН");
        dgvData.Columns.Add("SNPercent", "СН %");
        
        // Загрузка данных за выбранную дату
        var data = _context.Wyrab
            .Where(w => w.Date.Date == _selectedDate.Date)
            .OrderBy(w => w.BlockNumber)
            .ToList();
        
        if (data.Count == 0)
        {
            // Создать новые записи для 12 блоков
            for (int i = 1; i <= 12; i++)
            {
                var wyrab = new Wyrab
                {
                    Date = _selectedDate,
                    BlockNumber = i,
                    GeneratorCounterNumber = $"Г{i}",
                    GeneratorCoefficient = 1.0,
                    ReadingStart = 0,
                    ReadingEnd = 0,
                    Generation = 0,
                    Power = 0,
                    Hours = 0,
                    SNCounterNumber = $"СН{i}",
                    SNCoefficient = 1.0,
                    SNReadingStart = 0,
                    SNReadingEnd = 0,
                    SN = 0,
                    SNPercent = 0
                };
                _context.Wyrab.Add(wyrab);
                data.Add(wyrab);
            }
            _context.SaveChanges();
        }
        
        // Заполнение таблицы
        foreach (var row in data)
        {
            int idx = dgvData.Rows.Add();
            dgvData.Rows[idx].Cells["BlockNumber"].Value = row.BlockNumber;
            dgvData.Rows[idx].Cells["CounterNumber"].Value = row.GeneratorCounterNumber;
            dgvData.Rows[idx].Cells["Coefficient"].Value = row.GeneratorCoefficient;
            dgvData.Rows[idx].Cells["ReadingStart"].Value = row.ReadingStart;
            dgvData.Rows[idx].Cells["ReadingEnd"].Value = row.ReadingEnd;
            dgvData.Rows[idx].Cells["Generation"].Value = row.Generation;
            dgvData.Rows[idx].Cells["Power"].Value = row.Power;
            dgvData.Rows[idx].Cells["Hours"].Value = row.Hours;
            dgvData.Rows[idx].Cells["SN"].Value = row.SN;
            dgvData.Rows[idx].Cells["SNPercent"].Value = row.SNPercent;
        }
        
        // Настройка стиля DataGridView
        dgvData.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
        dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
        dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvData.RowHeadersVisible = false;
        dgvData.AllowUserToAddRows = false;
        dgvData.AllowUserToDeleteRows = false;
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvData.MultiSelect = false;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            var data = _context.Wyrab
                .Where(w => w.Date.Date == _selectedDate.Date)
                .OrderBy(w => w.BlockNumber)
                .ToList();
            
            for (int i = 0; i < dgvData.Rows.Count && i < data.Count; i++)
            {
                var row = dgvData.Rows[i];
                var wyrab = data[i];
                
                // Обновление данных из таблицы
                if (double.TryParse(row.Cells["ReadingStart"].Value?.ToString(), out double readingStart))
                    wyrab.ReadingStart = readingStart;
                
                if (double.TryParse(row.Cells["ReadingEnd"].Value?.ToString(), out double readingEnd))
                    wyrab.ReadingEnd = readingEnd;
                
                if (double.TryParse(row.Cells["Coefficient"].Value?.ToString(), out double coeff))
                    wyrab.GeneratorCoefficient = coeff;
                
                // Расчет выработки
                double generation = (readingEnd - readingStart) * wyrab.GeneratorCoefficient;
                wyrab.Generation = generation;
                
                wyrab.ModifiedDate = DateTime.Now;
            }
            
            _context.SaveChanges();
            
            MessageBox.Show("Данные успешно сохранены!", "Успех", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Обновить отображение
            LoadDataToGrid();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCalculateData_Click(object sender, EventArgs e)
    {
        try
        {
            btnSave_Click(sender, e); // Сначала сохранить текущие данные
            
            MessageBox.Show("Расчет выполнен успешно!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при расчете: {ex.Message}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnDataCancel_Click(object sender, EventArgs e)
    {
        ShowMainMenu();
    }
}
