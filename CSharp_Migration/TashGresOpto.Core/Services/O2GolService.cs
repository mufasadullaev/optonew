using TashGresOpto.Data.Context;
using TashGresOpto.Data.Entities;
using TashGresOpto.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace TashGresOpto.Core.Services;

public class O2GolService
{
    private readonly OptoDbContext _context;

    public O2GolService(OptoDbContext context)
    {
        _context = context;
    }

    public async Task<O2GolReport> GenerateReportAsync(DateTime startDate, DateTime endDate)
    {
        var report = new O2GolReport
        {
            StartDate = startDate,
            EndDate = endDate
        };

        // Загрузить данные за период из BaxtaParams
        int minDate = startDate.Month * 100 + startDate.Day;
        int maxDate = endDate.Month * 100 + endDate.Day;

        var data = await _context.BaxtaParams
            .Where(bp => bp.Date >= startDate && bp.Date <= endDate)
            .ToListAsync();

        if (data.Count == 0)
        {
            return report; // Пустой отчет
        }

        // Агрегирование данных по блокам и вахтам
        foreach (var item in data)
        {
            int blockIndex = item.BlockNumber - 1; // 0-based
            int shiftIndex = item.Smena - 1; // 0-based

            if (blockIndex < 0 || blockIndex >= 12 || shiftIndex < 0 || shiftIndex >= 4)
                continue;

            // Расход топлива по видам (индексы 0-6 соответствуют различным видам расхода)
            // Упрощенная логика - в оригинале есть много расчетов
            double ppug = item.THW; // условно - потребление угля
            double pwak = item.TUG; // условно - другой показатель
            double pdop = item.O2;
            double ptop = item.TK;
            double ptpp = item.POP;
            double psn = item.TOP;
            double ptpw = item.TPP;

            // Агрегирование по вахтам
            report.FuelByShift[0, shiftIndex] += ppug / 1000;
            report.FuelByShift[1, shiftIndex] += pwak / 1000;
            report.FuelByShift[2, shiftIndex] += pdop / 1000;
            report.FuelByShift[3, shiftIndex] += ptop / 1000;
            report.FuelByShift[4, shiftIndex] += ptpp / 1000;
            report.FuelByShift[5, shiftIndex] += psn / 1000;
            report.FuelByShift[6, shiftIndex] += ptpw / 1000;

            // Агрегирование по блокам
            report.FuelByBlock[blockIndex, 0] += ppug / 1000;
            report.FuelByBlock[blockIndex, 1] += pwak / 1000;
            report.FuelByBlock[blockIndex, 2] += pdop / 1000;
            report.FuelByBlock[blockIndex, 3] += ptop / 1000;
            report.FuelByBlock[blockIndex, 4] += ptpp / 1000;
            report.FuelByBlock[blockIndex, 5] += psn / 1000;
            report.FuelByBlock[blockIndex, 6] += ptpw / 1000;

            // Нагрузка и выработка (упрощенная логика)
            double load = item.TPW; // условная нагрузка
            double generation = load * 8; // выработка за 8 часов

            report.LoadByShift[shiftIndex] += load;
            report.LoadByBlock[blockIndex] += load;
            report.GenerationByShift[shiftIndex] += generation;
            report.GenerationByBlock[blockIndex] += generation;

            report.CountByShift[shiftIndex]++;
            report.CountByBlock[blockIndex]++;
        }

        // Расчет средних значений нагрузки
        for (int i = 0; i < 4; i++)
        {
            if (report.CountByShift[i] > 0)
            {
                report.LoadByShift[i] /= report.CountByShift[i];
            }
        }

        for (int i = 0; i < 12; i++)
        {
            if (report.CountByBlock[i] > 0)
            {
                report.LoadByBlock[i] /= report.CountByBlock[i];
            }
        }

        // Расчет итогов по вахтам (строка 8 - сумма)
        for (int shift = 0; shift < 4; shift++)
        {
            for (int fuel = 0; fuel < 7; fuel++)
            {
                report.FuelByShift[7, shift] += report.FuelByShift[fuel, shift];
                report.TotalStation[fuel] += report.FuelByShift[fuel, shift];
            }
            report.TotalStation[7] += report.FuelByShift[7, shift];

            // Удельный расход (строка 9)
            if (report.GenerationByShift[shift] > 0)
            {
                report.FuelByShift[8, shift] = (report.FuelByShift[7, shift] * 1000) / report.GenerationByShift[shift];
            }
            report.TotalStation[8] += report.FuelByShift[8, shift] / 4;

            report.TotalGeneration += report.GenerationByShift[shift];
        }

        // Расчет итогов по блокам (столбец 8 - сумма)
        for (int block = 0; block < 12; block++)
        {
            for (int fuel = 0; fuel < 7; fuel++)
            {
                report.FuelByBlock[block, 7] += report.FuelByBlock[block, fuel];
            }

            // Удельный расход (столбец 9)
            if (report.GenerationByBlock[block] > 0)
            {
                report.FuelByBlock[block, 8] = (report.FuelByBlock[block, 7] * 1000) / report.GenerationByBlock[block];
            }
        }

        // Средняя нагрузка по станции
        double totalLoad = 0;
        int loadCount = 0;
        for (int i = 0; i < 4; i++)
        {
            if (report.LoadByShift[i] > 0)
            {
                totalLoad += report.LoadByShift[i];
                loadCount++;
            }
        }
        report.AverageLoad = loadCount > 0 ? totalLoad / loadCount : 0;

        // Округление
        for (int i = 0; i < 12; i++)
        {
            report.LoadByBlock[i] = Math.Round(report.LoadByBlock[i], 0);
            report.GenerationByBlock[i] = Math.Round(report.GenerationByBlock[i], 0);
        }

        for (int i = 0; i < 4; i++)
        {
            report.LoadByShift[i] = Math.Round(report.LoadByShift[i], 0);
            report.GenerationByShift[i] = Math.Round(report.GenerationByShift[i], 0);
        }

        return report;
    }
}
