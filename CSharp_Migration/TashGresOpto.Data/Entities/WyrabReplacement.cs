using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TashGresOpto.Data.Entities
{
    /// <summary>
    /// Данные для замены счетчиков (WYRAB3.DBF)
    /// </summary>
    [Table("WyrabReplacement")]
    public class WyrabReplacement
    {
        [Key]
        public int Id { get; set; }
        
        /// <summary>
        /// Номер счетчика для замены
        /// </summary>
        public int CounterNumber { get; set; }
        
        /// <summary>
        /// Коэффициент нового счетчика
        /// </summary>
        public double NewCoefficient { get; set; }
        
        /// <summary>
        /// Начальное показание нового счетчика
        /// </summary>
        public double InitialReading { get; set; }
        
        /// <summary>
        /// Конечное показание старого счетчика
        /// </summary>
        public double OldFinalReading { get; set; }
        
        /// <summary>
        /// Энергия мимо счетчика
        /// </summary>
        public double EnergyBypass { get; set; }
        
        /// <summary>
        /// Заводской номер нового счетчика
        /// </summary>
        [MaxLength(50)]
        public string NewCounterSerialNumber { get; set; } = string.Empty;
        
        /// <summary>
        /// Конечное показание замененного счетчика
        /// </summary>
        public double ReplacedFinalReading { get; set; }
        
        /// <summary>
        /// Дата замены
        /// </summary>
        public DateTime ReplacementDate { get; set; }
        
        /// <summary>
        /// Обработан
        /// </summary>
        public bool IsProcessed { get; set; } = false;
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
