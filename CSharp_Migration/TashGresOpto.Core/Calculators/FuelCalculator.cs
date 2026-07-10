using System;

namespace TashGresOpto.Core.Calculators
{
    /// <summary>
    /// �������� ��室� ⮯���� �� ���⠬ (����஢���� ��楤��� SCHET)
    /// </summary>
    public class FuelCalculator
    {
        /// <summary>
        /// ����� 7 ��������⮢ ��������/��०��� ⮯����
        /// </summary>
        public FuelCalculationResult Calculate(FuelCalculationInput input)
        {
            var result = new FuelCalculationResult();

            // 1. ��� - ��யந�����⥫쭮��� 㣫����
            result.EKSUT1 = CalculateEKSUT1(input);

            // 2. ��� - �����
            result.EKSUT2 = CalculateEKSUT2(input);

            // 3. ��� - �������⥫쭠� �������� (�� ��������)
            result.EKSUT3 = CalculateEKSUT3(input);

            // 4. ��� - ��������� ���ண� ���
            result.EKSUT4 = CalculateEKSUT4(input);

            // 5. ��� - ��������� �஬��ॣॢ�
            result.EKSUT5 = CalculateEKSUT5(input);

            // 6. �� - ����⢥��� �㦤�
            result.EKSUT6 = CalculateEKSUT6(input);

            // 7. ��� - ��������� ���⥫쭮� ����
            result.EKSUT7 = CalculateEKSUT7(input);

            // �⮣�
            result.TotalEconomy = result.EKSUT1 + result.EKSUT2 + result.EKSUT3 +
                                  result.EKSUT4 + result.EKSUT5 + result.EKSUT6 + result.EKSUT7;

            // ������ ��室 �/����
            if (input.Wyrabotka > 0)
            {
                result.SpecificConsumption = result.TotalEconomy / input.Wyrabotka;
            }

            return result;
        }

        private double CalculateEKSUT1(FuelCalculationInput input)
        {
            // eksut1 = 3.5 * (rrf - rrn) * wy
            double rrn = 5.15 + 0.0083 * input.Nagruzka + 0.022 * (15.0 - input.THW);
            
            double rrf = 0;
            if (input.Nagruzka != 0)
            {
                rrf = input.Mpris * 0.01 * Math.Sqrt(160.0 / input.Nagruzka);
            }
            
            rrf = rrf + (21.0 - 0.1 * input.O2) / (21.0 - input.O2);
            rrf = (rrf * 3.5 + 0.6) * (input.TUG - input.THW) * 0.01;
            
            return 3.5 * (rrf - rrn) * input.Wyrabotka;
        }

        private double CalculateEKSUT2(FuelCalculationInput input)
        {
            // eksut2 = 0.68 * wy * (ntk - rr)
            double rr = input.MTCB + 0.07 * input.Nagruzka + 
                       (20 + input.Nagruzka) / (input.MTCB + 17);
            
            return 0.68 * input.Wyrabotka * (input.TK - rr);
        }

        private double CalculateEKSUT3(FuelCalculationInput input)
        {
            // �������⥫쭠� �������� �� ��������
            double eksut3 = 0.0;
            
            if (input.POP < 126.0)
            {
                if (input.Nagruzka >= 80.0 && input.Nagruzka <= 117.0)
                {
                    eksut3 = 0.148 * (input.Nagruzka - 80.0) * input.Wyrabotka;
                }
                
                if (input.Nagruzka > 117.0 && input.Nagruzka <= 160.0)
                {
                    eksut3 = 0.127 * (160.0 - input.Nagruzka) * input.Wyrabotka;
                }
            }
            
            return eksut3;
        }

        private double CalculateEKSUT4(FuelCalculationInput input)
        {
            // eksut4 = -0.07 * wy * (ntop - 540.0)
            return -0.07 * input.Wyrabotka * (input.TOP - 540.0);
        }

        private double CalculateEKSUT5(FuelCalculationInput input)
        {
            double eksut5 = 0;
            double rr = 540.0;
            
            if (input.Nagruzka > 80.0 && input.Nagruzka < 115.0)
            {
                rr = 530.0 + 0.429 * (input.Nagruzka - 80.0);
            }
            else if (input.Nagruzka >= 115.0)
            {
                rr = 540.0;
            }
            
            if (input.TPP < 540)
            {
                eksut5 = -0.056 * input.Wyrabotka * (input.TPP - rr);
            }
            
            return eksut5;
        }

        private double CalculateEKSUT6(FuelCalculationInput input)
        {
            // eksut6 = (esn - rr) * 350.0
            double rr = input.MKF1 * input.TIM + input.MKF2 * input.Wyrabotka;
            return (input.ESN - rr) * 350.0;
        }

        private double CalculateEKSUT7(FuelCalculationInput input)
        {
            double eksut7 = 0;
            
            if (input.PWD == 0)
            {
                eksut7 = (2.98 + 0.0276 * (input.Nagruzka - 80.0)) * input.Wyrabotka;
            }
            else
            {
                double rr = input.MKL2 + 0.3 * (input.Nagruzka - 150.0);
                
                if (input.Nagruzka < 150.0)
                {
                    rr = 170.0 + input.MKL1 * input.Nagruzka;
                }
                
                if (input.Nagruzka >= 160)
                {
                    rr = input.MKL2 + 3.0 + 0.2 * (input.Nagruzka - 150.0);
                }
                
                eksut7 = -0.066 * (input.TPW - rr + 0.05 * input.DRO) * input.Wyrabotka;
            }
            
            return eksut7;
        }
    }

    /// <summary>
    /// �室�� ����� ��� ���� ��室� ⮯����
    /// </summary>
    public class FuelCalculationInput
    {
        public double Nagruzka { get; set; }      // ����㧪�, ���
        public double Wyrabotka { get; set; }     // ��ࠡ�⪠, �����
        public double THW { get; set; }           // ��������� 宫������ ������
        public double TUG { get; set; }           // ��������� �室��� �����
        public double O2 { get; set; }            // ���業���� O2
        public double TK { get; set; }            // ��������� ��������
        public double POP { get; set; }           // �������� ���ண� ���
        public double TOP { get; set; }           // ��������� ���ண� ���
        public double TPP { get; set; }           // ��������� �஬��ॣॢ�
        public double TPW { get; set; }           // ��������� ���⥫쭮� ����
        public double DRO { get; set; }           // ���ᥫ�஢����
        public int PWD { get; set; }              // �ਧ��� ���
        public double TIM { get; set; }           // �६� ࠡ���
        public double ESN { get; set; }           // ���������ࣨ� ��
        
        // �����樥���
        public double Mpris { get; set; }
        public double MTCB { get; set; }
        public double MKF1 { get; set; }
        public double MKF2 { get; set; }
        public double MKL1 { get; set; }
        public double MKL2 { get; set; }
    }

    /// <summary>
    /// �������� ���� ��室� ⮯����
    /// </summary>
    public class FuelCalculationResult
    {
        public double EKSUT1 { get; set; }        // ���
        public double EKSUT2 { get; set; }        // ���
        public double EKSUT3 { get; set; }        // ���
        public double EKSUT4 { get; set; }        // ���
        public double EKSUT5 { get; set; }        // ���
        public double EKSUT6 { get; set; }        // ��
        public double EKSUT7 { get; set; }        // ���
        public double TotalEconomy { get; set; }  // �ᥣ� ��������/��०���
        public double SpecificConsumption { get; set; }  // ������ ��室 �/����
    }
}
