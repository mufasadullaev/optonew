using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TashGresOpto.Data.Entities
{
    /// <summary>
    /// ��ࠢ�筨� ⨯�� �⪫������ (PERE4.DBF)
    /// </summary>
    [Table("PereType")]
    public class PereType
    {
        [Key]
        public int Id { get; set; }
        
        /// <summary>
        /// ��� ⨯� �⪫������
        /// </summary>
        [MaxLength(10)]
        public string Code { get; set; }
        
        /// <summary>
        /// �������� ⨯� �⪫������
        /// </summary>
        [MaxLength(200)]
        public string Name { get; set; }
        
        /// <summary>
        /// �����樥�� ��室� ⮯����
        /// </summary>
        public double Coefficient { get; set; }
        
        /// <summary>
        /// ������ ����७��
        /// </summary>
        [MaxLength(50)]
        public string Unit { get; set; }
        
        /// <summary>
        /// ��⨢��
        /// </summary>
        public bool IsActive { get; set; } = true;
        
        /// <summary>
        /// �ਬ�砭��
        /// </summary>
        [MaxLength(500)]
        public string Note { get; set; }
    }
}
