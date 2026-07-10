using TashGresOpto.Data.Context;
using TashGresOpto.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TashGresOpto.UI.Forms;

public partial class PerejegMainControl : UserControl
{
    private readonly IServiceProvider _serviceProvider;
    private readonly OptoDbContext _context;
    private DateTime _selectedDate;
    private DateTime _selectedDateEnd;

    public PerejegMainControl(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _context = serviceProvider.GetRequiredService<OptoDbContext>();
        
        InitializeComponent();
        InitializeUI();
        ShowMainMenu();
    }

    private void InitializeUI()
    {
        lblTitle.Text = "ПЕРЕЖОГИ ТОПЛИВА";
        btnDailyCalc.Text = "1. Расчет пережогов за сутки";
        btnPrintDaily.Text = "2. Печать суточных пережогов";
        btnPrintCumulative.Text = "3. Печать нарастающего итога";
        btnViewDates.Text = "4. Просмотр расчетных дат";
        btnPrintBlank.Text = "5. Печать бланка для данных";
        btnBack.Text = "НАЗАД В ГЛАВНОЕ МЕНЮ";
    }

    private void ShowMainMenu()
    {
        panelMainMenu.Visible = true;
        panelDateInput.Visible = false;
        panelDataEntry.Visible = false;
        panelMainMenu.Dock = DockStyle.Fill;
    }

    private void ShowDateInput(int mode)
    {
        panelMainMenu.Visible = false;
        panelDateInput.Visible = true;
        panelDataEntry.Visible = false;
        panelDateInput.Dock = DockStyle.Fill;
        
        // mode: 1 - одна дата, 2 - диапазон дат
        if (mode == 1)
        {
            lblDateTitle.Text = "Укажите дату: ДД, ММ, ГГГГ";
            dtpDateEnd.Visible = false;
            lblDateTo.Visible = false;
        }
        else
        {
            lblDateTitle.Text = "С какого числа:                          по какое число:";
            dtpDateEnd.Visible = true;
            lblDateTo.Visible = true;
        }
        
        dtpDate.Value = DateTime.Now;
        dtpDateEnd.Value = DateTime.Now;
    }

    private void btnDailyCalc_Click(object sender, EventArgs e)
    {
        ShowDateInput(1);
        _currentAction = 1;
    }

    private int _currentAction = 0;

    private void btnPrintDaily_Click(object sender, EventArgs e)
    {
        ShowDateInput(1);
        _currentAction = 2;
    }

    private void btnPrintCumulative_Click(object sender, EventArgs e)
    {
        ShowDateInput(2);
        _currentAction = 3;
    }

    private void btnViewDates_Click(object sender, EventArgs e)
    {
        // Показать список расчетных дат
        ShowDatesList();
    }

    private void btnPrintBlank_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Функция печати бланка будет реализована в следующей версии.", 
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        var mainForm = this.FindForm() as MainForm;
        mainForm?.ShowMainMenu();
    }

    private void btnDateOk_Click(object sender, EventArgs e)
    {
        _selectedDate = dtpDate.Value;
        _selectedDateEnd = dtpDateEnd.Value;
        
        switch (_currentAction)
        {
            case 1:
                // Расчет пережогов за сутки
                ShowDataEntryForm();
                break;
            case 2:
                // Печать суточных пережогов
                PrintDailyReport();
                break;
            case 3:
                // Печать нарастающего итога
                PrintCumulativeReport();
                break;
        }
    }

    private void btnDateCancel_Click(object sender, EventArgs e)
    {
        ShowMainMenu();
    }

    private void ShowDataEntryForm()
    {
        // Загрузка или создание данных за выбранную дату
        int nome = GetNomeFromDate(_selectedDate);
        
        var existingData = _context.Perejeg
            .Where(p => p.Nome == nome)
            .OrderBy(p => p.Nomer)
            .ToList();
        
        if (existingData.Count == 0)
        {
            // Создать новые записи
            CreateNewDataForDate(nome);
        }
        
        // Показать форму редактирования
        panelMainMenu.Visible = false;
        panelDateInput.Visible = false;
        panelDataEntry.Visible = true;
        panelDataEntry.Dock = DockStyle.Fill;
        
        LoadDataToGrid(nome);
    }

    private int GetNomeFromDate(DateTime date)
    {
        return (date.Year % 100) * 10000 + date.Month * 100 + date.Day;
    }

    private void CreateNewDataForDate(int nome)
    {
        var types = _context.PerejegTypes.OrderBy(t => t.Nomer).ToList();
        
        foreach (var type in types)
        {
            var perejeg = new Perejeg
            {
                Nome = nome,
                Nomer = type.Nomer,
                Name = type.Name,
                Blok1 = 0, Blok2 = 0, Blok3 = 0, Blok4 = 0,
                Blok5 = 0, Blok6 = 0, Blok7 = 0, Blok8 = 0,
                Blok9 = 0, Blok10 = 0, Blok11 = 0, Blok12 = 0,
                Sblok = 0
            };
            _context.Perejeg.Add(perejeg);
        }
        _context.SaveChanges();
    }

    private void LoadDataToGrid(int nome)
    {
        var data = _context.Perejeg
            .Where(p => p.Nome == nome)
            .OrderBy(p => p.Nomer)
            .ToList();
        
        dgvData.Rows.Clear();
        dgvData.Columns.Clear();
        
        // Настройка колонок
        dgvData.Columns.Add("Nomer", "№");
        dgvData.Columns.Add("Name", "Наименование");
        for (int i = 1; i <= 12; i++)
        {
            dgvData.Columns.Add($"Blok{i}", $"Бл.{i}");
        }
        dgvData.Columns.Add("Sblok", "Сумма");
        
        // Заполнение данных
        foreach (var row in data)
        {
            int idx = dgvData.Rows.Add();
            dgvData.Rows[idx].Cells["Nomer"].Value = row.Nomer;
            dgvData.Rows[idx].Cells["Name"].Value = row.Name;
            dgvData.Rows[idx].Cells["Blok1"].Value = row.Blok1;
            dgvData.Rows[idx].Cells["Blok2"].Value = row.Blok2;
            dgvData.Rows[idx].Cells["Blok3"].Value = row.Blok3;
            dgvData.Rows[idx].Cells["Blok4"].Value = row.Blok4;
            dgvData.Rows[idx].Cells["Blok5"].Value = row.Blok5;
            dgvData.Rows[idx].Cells["Blok6"].Value = row.Blok6;
            dgvData.Rows[idx].Cells["Blok7"].Value = row.Blok7;
            dgvData.Rows[idx].Cells["Blok8"].Value = row.Blok8;
            dgvData.Rows[idx].Cells["Blok9"].Value = row.Blok9;
            dgvData.Rows[idx].Cells["Blok10"].Value = row.Blok10;
            dgvData.Rows[idx].Cells["Blok11"].Value = row.Blok11;
            dgvData.Rows[idx].Cells["Blok12"].Value = row.Blok12;
            dgvData.Rows[idx].Cells["Sblok"].Value = row.Sblok;
        }
    }

    private void ShowDatesList()
    {
        MessageBox.Show("Функция просмотра дат будет реализована в следующей версии.", 
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void PrintDailyReport()
    {
        MessageBox.Show($"Печать суточных пережогов за {_selectedDate:dd.MM.yyyy}", 
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void PrintCumulativeReport()
    {
        MessageBox.Show($"Печать нарастающего итога с {_selectedDate:dd.MM.yyyy} по {_selectedDateEnd:dd.MM.yyyy}", 
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnSaveData_Click(object sender, EventArgs e)
    {
        try
        {
            int nome = GetNomeFromDate(_selectedDate);
            
            // Получить данные из таблицы и сохранить в БД
            var data = _context.Perejeg
                .Where(p => p.Nome == nome)
                .OrderBy(p => p.Nomer)
                .ToList();
            
            int rowIndex = 0;
            foreach (var item in data)
            {
                if (rowIndex >= dgvData.Rows.Count) break;
                
                var row = dgvData.Rows[rowIndex];
                
                // Обновить значения из таблицы
                for (int i = 1; i <= 12; i++)
                {
                    string colName = $"Blok{i}";
                    if (dgvData.Columns.Contains(colName) && row.Cells[colName].Value != null)
                    {
                        double value = Convert.ToDouble(row.Cells[colName].Value);
                        
                        switch (i)
                        {
                            case 1: item.Blok1 = value; break;
                            case 2: item.Blok2 = value; break;
                            case 3: item.Blok3 = value; break;
                            case 4: item.Blok4 = value; break;
                            case 5: item.Blok5 = value; break;
                            case 6: item.Blok6 = value; break;
                            case 7: item.Blok7 = value; break;
                            case 8: item.Blok8 = value; break;
                            case 9: item.Blok9 = value; break;
                            case 10: item.Blok10 = value; break;
                            case 11: item.Blok11 = value; break;
                            case 12: item.Blok12 = value; break;
                        }
                    }
                }
                
                // Рассчитать сумму
                item.Sblok = item.Blok1 + item.Blok2 + item.Blok3 + item.Blok4 +
                             item.Blok5 + item.Blok6 + item.Blok7 + item.Blok8 +
                             item.Blok9 + item.Blok10 + item.Blok11 + item.Blok12;
                
                rowIndex++;
            }
            
            _context.SaveChanges();
            
            MessageBox.Show("Данные успешно сохранены!", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при сохранении данных:\n\n{ex.Message}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnBackFromData_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
            "Вернуться назад?\n\nНесохраненные изменения будут потеряны.",
            "Подтверждение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        
        if (result == DialogResult.Yes)
        {
            ShowMainMenu();
        }
    }
}
