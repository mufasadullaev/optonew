using TashGresOpto.Core.Calculators;
using TashGresOpto.Data.Entities;
using TashGresOpto.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TashGresOpto.Core.Services
{
    /// <summary>
    /// ��ࢨ� ��� ࠡ��� � ���⠬� �� ���⠬
    /// </summary>
    public class BaxtaService
    {
        private readonly OptoDbContext _context;
        private readonly FuelCalculator _fuelCalculator;

        public BaxtaService(OptoDbContext context, FuelCalculator fuelCalculator)
        {
            _context = context;
            _fuelCalculator = fuelCalculator;
        }

        /// <summary>
        /// �믮����� ���� �� ����
        /// </summary>
        public async Task<Baxta> CalculateShift(int blockNumber, DateTime date, int smena, BaxtaParams parameters, double wyrabotka)
        {
            // ������� �����樥��� �����
            var coefficients = await GetBlockCoefficients(blockNumber);

            // �����⮢��� �室�� ����� ��� ����
            var input = new FuelCalculationInput
            {
                Nagruzka = parameters.THW,
                Wyrabotka = wyrabotka,
                THW = parameters.THW,
                TUG = parameters.TUG,
                O2 = parameters.O2,
                TK = parameters.TK,
                POP = parameters.POP,
                TOP = parameters.TOP,
                TPP = parameters.TPP,
                TPW = parameters.TPW,
                DRO = parameters.DRO,
                PWD = parameters.PWD,
                TIM = parameters.TIM,
                ESN = 0, // ������� �� wyrab
                Mpris = coefficients.Mpris,
                MTCB = coefficients.MTCB,
                MKF1 = coefficients.MKF1,
                MKF2 = coefficients.MKF2,
                MKL1 = coefficients.MKL1,
                MKL2 = coefficients.MKL2
            };

            // �믮����� ����
            var result = _fuelCalculator.Calculate(input);

            // ������� ������
            var baxta = new Baxta
            {
                NB = blockNumber,
                MMDD = date.Month * 100 + date.Day,
                Smena = smena,
                Nagr = input.Nagruzka,
                PUG = result.EKSUT1,
                WAK = result.EKSUT2,
                DOP = result.EKSUT3,
                TOP = result.EKSUT4,
                TPP = result.EKSUT5,
                SN = result.EKSUT6,
                TPW = result.EKSUT7,
                WSEGO = result.TotalEconomy,
                GKBT = result.SpecificConsumption
            };

            _context.Baxta.Add(baxta);
            await _context.SaveChangesAsync();

            return baxta;
        }

        /// <summary>
        /// ������� ����� �� ᬥ��
        /// </summary>
        public async Task<List<Baxta>> GetShiftData(DateTime date, int? blockNumber = null)
        {
            var query = _context.Baxta
                .Where(b => b.MMDD == date.Month * 100 + date.Day);

            if (blockNumber.HasValue)
            {
                query = query.Where(b => b.NB == blockNumber.Value);
            }

            return await query.OrderBy(b => b.NB).ThenBy(b => b.Smena).ToListAsync();
        }

        /// <summary>
        /// ������� �⮣� �� ��⪨
        /// </summary>
        public async Task<Dictionary<string, double>> GetDailySummary(DateTime date)
        {
            var data = await GetShiftData(date);

            return new Dictionary<string, double>
            {
                ["TotalPUG"] = data.Sum(b => b.PUG),
                ["TotalWAK"] = data.Sum(b => b.WAK),
                ["TotalDOP"] = data.Sum(b => b.DOP),
                ["TotalTOP"] = data.Sum(b => b.TOP),
                ["TotalTPP"] = data.Sum(b => b.TPP),
                ["TotalSN"] = data.Sum(b => b.SN),
                ["TotalTPW"] = data.Sum(b => b.TPW),
                ["TotalWSEGO"] = data.Sum(b => b.WSEGO),
                ["AvgGKBT"] = data.Any() ? data.Average(b => b.GKBT) : 0
            };
        }

        private async Task<BlockCoefficients> GetBlockCoefficients(int blockNumber)
        {
            // � ॠ�쭮� ��⥬� �� �㤥� �� ��
            // ���� �����頥� ���祭�� �� 㬮�砭��
            return new BlockCoefficients
            {
                Mpris = 2.5,
                MTCB = 30.0,
                MKF1 = 0.5,
                MKF2 = 0.01,
                MKL1 = 0.8,
                MKL2 = 100.0
            };
        }
    }

    internal class BlockCoefficients
    {
        public double Mpris { get; set; }
        public double MTCB { get; set; }
        public double MKF1 { get; set; }
        public double MKF2 { get; set; }
        public double MKL1 { get; set; }
        public double MKL2 { get; set; }
    }
}
