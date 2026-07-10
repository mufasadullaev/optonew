using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TashGresOpto.Data.Entities
{
    /// <summary>
    /// ����� �� ���⠬ - �᭮���� ⠡��� (BAXTA1.DBF)
    /// </summary>
    [Table("Baxta")]
    public class Baxta
    {
        [Key]
        public int Id { get; set; }
        
        /// <summary>
        /// ����� �����
        /// </summary>
        public int NZ { get; set; }
        
        /// <summary>
        /// ����� ����� (1-12)
        /// </summary>
        public int NB { get; set; }
        
        /// <summary>
        /// ��� (����)
        /// </summary>
        public int MMDD { get; set; }
        
        /// <summary>
        /// ����� (1-3) + ���� (�, �, � = 1, 2, 3)
        /// </summary>
        public int Smena { get; set; }
        
        /// <summary>
        /// ����㧪�, ���
        /// </summary>
        public double Nagr { get; set; }
        
        /// <summary>
        /// ��யந�����⥫쭮��� 㣫���� (���), �� �.�.
        /// </summary>
        public double PUG { get; set; }
        
        /// <summary>
        /// ����� (���), �� �.�.
        /// </summary>
        public double WAK { get; set; }
        
        /// <summary>
        /// �������⥫쭠� �������� (���), �� �.�.
        /// </summary>
        public double DOP { get; set; }
        
        /// <summary>
        /// ��������� ���ண� ��� (���), �� �.�.
        /// </summary>
        public double TOP { get; set; }
        
        /// <summary>
        /// ��������� �஬��ॣॢ� ��� (���), �� �.�.
        /// </summary>
        public double TPP { get; set; }
        
        /// <summary>
        /// ����⢥��� �㦤� (��), �� �.�.
        /// </summary>
        public double SN { get; set; }
        
        /// <summary>
        /// ��������� ���⥫쭮� ���� (���), �� �.�.
        /// </summary>
        public double TPW { get; set; }
        
        /// <summary>
        /// �ᥣ� ��������/��०���, �� �.�.
        /// </summary>
        public double WSEGO { get; set; }
        
        /// <summary>
        /// ������ ��室, �/����
        /// </summary>
        public double GKBT { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
    }
}
