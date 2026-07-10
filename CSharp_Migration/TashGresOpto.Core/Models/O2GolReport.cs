namespace TashGresOpto.Core.Models;

/// <summary>
/// Сводные данные по расходу топлива за период
/// </summary>
public class O2GolReport
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    /// <summary>
    /// Расход топлива по вахтам [9 показателей x 4 вахты]
    /// </summary>
    public double[,] FuelByShift { get; set; } = new double[9, 4];
    
    /// <summary>
    /// Расход топлива по блокам [12 блоков x 9 показателей]
    /// </summary>
    public double[,] FuelByBlock { get; set; } = new double[12, 9];
    
    /// <summary>
    /// Выработка по вахтам
    /// </summary>
    public double[] GenerationByShift { get; set; } = new double[4];
    
    /// <summary>
    /// Выработка по блокам
    /// </summary>
    public double[] GenerationByBlock { get; set; } = new double[12];
    
    /// <summary>
    /// Средняя нагрузка по вахтам
    /// </summary>
    public double[] LoadByShift { get; set; } = new double[4];
    
    /// <summary>
    /// Средняя нагрузка по блокам
    /// </summary>
    public double[] LoadByBlock { get; set; } = new double[12];
    
    /// <summary>
    /// Количество записей по блокам
    /// </summary>
    public int[] CountByBlock { get; set; } = new int[12];
    
    /// <summary>
    /// Количество записей по вахтам
    /// </summary>
    public int[] CountByShift { get; set; } = new int[4];
    
    /// <summary>
    /// Общие итоги по станции
    /// </summary>
    public double[] TotalStation { get; set; } = new double[9];
    
    /// <summary>
    /// Общая выработка по станции
    /// </summary>
    public double TotalGeneration { get; set; }
    
    /// <summary>
    /// Средняя нагрузка по станции
    /// </summary>
    public double AverageLoad { get; set; }
}
