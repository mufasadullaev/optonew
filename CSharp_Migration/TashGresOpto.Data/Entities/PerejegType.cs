namespace TashGresOpto.Data.Entities;

public class PerejegType
{
    public int Id { get; set; }
    
    // Номер типа (1-16)
    public int Nomer { get; set; }
    
    // Название показателя
    public string Name { get; set; } = string.Empty;
    
    // Примечание
    public string Note { get; set; } = string.Empty;
    
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
