using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TashGresOpto.Data.Entities
{
    /// <summary>
    /// �����樥��� ���稪�� (WYRAB2.DBF)
    /// </summary>
    [Table("WyrabCounter")]
    public class WyrabCounter
    {
        [Key]
        public int Id { get; set; }
        
        /// <summary>
        /// ��� ��堭���� (����, �࠭��ଠ��, ����⠭樮���)
        /// </summary>
        [MaxLength(50)]
        public string MechanismType { get; set; }
        
        /// <summary>
        /// ����� ��堭����
        /// </summary>
        public int MechanismNumber { get; set; }
        
        /// <summary>
        /// �������� ��堭����
        /// </summary>
        [MaxLength(200)]
        public string MechanismName { get; set; }
        
        /// <summary>
        /// ����� ���稪�
        /// </summary>
        [MaxLength(50)]
        public string CounterNumber { get; set; }
        
        /// <summary>
        /// �����樥�� ���稪� (���)
        /// </summary>
        public double Coefficient { get; set; }
        
        /// <summary>
        /// ��������� ��砫�� (���)
        /// </summary>
        public double ReadingStart { get; set; }
        
        /// <summary>
        /// ��������� ������ (���)
        /// </summary>
        public double ReadingEnd { get; set; }
        
        /// <summary>
        /// ��⨢��
        /// </summary>
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
    }
}
