using TashGresOpto.Core.Services;
using TashGresOpto.Core.Calculators;
using TashGresOpto.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TashGresOpto.UI;

public partial class MainForm : Form
{
    private readonly IServiceProvider _serviceProvider;
    private Panel contentPanel;

    public MainForm(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
        InitializeUI();
        SetupContentPanel();
        ShowMainMenu();
    }

    private void SetupContentPanel()
    {
        // Создаем панель для контента
        contentPanel = new Panel
        {
            Dock = DockStyle.Fill,
            Location = new Point(0, 80),
            BackColor = Color.FromArgb(240, 240, 240)
        };
        this.Controls.Add(contentPanel);
        contentPanel.BringToFront();
    }

    public void ShowMainMenu()
    {
        contentPanel.Controls.Clear();
        
        // Создаем TableLayoutPanel для центрирования меню
        var tableLayout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            RowCount = 2,
            Padding = new Padding(40),
            BackColor = Color.White
        };
        
        // Настройка столбцов и строк
        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        
        // Убираем группы из panelMenu если они там есть
        if (groupDaily.Parent != null) groupDaily.Parent.Controls.Remove(groupDaily);
        if (groupWeekly.Parent != null) groupWeekly.Parent.Controls.Remove(groupWeekly);
        if (groupMonthly.Parent != null) groupMonthly.Parent.Controls.Remove(groupMonthly);
        if (groupOther.Parent != null) groupOther.Parent.Controls.Remove(groupOther);
        
        // Добавляем группы в TableLayout
        tableLayout.Controls.Add(groupDaily, 0, 0);
        tableLayout.Controls.Add(groupWeekly, 1, 0);
        tableLayout.Controls.Add(groupMonthly, 0, 1);
        tableLayout.Controls.Add(groupOther, 1, 1);
        
        // Устанавливаем Anchor для групп - центрирование
        groupDaily.Anchor = AnchorStyles.None;
        groupWeekly.Anchor = AnchorStyles.None;
        groupMonthly.Anchor = AnchorStyles.None;
        groupOther.Anchor = AnchorStyles.None;
        
        contentPanel.Controls.Add(tableLayout);
    }

    public void LoadUserControl(UserControl control)
    {
        contentPanel.Controls.Clear();
        control.Dock = DockStyle.Fill;
        contentPanel.Controls.Add(control);
    }

    private void InitializeUI()
    {
        // Установка заголовка и размеров
        this.Text = "ОПТО ТашТЭС - Оперативные задачи";
        this.Size = new Size(1200, 800);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.BackColor = Color.FromArgb(240, 240, 240);
        
        // Установка правильного русского текста для всех элементов
        lblTitle.Text = "ОПТО ТашТЭС - Оперативные задачи";
        
        groupDaily.Text = "ЕЖЕДНЕВНО";
        btnBaxta.Text = "1. Ежедневный расчет по вахтам";
        btnPerejeg.Text = "2. Пережоги топлива";
        btnWyrabotka.Text = "3. Выработка электроэнергии";
        
        groupWeekly.Text = "ЕЖЕНЕДЕЛЬНО";
        btnO2Gol.Text = "4. Сводный расчет по вахтам";
        
        groupMonthly.Text = "В КОНЦЕ МЕСЯЦА";
        btnAkt.Text = "5. Акт по выработке электроэнергии";
        btnSelektor.Text = "6. Расчет для селектора";
        btnWymes.Text = "7. ПЕРЕХОД НА НОВЫЙ МЕСЯЦ";
        
        groupOther.Text = "ПО МЕРЕ НЕОБХОДИМОСТИ";
        btnCopdata.Text = "8. Копирование данных на носитель";
        btnHelp.Text = "9. Справка";
    }

    // Обработчики для меню
    private void btnBaxta_Click(object sender, EventArgs e)
    {
        // Открыть панель управления BAXTA
        var baxtaControl = new Forms.BaxtaMainControl(_serviceProvider);
        LoadUserControl(baxtaControl);
    }

    private void btnPerejeg_Click(object sender, EventArgs e)
    {
        // Открыть панель управления Пережоги топлива
        var perejegControl = _serviceProvider.GetRequiredService<Forms.PerejegMainControl>();
        LoadUserControl(perejegControl);
    }

    private void btnWyrabotka_Click(object sender, EventArgs e)
    {
        // Открыть панель управления Выработка электроэнергии
        var wyrabotkaControl = _serviceProvider.GetRequiredService<Forms.WyrabotkaMainControl>();
        LoadUserControl(wyrabotkaControl);
    }

    private void btnO2Gol_Click(object sender, EventArgs e)
    {
        // Открыть панель управления Сводный расчет по вахтам
        var o2golControl = _serviceProvider.GetRequiredService<Forms.O2GolMainControl>();
        LoadUserControl(o2golControl);
    }

    private void btnAkt_Click(object sender, EventArgs e)
    {
        // Открыть форму акта выработки
        MessageBox.Show("Открытие модуля: Акт по выработке электроэнергии", "Информация");
    }

    private void btnSelektor_Click(object sender, EventArgs e)
    {
        // Открыть форму селектора
        MessageBox.Show("Открытие модуля: Расчет для селектора", "Информация");
    }

    private void btnWymes_Click(object sender, EventArgs e)
    {
        // Переход на новый месяц
        var result = MessageBox.Show(
            "Вы уверены, что хотите выполнить переход на новый месяц?",
            "Подтверждение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        
        if (result == DialogResult.Yes)
        {
            MessageBox.Show("Выполнение перехода на новый месяц...", "Информация");
        }
    }

    private void btnCopdata_Click(object sender, EventArgs e)
    {
        // Копирование данных
        MessageBox.Show("Открытие модуля: Копирование данных", "Информация");
    }

    private void btnHelp_Click(object sender, EventArgs e)
    {
        // Справка
        MessageBox.Show(
            "ОПТО ТашТЭС - Система оперативных задач\n\n" +
            "Версия 2.0 (C# Windows Forms)\n\n" +
            "Портирование с FoxPro/Clipper\n" +
            "© 2026",
            "О программе");
    }
}
