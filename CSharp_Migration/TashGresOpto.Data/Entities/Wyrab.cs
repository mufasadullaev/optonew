using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TashGresOpto.Data.Entities
{
    /// <summary>
    /// ��ࠡ�⪠ ���������ࣨ� (WYRAB1.DBF)
    /// </summary>
    [Table("Wyrab")]
    public class Wyrab
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime Date { get; set; }
        public int BlockNumber { get; set; }
        
        /// <summary>
        /// ����� ���稪� �������
        /// </summary>
        [MaxLength(50)]
        public string GeneratorCounterNumber { get; set; }
        
        /// <summary>
        /// �����樥�� ���稪� �������
        /// </summary>
        public double GeneratorCoefficient { get; set; }
        
        /// <summary>
        /// ��������� ��砫�� (��)
        /// </summary>
        public double ReadingStart { get; set; }
        
        /// <summary>
        /// ��������� ������ (��)
        /// </summary>
        public double ReadingEnd { get; set; }
        
        /// <summary>
        /// ��ࠡ�⪠, ���. ����
        /// </summary>
        public double Generation { get; set; }
        
        /// <summary>
        /// ��魮���, ���
        /// </summary>
        public double Power { get; set; }
        
        /// <summary>
        /// �६� ࠡ���, ���
        /// </summary>
        public double Hours { get; set; }
        
        /// <summary>
        /// ����� ���稪� ��
        /// </summary>
        [MaxLength(50)]
        public string SNCounterNumber { get; set; }
        
        /// <summary>
        /// �����樥�� ���稪� ��
        /// </summary>
        public double SNCoefficient { get; set; }
        
        /// <summary>
        /// ��������� �� ��砫��
        /// </summary>
        public double SNReadingStart { get; set; }
        
        /// <summary>
        /// ��������� �� ������
        /// </summary>
        public double SNReadingEnd { get; set; }
        
        /// <summary>
        /// ��, ���. ����
        /// </summary>
        public double SN { get; set; }
        
        /// <summary>
        /// ��, %
        /// </summary>
        public double SNPercent { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
    }
}
