using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TashGresOpto.Data.Entities
{
    /// <summary>
    /// ��孮�����᪨� ��ࠬ���� (BAXTA3.DBF)
    /// </summary>
    [Table("BaxtaParams")]
    public class BaxtaParams
    {
        [Key]
        public int Id { get; set; }
        
        public int BlockNumber { get; set; }
        public int Smena { get; set; }
        public DateTime Date { get; set; }
        
        /// <summary>
        /// ��������� 宫������ ������
        /// </summary>
        public double THW { get; set; }
        
        /// <summary>
        /// ��������� �室��� �����
        /// </summary>
        public double TUG { get; set; }
        
        /// <summary>
        /// ���業���� O2
        /// </summary>
        public double O2 { get; set; }
        
        /// <summary>
        /// ��������� 宫������ ���
        /// </summary>
        public double TK { get; set; }
        
        /// <summary>
        /// �������� ���ண� ���
        /// </summary>
        public double POP { get; set; }
        
        /// <summary>
        /// ��������� ���ண� ��� (���)
        /// </summary>
        public double TOP { get; set; }
        
        /// <summary>
        /// ��������� �஬��ॣॢ� (���)
        /// </summary>
        public double TPP { get; set; }
        
        /// <summary>
        /// ��������� ���⥫쭮� ���� (���)
        /// </summary>
        public double TPW { get; set; }
        
        /// <summary>
        /// ���ᥫ�஢����
        /// </summary>
        public double DRO { get; set; }
        
        /// <summary>
        /// �ਧ��� ��� (0 - �⪫�祭�, 1 - ����祭�)
        /// </summary>
        public int PWD { get; set; }
        
        /// <summary>
        /// �६� ࠡ��� �����, ���
        /// </summary>
        public double TIM { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
