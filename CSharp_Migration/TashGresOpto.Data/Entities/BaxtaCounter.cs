using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TashGresOpto.Data.Entities
{
    /// <summary>
    /// ���稪� � �ਡ��� (BAXTA2.DBF)
    /// </summary>
    [Table("BaxtaCounter")]
    public class BaxtaCounter
    {
        [Key]
        public int Id { get; set; }
        
        /// <summary>
        /// ����� �����
        /// </summary>
        public int BlockNumber { get; set; }
        
        /// <summary>
        /// ����� ���稪�
        /// </summary>
        [MaxLength(50)]
        public string CounterNumber { get; set; }
        
        /// <summary>
        /// ��� ���稪�
        /// </summary>
        [MaxLength(100)]
        public string CounterType { get; set; }
        
        /// <summary>
        /// �����樥�� ���稪�
        /// </summary>
        public double Coefficient { get; set; }
        
        /// <summary>
        /// ��������� ��砫��
        /// </summary>
        public double ReadingStart { get; set; }
        
        /// <summary>
        /// ��������� ������
        /// </summary>
        public double ReadingEnd { get; set; }
        
        /// <summary>
        /// ��� ��⠭����
        /// </summary>
        public DateTime InstallDate { get; set; }
        
        /// <summary>
        /// ��⨢��
        /// </summary>
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
