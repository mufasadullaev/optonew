using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TashGresOpto.Data.Entities
{
    /// <summary>
    /// Архив замененных счетчиков (WYRAB33.DBF)
    /// </summary>
    [Table("WyrabReplacementHistory")]
    public class WyrabReplacementHistory
    {
        [Key]
        public int Id { get; set; }
        
        /// <summary>
        /// Номер счетчика
        /// </summary>
        public int CounterNumber { get; set; }
        
        /// <summary>
        /// Старый коэффициент
        /// </summary>
        public double OldCoefficient { get; set; }
        
        /// <summary>
        /// Старое показание "мимо"
        /// </summary>
        public double OldBypassReading { get; set; }
        
        /// <summary>
        /// Конечное показание при замене
        /// </summary>
        public double FinalReading { get; set; }
        
        /// <summary>
        /// Энергия мимо счетчика
        /// </summary>
        public double EnergyBypass { get; set; }
        
        /// <summary>
        /// Старый заводской номер счетчика
        /// </summary>
        [MaxLength(50)]
        public string OldSerialNumber { get; set; } = string.Empty;
        
        /// <summary>
        /// Дата замены
        /// </summary>
        public DateTime ReplacementDate { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
