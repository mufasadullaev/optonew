using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TashGresOpto.Data.Entities
{
    /// <summary>
    /// ������� - ��堭���� �⠭樨 (SEL1.DBF)
    /// </summary>
    [Table("Selektor")]
    public class Selektor
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime Date { get; set; }
        
        /// <summary>
        /// ����� ��堭���� (1-144)
        /// </summary>
        public int MechanismNumber { get; set; }
        
        /// <summary>
        /// �������� ��堭����
        /// </summary>
        [MaxLength(200)]
        public string MechanismName { get; set; }
        
        /// <summary>
        /// ��㯯� ��堭���� (�, �)
        /// </summary>
        [MaxLength(10)]
        public string Group { get; set; }
        
        /// <summary>
        /// ����� ����� (1-12 ��� 0 ��� ����⠭樮����)
        /// </summary>
        public int BlockNumber { get; set; }
        
        /// <summary>
        /// ����� ���稪�
        /// </summary>
        [MaxLength(50)]
        public string CounterNumber { get; set; }
        
        /// <summary>
        /// ��������� ��砫�� (���)
        /// </summary>
        public double ReadingStart { get; set; }
        
        /// <summary>
        /// ��������� ������ (���)
        /// </summary>
        public double ReadingEnd { get; set; }
        
        /// <summary>
        /// ���ॡ�����, ���. ����
        /// </summary>
        public double Consumption { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
    }
}
