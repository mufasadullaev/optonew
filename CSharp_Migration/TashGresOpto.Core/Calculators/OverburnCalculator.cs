using System;
using System.Collections.Generic;
using System.Linq;

namespace TashGresOpto.Core.Calculators
{
    /// <summary>
    /// �������� ��०���� ⮯���� (����஢���� ��楤��� PERERAS)
    /// </summary>
    public class OverburnCalculator
    {
        /// <summary>
        /// ����� ��०���� ⮯���� �� �ᥬ ⨯�� �⪫������
        /// </summary>
        public OverburnCalculationResult Calculate(OverburnCalculationInput input)
        {
            var result = new OverburnCalculationResult();
            result.BlockResults = new List<BlockOverburnResult>();

            for (int block = 1; block <= 12; block++)
            {
                var blockResult = CalculateBlockOverburn(input, block);
                result.BlockResults.Add(blockResult);
                
                result.TotalOverburn += blockResult.TotalOverburn;
            }

            // ����� 㤥�쭮�� ��०��� �/����
            if (input.TotalGeneration > 0)
            {
                result.SpecificOverburn = result.TotalOverburn / input.TotalGeneration / 1000.0;
            }

            return result;
        }

        private BlockOverburnResult CalculateBlockOverburn(OverburnCalculationInput input, int blockNumber)
        {
            var result = new BlockOverburnResult { BlockNumber = blockNumber };
            var deviations = input.Deviations.Where(d => d.BlockNumber == blockNumber).ToList();

            foreach (var deviation in deviations)
            {
                double overburn = 0;

                switch (deviation.TypeCode)
                {
                    case "RVV":
                        // a1 = 10.6 * ni * ti
                        overburn = 10.6 * deviation.Quantity * deviation.Hours;
                        result.RVV = overburn;
                        break;

                    case "CN":
                        // b1 = 7.1 * ni * ti
                        overburn = 7.1 * deviation.Quantity * deviation.Hours;
                        result.CN = overburn;
                        break;

                    case "PVD":
                        // c1 = 6.0 * ni * ti
                        overburn = 6.0 * deviation.Quantity * deviation.Hours;
                        result.PVD = overburn;
                        break;

                    case "SPD":
                        // d1 = 1.9 * ni * ti
                        overburn = 1.9 * deviation.Quantity * deviation.Hours;
                        result.SPD = overburn;
                        break;

                    case "OE":
                        // e1 = 0.7 * ni * ti
                        overburn = 0.7 * deviation.Quantity * deviation.Hours;
                        result.OE = overburn;
                        break;

                    case "ROU":
                        // fff0 = 20.0 * ni * ti (��� �⠭樨)
                        overburn = 20.0 * deviation.Quantity * deviation.Hours;
                        result.ROU = overburn;
                        break;

                    case "AVAR":
                        // g1 = 444.0 * ni * ti * dt / 10000
                        overburn = 444.0 * deviation.Quantity * deviation.Hours * deviation.Load / 10000.0;
                        result.AVAR = overburn;
                        break;
                }

                result.TotalOverburn += overburn;
            }

            return result;
        }
    }

    /// <summary>
    /// �室�� ����� ��� ���� ��०����
    /// </summary>
    public class OverburnCalculationInput
    {
        public DateTime Date { get; set; }
        public double TotalGeneration { get; set; }  // �㬬�ୠ� ��ࠡ�⪠ �� ��⪨, �����
        public List<DeviationData> Deviations { get; set; } = new List<DeviationData>();
    }

    /// <summary>
    /// ����� �� �⪫������
    /// </summary>
    public class DeviationData
    {
        public int BlockNumber { get; set; }
        public string TypeCode { get; set; }  // RVV, CN, PVD, SPD, OE, ROU, AVAR
        public double Quantity { get; set; }  // ������⢮ (ni)
        public double Hours { get; set; }     // �६� ࠡ��� (ti)
        public double Load { get; set; }      // ����㧪� ����� (��� AVAR)
    }

    /// <summary>
    /// �������� ���� ��०����
    /// </summary>
    public class OverburnCalculationResult
    {
        public List<BlockOverburnResult> BlockResults { get; set; }
        public double TotalOverburn { get; set; }       // �ᥣ� ��०��, �� �.�.
        public double SpecificOverburn { get; set; }    // ������ ��०��, �/����
    }

    /// <summary>
    /// �������� �� �����
    /// </summary>
    public class BlockOverburnResult
    {
        public int BlockNumber { get; set; }
        public double RVV { get; set; }      // �⪫�祭�� ���
        public double CN { get; set; }       // ����� ��
        public double PVD { get; set; }      // �⪫�祭�� ���
        public double SPD { get; set; }      // ��� ���
        public double OE { get; set; }       // ��ன ��
        public double ROU { get; set; }      // ���
        public double AVAR { get; set; }     // ���਩�� �����
        public double TotalOverburn { get; set; }
    }
}
