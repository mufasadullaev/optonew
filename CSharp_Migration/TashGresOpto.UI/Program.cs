using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TashGresOpto.Data.Context;
using TashGresOpto.Core.Calculators;
using TashGresOpto.Core.Services;

namespace TashGresOpto.UI;

static class Program
{
    [STAThread]
    static void Main()
    {
        // Установка UTF-8 кодировки для всего приложения
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        // Настройка Dependency Injection
        var services = new ServiceCollection();
        ConfigureServices(services);
        var serviceProvider = services.BuildServiceProvider();

        // Инициализация базы данных
        using (var scope = serviceProvider.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<OptoDbContext>();
            context.Database.EnsureCreated();
        }

        // Запуск главной формы
        Application.Run(serviceProvider.GetRequiredService<MainForm>());
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        // DbContext
        services.AddDbContext<OptoDbContext>(options =>
            options.UseSqlite("Data Source=TashGresOpto.db"));

        // Калькуляторы
        services.AddTransient<FuelCalculator>();
        services.AddTransient<OverburnCalculator>();
        services.AddTransient<PowerCalculator>();

        // Сервисы
        services.AddTransient<BaxtaService>();
        services.AddTransient<O2GolService>();

        // Формы
        services.AddTransient<MainForm>();
        services.AddTransient<TashGresOpto.UI.Forms.BaxtaForm>();
        services.AddTransient<TashGresOpto.UI.Forms.BaxtaScheduleForm>();
        services.AddTransient<TashGresOpto.UI.Forms.BaxtaScheduleControl>();
        services.AddTransient<TashGresOpto.UI.Forms.BaxtaMainControl>();
        services.AddTransient<TashGresOpto.UI.Forms.PerejegMainControl>();
        services.AddTransient<TashGresOpto.UI.Forms.WyrabotkaMainControl>();
        services.AddTransient<TashGresOpto.UI.Forms.O2GolMainControl>();
    }
}
