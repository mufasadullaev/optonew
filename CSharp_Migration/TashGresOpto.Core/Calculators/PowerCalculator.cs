using System;

namespace TashGresOpto.Core.Calculators
{
    /// <summary>
    /// �������� ��ࠡ�⪨ ���������ࣨ� (����஢���� ��楤��� RASCH)
    /// </summary>
    public class PowerCalculator
    {
        /// <summary>
        /// ����� ��ࠡ�⪨ � ᮡ�⢥���� �㦤
        /// </summary>
        public PowerCalculationResult Calculate(PowerCalculationInput input)
        {
            var result = new PowerCalculationResult();

            // ����� ��ࠡ�⪨ �������
            double difference = input.ReadingEnd - input.ReadingStart;
            
            // ��� ��९������� ���稪�
            if (difference < 0)
            {
                difference += 100000; // 10e5
            }

            // ��ࠡ�⪠ = �����樥�� * ࠧ����� * 0.001
            result.Generation = input.Coefficient * difference * 0.001;

            // ��� ������ ���稪�
            if (input.HasCounterReplacement && input.ReplacementData != null)
            {
                double replacementDiff = input.ReplacementData.ReadingEnd - input.ReplacementData.ReadingStart;
                if (replacementDiff < 0)
                {
                    replacementDiff += 100000;
                }
                
                double replacementGeneration = input.ReplacementData.Coefficient * replacementDiff * 0.001;
                result.Generation += replacementGeneration;
            }

            // ����� ��魮�� (���)
            if (input.Hours > 0)
            {
                result.Power = result.Generation / input.Hours;
            }

            // ����� ᮡ�⢥���� �㦤
            double snDifference = input.SNReadingEnd - input.SNReadingStart;
            
            // ��� ��९������� ���稪� ��
            if (snDifference < 0)
            {
                snDifference += 10000; // 10e4
            }

            result.SN = input.SNCoefficient * snDifference * 0.001;

            // ��� ������ ���稪� ��
            if (input.HasSNCounterReplacement && input.SNReplacementData != null)
            {
                double snReplacementDiff = input.SNReplacementData.ReadingEnd - input.SNReplacementData.ReadingStart;
                if (snReplacementDiff < 0)
                {
                    snReplacementDiff += 10000;
                }
                
                double snReplacementConsumption = input.SNReplacementData.Coefficient * snReplacementDiff * 0.001;
                result.SN += snReplacementConsumption;
            }

            // ����� ��業� ��
            if (result.Generation > 0)
            {
                result.SNPercent = (result.SN / result.Generation) * 100.0;
            }

            return result;
        }
    }

    /// <summary>
    /// �室�� ����� ��� ���� ��ࠡ�⪨
    /// </summary>
    public class PowerCalculationInput
    {
        // �������
        public double Coefficient { get; set; }
        public double ReadingStart { get; set; }
        public double ReadingEnd { get; set; }
        public double Hours { get; set; }

        // ������ ���稪� �������
        public bool HasCounterReplacement { get; set; }
        public CounterReplacementData ReplacementData { get; set; }

        // ����⢥��� �㦤�
        public double SNCoefficient { get; set; }
        public double SNReadingStart { get; set; }
        public double SNReadingEnd { get; set; }

        // ������ ���稪� ��
        public bool HasSNCounterReplacement { get; set; }
        public CounterReplacementData SNReplacementData { get; set; }
    }

    /// <summary>
    /// ����� � ������ ���稪�
    /// </summary>
    public class CounterReplacementData
    {
        public double Coefficient { get; set; }
        public double ReadingStart { get; set; }
        public double ReadingEnd { get; set; }
        public double AdditionalValue { get; set; }  // li4
    }

    /// <summary>
    /// �������� ���� ��ࠡ�⪨
    /// </summary>
    public class PowerCalculationResult
    {
        public double Generation { get; set; }     // ��ࠡ�⪠, ���. �����
        public double Power { get; set; }          // ��魮���, ���
        public double SN { get; set; }             // ����⢥��� �㦤�, ���. �����
        public double SNPercent { get; set; }      // ��, %
    }
}
