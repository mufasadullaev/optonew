using Microsoft.EntityFrameworkCore;
using TashGresOpto.Data.Entities;

namespace TashGresOpto.Data.Context
{
    public class OptoDbContext : DbContext
    {
        public OptoDbContext(DbContextOptions<OptoDbContext> options) : base(options)
        {
        }

        // Расчеты по вахтам
        public DbSet<Baxta> Baxta { get; set; }
        public DbSet<BaxtaCounter> BaxtaCounters { get; set; }
        public DbSet<BaxtaParams> BaxtaParams { get; set; }

        // Пережоги топлива
        public DbSet<Perejeg> Perejeg { get; set; }
        public DbSet<PerejegType> PerejegTypes { get; set; }

        // Выработка электроэнергии
        public DbSet<Wyrab> Wyrab { get; set; }
        public DbSet<WyrabCounter> WyrabCounters { get; set; }
        public DbSet<WyrabReplacement> WyrabReplacements { get; set; }
        public DbSet<WyrabReplacementHistory> WyrabReplacementHistory { get; set; }

        // Селектор
        public DbSet<Selektor> Selektor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Индексы для производительности
            modelBuilder.Entity<Baxta>()
                .HasIndex(b => new { b.MMDD, b.NB });

            modelBuilder.Entity<Wyrab>()
                .HasIndex(w => new { w.Date, w.BlockNumber });

            modelBuilder.Entity<WyrabReplacement>()
                .HasIndex(r => new { r.ReplacementDate, r.CounterNumber });

            modelBuilder.Entity<WyrabReplacementHistory>()
                .HasIndex(h => new { h.ReplacementDate, h.CounterNumber });

            modelBuilder.Entity<Perejeg>()
                .HasIndex(p => new { p.Nome, p.Nomer });

            modelBuilder.Entity<Selektor>()
                .HasIndex(s => new { s.Date, s.MechanismNumber });

            // Заполнение справочника типов показателей пережогов
            SeedPerejegTypes(modelBuilder);
        }

        private void SeedPerejegTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PerejegType>().HasData(
                new PerejegType { Id = 1, Nomer = 1, Name = "Отключение РВВ", Note = "" },
                new PerejegType { Id = 2, Nomer = 2, Name = "Снижение СН", Note = "" },
                new PerejegType { Id = 3, Nomer = 3, Name = "Отключение группы ПВД", Note = "" },
                new PerejegType { Id = 4, Nomer = 4, Name = "Снижение нагр. парообр.", Note = "" },
                new PerejegType { Id = 5, Nomer = 5, Name = "Отключение острого ОЕ", Note = "" },
                new PerejegType { Id = 6, Nomer = 6, Name = "Перевод дн.мельниц на уголь", Note = "" },
                new PerejegType { Id = 7, Nomer = 7, Name = "Снижение авар. рез.", Note = "" },
                new PerejegType { Id = 8, Nomer = 8, Name = "Сумма 1-7", Note = "" },
                new PerejegType { Id = 9, Nomer = 9, Name = "Отключение РВВ", Note = "" },
                new PerejegType { Id = 10, Nomer = 10, Name = "Снижение СН", Note = "" },
                new PerejegType { Id = 11, Nomer = 11, Name = "Отключение группы ПВД", Note = "" },
                new PerejegType { Id = 12, Nomer = 12, Name = "Снижение нагр. парообр.", Note = "" },
                new PerejegType { Id = 13, Nomer = 13, Name = "Отключение острого ОЕ", Note = "" },
                new PerejegType { Id = 14, Nomer = 14, Name = "Перевод дн.мельниц на уголь", Note = "" },
                new PerejegType { Id = 15, Nomer = 15, Name = "Снижение авар. рез.", Note = "" },
                new PerejegType { Id = 16, Nomer = 16, Name = "Сумма 9-15", Note = "" }
            );
        }
    }
}
