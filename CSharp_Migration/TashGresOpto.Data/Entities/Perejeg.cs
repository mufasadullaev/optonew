namespace TashGresOpto.Data.Entities;

public class Perejeg
{
    public int Id { get; set; }
    
    // Дата в формате ГГММДД (например, 260708 = 08.07.2026)
    public int Nome { get; set; }
    
    // Номер строки (1-16)
    public int Nomer { get; set; }
    
    // Название показателя
    public string Name { get; set; } = string.Empty;
    
    // Значения по блокам (12 блоков)
    public double Blok1 { get; set; }
    public double Blok2 { get; set; }
    public double Blok3 { get; set; }
    public double Blok4 { get; set; }
    public double Blok5 { get; set; }
    public double Blok6 { get; set; }
    public double Blok7 { get; set; }
    public double Blok8 { get; set; }
    public double Blok9 { get; set; }
    public double Blok10 { get; set; }
    public double Blok11 { get; set; }
    public double Blok12 { get; set; }
    
    // Сумма по блокам
    public double Sblok { get; set; }
    
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
