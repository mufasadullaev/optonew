using TashGresOpto.Data.Context;

namespace TashGresOpto.UI.Forms;

public partial class BaxtaScheduleForm : Form
{
    private readonly OptoDbContext _context;
    
    public BaxtaScheduleForm(OptoDbContext context)
    {
        _context = context;
        InitializeComponent();
        InitializeUI();
        LoadScheduleData();
    }

    private void InitializeUI()
    {
        this.Text = "ОПТО ТашТЭС - График вахт";
        lblTitle.Text = "ГРАФИК РАБОТЫ ВАХТ";
        lblWarning.Text = "ВНИМАНИЕ! Хранятся только исходные данные за даты, указанные в столбце ММ.ДД";
        btnClose.Text = "ЗАКРЫТЬ (нажмите любую клавишу)";
    }

    private void LoadScheduleData()
    {
        // Настройка DataGridView
        dgvSchedule.Columns.Clear();
        dgvSchedule.Rows.Clear();
        
        dgvSchedule.Columns.Add("Shift1", "1 СМЕНА");
        dgvSchedule.Columns.Add("Shift2", "2 СМЕНА");
        dgvSchedule.Columns.Add("Shift3", "3 СМЕНА");
        dgvSchedule.Columns.Add("RestShift", "ОТД.ВАХТА");
        dgvSchedule.Columns.Add("Flag", "ПРИЗНАК");
        dgvSchedule.Columns.Add("Date", "ММ.ДД");
        
        dgvSchedule.Columns[0].Width = 120;
        dgvSchedule.Columns[1].Width = 120;
        dgvSchedule.Columns[2].Width = 120;
        dgvSchedule.Columns[3].Width = 140;
        dgvSchedule.Columns[4].Width = 100;
        dgvSchedule.Columns[5].Width = 120;
        
        dgvSchedule.AllowUserToAddRows = false;
        dgvSchedule.ReadOnly = true;
        dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        
        // В оригинале данные берутся из BAXTA0.DBF (строки 232-244)
        // mraz, mdwa, mtri, mche, mpat, mshe
        // Пока загружаем последние 8 дат из базы
        var recentDates = _context.Baxta
            .OrderByDescending(b => b.MMDD)
            .Select(b => new { b.MMDD, b.Smena, b.NB })
            .Distinct()
            .Take(8)
            .ToList();
        
        // Для демонстрации добавляем 8 строк с примерными данными
        // В реальности здесь должна быть логика загрузки из BAXTA0
        for (int i = 1; i <= 8; i++)
        {
            int rowIndex = dgvSchedule.Rows.Add();
            
            // Эти данные должны браться из массивов mraz, mdwa, mtri, mche, mpat, mshe
            // Циклический график вахт (1, 2, 3, 4)
            int shift1 = ((i - 1) % 4) + 1;  // mraz - 1 смена
            int shift2 = (i % 4) + 1;         // mdwa - 2 смена
            int shift3 = ((i + 1) % 4) + 1;   // mtri - 3 смена
            
            // Отдыхающая вахта - та, которая не работает
            int restShift = 10 - shift1 - shift2 - shift3;  // mche - сумма всех вахт = 10 (1+2+3+4)
            
            dgvSchedule.Rows[rowIndex].Cells["Shift1"].Value = shift1;
            dgvSchedule.Rows[rowIndex].Cells["Shift2"].Value = shift2;
            dgvSchedule.Rows[rowIndex].Cells["Shift3"].Value = shift3;
            dgvSchedule.Rows[rowIndex].Cells["RestShift"].Value = restShift;
            dgvSchedule.Rows[rowIndex].Cells["Flag"].Value = 0;  // mpat
            
            // Дата в формате ММ.ДД (mshe)
            if (i <= recentDates.Count && recentDates[i - 1] != null)
            {
                int mmdd = recentDates[i - 1].MMDD;
                dgvSchedule.Rows[rowIndex].Cells["Date"].Value = FormatDate(mmdd);
            }
            else
            {
                // Примерная дата
                var date = DateTime.Now.AddDays(-i);
                int mmdd = int.Parse(date.ToString("MMdd"));
                dgvSchedule.Rows[rowIndex].Cells["Date"].Value = FormatDate(mmdd);
            }
        }
        
        // Применяем современный стиль
        dgvSchedule.BackgroundColor = Color.White;
        dgvSchedule.GridColor = Color.FromArgb(220, 220, 220);
        dgvSchedule.BorderStyle = BorderStyle.None;
        
        dgvSchedule.DefaultCellStyle.BackColor = Color.White;
        dgvSchedule.DefaultCellStyle.ForeColor = Color.FromArgb(60, 60, 60);
        dgvSchedule.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
        dgvSchedule.DefaultCellStyle.SelectionForeColor = Color.White;
        dgvSchedule.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        dgvSchedule.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvSchedule.DefaultCellStyle.Padding = new Padding(5);
        
        dgvSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
        dgvSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvSchedule.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        dgvSchedule.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvSchedule.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
        dgvSchedule.ColumnHeadersHeight = 45;
        
        dgvSchedule.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        dgvSchedule.RowTemplate.Height = 40;
        dgvSchedule.EnableHeadersVisualStyles = false;
        dgvSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
    }

    private string FormatDate(int mmdd)
    {
        // Преобразуем MMDD в формат ММ.ДД
        // Например: 415 -> "04.15", 1225 -> "12.25"
        string mmddStr = mmdd.ToString().PadLeft(4, '0');
        string month = mmddStr.Substring(0, 2);
        string day = mmddStr.Substring(2, 2);
        return $"{month}.{day}";
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        // Закрытие по любой клавише (как в оригинале - inkey(0))
        if (keyData != Keys.None)
        {
            this.Close();
            return true;
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }
}
