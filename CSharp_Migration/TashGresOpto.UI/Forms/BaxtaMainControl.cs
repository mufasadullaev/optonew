using TashGresOpto.Data.Context;
using TashGresOpto.Data.Entities;
using TashGresOpto.Core.Calculators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TashGresOpto.UI.Forms;

public partial class BaxtaMainControl : UserControl
{
    private readonly IServiceProvider _serviceProvider;
    private readonly OptoDbContext _context;
    private readonly FuelCalculator _fuelCalculator;
    private DateTime _selectedDate;
    private int _calculationType;

    public BaxtaMainControl(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _context = serviceProvider.GetRequiredService<OptoDbContext>();
        _fuelCalculator = serviceProvider.GetRequiredService<FuelCalculator>();
        
        InitializeComponent();
        InitializeUI();
        ShowMainMenu();
    }

    private void InitializeUI()
    {
        // Главное меню
        lblTitle.Text = "ЕЖЕДНЕВНЫЙ РАСЧЕТ ПО ВАХТАМ";
        btnViewSchedule.Text = "СМОТРЕТЬ ГРАФИК ВАХТ";
        btnEditData.Text = "РЕДАКТИРОВАТЬ ИСХОДНЫЕ ДАННЫЕ";
        btnPrintForms.Text = "ПЕЧАТЬ ВЫХОДНЫХ ФОРМ";
        btnBackToMain.Text = "НАЗАД В ГЛАВНОЕ МЕНЮ";
        
        // Панель выбора даты
        lblDateTitle.Text = "Укажите дату: ДД, ММ, ГГГГ";
        lblCalcType.Text = "ПЕРВый или ПОВТорный расчет?";
        btnFirstCalc.Text = "ПЕРВ";
        btnRepeatCalc.Text = "ПОВТ";
        btnCancelDate.Text = "ОТМЕНА";
        
        // Форма ввода данных
        lblDataTitle.Text = "РЕДАКТИРОВАНИЕ ИСХОДНЫХ ДАННЫХ";
        lblEditDate.Text = "Дата:";
        
        // Заголовки технологических параметров
        lblTim.Text = "Время работы (ч):";
        lblDro.Text = "Дросселирование:";
        lblPwd.Text = "Признак ПВД:";
        lblTpw.Text = "Темп. пит. воды:";
        lblTk.Text = "Темп. конденсата:";
        lblTop.Text = "Темп. острого пара:";
        lblTpp.Text = "Темп. промперегрева:";
        lblPop.Text = "Давление ост. пара:";
        lblTug.Text = "Темп. ух. газов:";
        lblThw.Text = "Темп. хол. воды:";
        lblO2.Text = "Содержание O2:";
        
        // Результаты
        lblPugResult.Text = "ПУГ (по ух. газам):";
        lblWakResult.Text = "ВАК (по вакууму):";
        lblDopResult.Text = "ДОП (дополнит.):";
        lblTopResult.Text = "ТОП (по т. ост. пара):";
        lblTppResult.Text = "ТПП (по т. промперегрева):";
        lblSnResult.Text = "СН (собств. нужды):";
        lblTpwResult.Text = "ТПВ (по т. пит. воды):";
        lblTotalResult.Text = "ВСЕГО:";
        lblGkbtResult.Text = "ГКБТ (уд. расход):";
        
        btnCalculate.Text = "РАССЧИТАТЬ";
        btnSave.Text = "СОХРАНИТЬ";
        btnContinueEdit.Text = "ПРОДОЛЖИТЬ РЕДАКТИРОВАНИЕ";
        btnClose.Text = "ВЫХОД БЕЗ РАСЧЕТА";
    }

    private void ShowMainMenu()
    {
        panelMainMenu.Visible = true;
        panelDateSelection.Visible = false;
        panelDataEntry.Visible = false;
        panelMainMenu.Dock = DockStyle.Fill;
    }

    private void ShowDateSelection()
    {
        panelMainMenu.Visible = false;
        panelDateSelection.Visible = true;
        panelDataEntry.Visible = false;
        panelDateSelection.Dock = DockStyle.Fill;
        
        dtpDate.Value = DateTime.Now;
    }

    private void ShowDataEntry()
    {
        panelMainMenu.Visible = false;
        panelDateSelection.Visible = false;
        panelDataEntry.Visible = true;
        panelDataEntry.Dock = DockStyle.Fill;
        
        lblEditDateValue.Text = _selectedDate.ToString("dd.MM.yyyy");
        LoadExistingData();
        SetupCountersGrid();
    }

    private void SetupCountersGrid()
    {
        dgvCounters.Rows.Clear();
        dgvCounters.Columns.Clear();
        
        // Настройка колонок
        dgvCounters.Columns.Add("Block", "N БЛОКА");
        dgvCounters.Columns.Add("Shift", "СМЕНА");
        dgvCounters.Columns.Add("Output", "ВЫРАБ.");
        dgvCounters.Columns.Add("SN", "С.Н.");
        
        dgvCounters.Columns[0].Width = 120;
        dgvCounters.Columns[1].Width = 120;
        dgvCounters.Columns[2].Width = 150;
        dgvCounters.Columns[3].Width = 150;
        
        // Добавляем строки для блоков и смен (пример: 3 блока х 3 смены = 9 строк)
        for (int block = 1; block <= 3; block++)
        {
            for (int shift = 1; shift <= 3; shift++)
            {
                int rowIndex = dgvCounters.Rows.Add();
                dgvCounters.Rows[rowIndex].Cells["Block"].Value = block;
                dgvCounters.Rows[rowIndex].Cells["Shift"].Value = shift;
                dgvCounters.Rows[rowIndex].Cells["Output"].Value = 0.0;
                dgvCounters.Rows[rowIndex].Cells["SN"].Value = 0.0;
            }
        }
    }

    private void LoadExistingData()
    {
        // Загрузка существующих данных за выбранную дату
        int mmdd = int.Parse(_selectedDate.ToString("MMdd"));
        
        var existingData = _context.Baxta
            .Where(b => b.MMDD == mmdd)
            .OrderBy(b => b.NB)
            .ThenBy(b => b.Smena)
            .ToList();
        
        if (existingData.Any())
        {
            // Заполнить форму существующими данными
            var firstRecord = existingData.First();
            // Можно загрузить технологические параметры
        }
    }

    private void btnViewSchedule_Click(object sender, EventArgs e)
    {
        var scheduleControl = _serviceProvider.GetRequiredService<BaxtaScheduleControl>();
        var mainForm = this.FindForm() as MainForm;
        mainForm?.LoadUserControl(scheduleControl);
    }

    private void btnEditData_Click(object sender, EventArgs e)
    {
        ShowDateSelection();
    }

    private void btnPrintForms_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Функция печати будет реализована в следующей версии.", 
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnBackToMain_Click(object sender, EventArgs e)
    {
        var mainForm = this.FindForm() as MainForm;
        mainForm?.ShowMainMenu();
    }

    private void btnFirstCalc_Click(object sender, EventArgs e)
    {
        _selectedDate = dtpDate.Value;
        _calculationType = 1;
        
        int mmdd = int.Parse(_selectedDate.ToString("MMdd"));
        var existing = _context.Baxta.Any(b => b.MMDD == mmdd);
        
        if (existing)
        {
            var result = MessageBox.Show(
                "За эту дату был первый расчет.\n\nОшибка или повторный расчет?",
                "Внимание",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
                
            if (result == DialogResult.No)
            {
                _calculationType = 2;
            }
            else
            {
                return;
            }
        }
        
        ShowDataEntry();
    }

    private void btnRepeatCalc_Click(object sender, EventArgs e)
    {
        _selectedDate = dtpDate.Value;
        _calculationType = 2;
        ShowDataEntry();
    }

    private void btnCancelDate_Click(object sender, EventArgs e)
    {
        ShowMainMenu();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            // === ВАЛИДАЦИЯ ТЕХНОЛОГИЧЕСКИХ ПАРАМЕТРОВ ===
            var paramValidation = TashGresOpto.UI.Helpers.ValidationHelper.ValidateBaxtaParams(
                (double)numThw.Value,
                (double)numTug.Value,
                (double)numO2.Value,
                (double)numTk.Value,
                (double)numPop.Value,
                (double)numTop.Value,
                (double)numTpp.Value,
                (double)numTpw.Value,
                (double)numDro.Value,
                (int)numPwd.Value,
                (double)numTim.Value
            );

            if (!paramValidation.IsValid)
            {
                MessageBox.Show(
                    "Ошибки в технологических параметрах:\n\n" + paramValidation.GetErrorMessage(),
                    "Ошибка валидации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // === ВАЛИДАЦИЯ ДАННЫХ СЧЕТЧИКОВ ===
            var counterErrors = new List<string>();
            foreach (DataGridViewRow row in dgvCounters.Rows)
            {
                if (row.IsNewRow) continue;

                try
                {
                    int block = Convert.ToInt32(row.Cells["Block"].Value);
                    int shift = Convert.ToInt32(row.Cells["Shift"].Value);
                    double output = Convert.ToDouble(row.Cells["Output"].Value ?? 0);
                    double sn = Convert.ToDouble(row.Cells["SN"].Value ?? 0);

                    if (output == 0) continue; // Пропускаем пустые строки

                    var validation = TashGresOpto.UI.Helpers.ValidationHelper.ValidateCounterData(
                        block, shift, output, sn);

                    if (!validation.IsValid)
                    {
                        counterErrors.AddRange(validation.Errors);
                    }
                }
                catch (Exception ex)
                {
                    counterErrors.Add($"Строка {row.Index + 1}: Ошибка формата данных - {ex.Message}");
                }
            }

            if (counterErrors.Any())
            {
                MessageBox.Show(
                    "Ошибки в данных счетчиков:\n\n" + string.Join("\n", counterErrors),
                    "Ошибка валидации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Очистка результатов
            txtPugResult.Text = "";
            txtWakResult.Text = "";
            txtDopResult.Text = "";
            txtTopResult.Text = "";
            txtTppResult.Text = "";
            txtSnResult.Text = "";
            txtTpwResult.Text = "";
            txtTotalResult.Text = "";
            txtGkbtResult.Text = "";
            
            double totalEconomy = 0;
            double totalOutput = 0;
            
            // Расчет для каждой строки (блок/смена)
            foreach (DataGridViewRow row in dgvCounters.Rows)
            {
                if (row.IsNewRow) continue;
                
                double output = Convert.ToDouble(row.Cells["Output"].Value ?? 0);
                double sn = Convert.ToDouble(row.Cells["SN"].Value ?? 0);
                
                if (output == 0) continue;
                
                totalOutput += output;
                
                // Заполнение входных данных для калькулятора
                var input = new TashGresOpto.Core.Calculators.FuelCalculationInput
                {
                    Nagruzka = output / 8.0,
                    Wyrabotka = output,
                    THW = (double)numThw.Value,
                    TUG = (double)numTug.Value,
                    O2 = (double)numO2.Value,
                    TK = (double)numTk.Value,
                    POP = (double)numPop.Value,
                    TOP = (double)numTop.Value,
                    TPP = (double)numTpp.Value,
                    TPW = (double)numTpw.Value,
                    DRO = (double)numDro.Value,
                    PWD = (int)numPwd.Value,
                    TIM = (double)numTim.Value,
                    ESN = sn,
                    Mpris = 1.0,
                    MTCB = 1.0,
                    MKF1 = 1.0,
                    MKF2 = 1.0,
                    MKL1 = 1.0,
                    MKL2 = 1.0
                };
                
                var result = _fuelCalculator.Calculate(input);
                totalEconomy += result.TotalEconomy;
            }
            
            if (totalOutput == 0)
            {
                MessageBox.Show("Введите данные в таблицу счетчиков!\n\nВыработка должна быть больше нуля хотя бы для одного блока/смены.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Повторный расчет для отображения результатов
            var firstRow = dgvCounters.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => !r.IsNewRow && Convert.ToDouble(r.Cells["Output"].Value ?? 0) > 0);

            if (firstRow == null)
            {
                MessageBox.Show("Не найдено ни одной строки с данными!", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double firstOutput = Convert.ToDouble(firstRow.Cells["Output"].Value);
            double firstSn = Convert.ToDouble(firstRow.Cells["SN"].Value);
            
            var displayInput = new TashGresOpto.Core.Calculators.FuelCalculationInput
            {
                Nagruzka = firstOutput / 8.0,
                Wyrabotka = firstOutput,
                THW = (double)numThw.Value,
                TUG = (double)numTug.Value,
                O2 = (double)numO2.Value,
                TK = (double)numTk.Value,
                POP = (double)numPop.Value,
                TOP = (double)numTop.Value,
                TPP = (double)numTpp.Value,
                TPW = (double)numTpw.Value,
                DRO = (double)numDro.Value,
                PWD = (int)numPwd.Value,
                TIM = (double)numTim.Value,
                ESN = firstSn,
                Mpris = 1.0,
                MTCB = 1.0,
                MKF1 = 1.0,
                MKF2 = 1.0,
                MKL1 = 1.0,
                MKL2 = 1.0
            };
            
            var displayResult = _fuelCalculator.Calculate(displayInput);
            
            // Отображение результатов
            txtPugResult.Text = displayResult.EKSUT1.ToString("F2");
            txtWakResult.Text = displayResult.EKSUT2.ToString("F2");
            txtDopResult.Text = displayResult.EKSUT3.ToString("F2");
            txtTopResult.Text = displayResult.EKSUT4.ToString("F2");
            txtTppResult.Text = displayResult.EKSUT5.ToString("F2");
            txtSnResult.Text = displayResult.EKSUT6.ToString("F2");
            txtTpwResult.Text = displayResult.EKSUT7.ToString("F2");
            txtTotalResult.Text = displayResult.TotalEconomy.ToString("F2");
            txtGkbtResult.Text = displayResult.SpecificConsumption.ToString("F2");
            
            btnSave.Enabled = true;
            
            MessageBox.Show(
                $"Расчет выполнен успешно!\n\n" +
                $"Общая выработка: {totalOutput:F2} МВт·ч\n" +
                $"Общая экономия/перерасход: {totalEconomy:F2} т у.т.",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при расчете:\n\n{ex.Message}\n\nПроверьте правильность введенных данных.", 
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            int mmdd = int.Parse(_selectedDate.ToString("MMdd"));
            
            // Сохранение данных из таблицы
            foreach (DataGridViewRow row in dgvCounters.Rows)
            {
                if (row.IsNewRow) continue;
                
                int block = Convert.ToInt32(row.Cells["Block"].Value);
                int shift = Convert.ToInt32(row.Cells["Shift"].Value);
                double output = Convert.ToDouble(row.Cells["Output"].Value);
                double sn = Convert.ToDouble(row.Cells["SN"].Value);
                
                if (output == 0) continue;
                
                var baxta = new Baxta
                {
                    NB = block,
                    MMDD = mmdd,
                    Smena = shift,
                    Nagr = output / 8.0,
                    PUG = string.IsNullOrEmpty(txtPugResult.Text) ? 0 : double.Parse(txtPugResult.Text),
                    WAK = string.IsNullOrEmpty(txtWakResult.Text) ? 0 : double.Parse(txtWakResult.Text),
                    DOP = string.IsNullOrEmpty(txtDopResult.Text) ? 0 : double.Parse(txtDopResult.Text),
                    TOP = string.IsNullOrEmpty(txtTopResult.Text) ? 0 : double.Parse(txtTopResult.Text),
                    TPP = string.IsNullOrEmpty(txtTppResult.Text) ? 0 : double.Parse(txtTppResult.Text),
                    SN = sn,
                    TPW = string.IsNullOrEmpty(txtTpwResult.Text) ? 0 : double.Parse(txtTpwResult.Text),
                    WSEGO = string.IsNullOrEmpty(txtTotalResult.Text) ? 0 : double.Parse(txtTotalResult.Text),
                    GKBT = string.IsNullOrEmpty(txtGkbtResult.Text) ? 0 : double.Parse(txtGkbtResult.Text),
                    CreatedDate = DateTime.Now
                };
                
                _context.Baxta.Add(baxta);
            }
            
            // Сохранение технологических параметров
            var baxtaParams = new BaxtaParams
            {
                BlockNumber = 1,
                Date = _selectedDate,
                Smena = 1,
                TIM = (double)numTim.Value,
                DRO = (double)numDro.Value,
                PWD = (int)numPwd.Value,
                TPW = (double)numTpw.Value,
                TK = (double)numTk.Value,
                TOP = (double)numTop.Value,
                TPP = (double)numTpp.Value,
                POP = (double)numPop.Value,
                TUG = (double)numTug.Value,
                THW = (double)numThw.Value,
                O2 = (double)numO2.Value,
                CreatedDate = DateTime.Now
            };
            
            _context.BaxtaParams.Add(baxtaParams);
            _context.SaveChanges();
            
            MessageBox.Show("Данные успешно сохранены в базу данных!", "Информация", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            btnSave.Enabled = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnContinueEdit_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
            "Продолжать редактирование?\n\n(ESC - выход без расчета)",
            "Подтверждение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            
        if (result == DialogResult.Yes)
        {
            // Очистить форму для нового ввода
            SetupCountersGrid();
            txtPugResult.Text = "";
            txtWakResult.Text = "";
            txtDopResult.Text = "";
            txtTopResult.Text = "";
            txtTppResult.Text = "";
            txtSnResult.Text = "";
            txtTpwResult.Text = "";
            txtTotalResult.Text = "";
            txtGkbtResult.Text = "";
            btnSave.Enabled = false;
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
            "Выйти без расчета?\n\nНесохраненные данные будут потеряны.",
            "Подтверждение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            
        if (result == DialogResult.Yes)
        {
            ShowMainMenu();
        }
    }
}
