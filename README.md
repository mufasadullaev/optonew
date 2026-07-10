# TashGresOpto - Power Plant Operations System

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![Platform](https://img.shields.io/badge/platform-Windows-0078D4)](https://www.microsoft.com/windows)

Modern C# .NET migration of the legacy DOS-based KARAT/M power plant operations system for TashGRES (Tashkent Power Plant).

## 📋 Overview

TashGresOpto is a comprehensive system for operational accounting and calculation of technical-economic indicators for thermal power plants. This project represents a complete migration from the legacy DOS application (KARAT/M) to a modern .NET platform while preserving 100% of the original formulas and calculations.

## ✨ Features

### Implemented Modules

- **BAXTA** - Daily shift calculations
  - 7-component fuel economy calculations (ЭКСУТ1-7)
  - Technological parameter tracking
  - Shift schedule management
  - Real-time validation

- **PEREJEG** - Fuel burn tracking
  - 16 indicators across 12 power blocks
  - Daily and cumulative reports
  - Historical data tracking

- **WYRABOTKA** - Power generation calculations
  - Counter readings management
  - Generation calculations with coefficients
  - Auxiliary power consumption (СН)
  - Counter replacement support

- **O2GOL** - Consolidated shift reports
  - Period-based aggregation
  - Block-wise and shift-wise analysis
  - Specific fuel consumption calculations
  - Statistical summaries

## 🏗️ Architecture

```
TashGresOpto/
├── TashGresOpto.UI/          # Windows Forms user interface
├── TashGresOpto.Core/        # Business logic & calculations
├── TashGresOpto.Data/        # Data access layer (EF Core)
└── TashGresOpto.Reports/     # Report generation
```

### Technology Stack

- **Framework:** .NET 8.0, C# 12
- **UI:** Windows Forms with modern styling
- **Database:** SQLite with Entity Framework Core 8.0
- **Architecture:** Layered architecture with Dependency Injection
- **Patterns:** Repository Pattern, MVVM-like separation

## 📊 Key Calculations

### Fuel Economy Components (ЭКСУТ)

1. **ЭКСУТ1** - Exhaust gas losses (air infiltration & O₂)
2. **ЭКСУТ2** - Chemical incomplete combustion losses
3. **ЭКСУТ3** - Additional load-related savings
4. **ЭКСУТ4** - Main steam temperature losses
5. **ЭКСУТ5** - Reheat temperature losses
6. **ЭКСУТ6** - Auxiliary power consumption losses
7. **ЭКСУТ7** - Feedwater temperature losses

**Formula Example (ЭКСУТ1):**
```
ЭКСУТ1 = 3.5 × (RRF - RRN) × WY

where:
  RRN = 5.15 + 0.0083 × N + 0.022 × (15 - THW)
  RRF = calculated based on air infiltration and O₂ content
  WY = power generation (MWh)
```

## 🚀 Getting Started

### Prerequisites

- Windows 10/11
- .NET 8.0 Runtime or SDK
- 100 MB free disk space
- Minimum 1400×900 screen resolution

### Installation

1. Clone the repository:
```bash
git clone https://github.com/mufasadullaev/optonew.git
cd optonew/CSharp_Migration
```

2. Restore NuGet packages:
```bash
dotnet restore
```

3. Build the solution:
```bash
dotnet build
```

4. Run the application:
```bash
cd TashGresOpto.UI
dotnet run
```

### Database Setup

The database is created automatically on first run using EF Core migrations. No manual setup required.

## 📖 Documentation

Comprehensive documentation is available in the `/CSharp_Migration/DOCUMENTATION.md` file (150+ pages), including:

- All formulas with mathematical derivations
- Parameter descriptions and valid ranges
- Step-by-step user guides
- Database schema
- API documentation
- Troubleshooting guide

## 🔧 Configuration

### Validation Ranges

| Parameter | Min | Max | Typical | Description |
|-----------|-----|-----|---------|-------------|
| THW (°C) | 0 | 50 | 15-25 | Cold water temperature |
| TUG (°C) | 50 | 300 | 120-180 | Exhaust gas temperature |
| O2 (%) | 0 | 21 | 3-7 | Oxygen content |
| POP (kgf/cm²) | 50 | 200 | 90-130 | Main steam pressure |
| TOP (°C) | 400 | 600 | 535-545 | Main steam temperature |

See full parameter list in documentation.

## 🗄️ Database Schema

### Key Tables

- **BaxtaParams** - Technological parameters by shift
- **BaxtaCounter** - Counter and instrument data
- **Perejeg** - Fuel burn data (16 indicators × 12 blocks)
- **Wyrab** - Power generation data
- **WyrabCounter** - Generation meter registry

## 🎯 Roadmap

### Completed ✅
- [x] Core calculation modules (BAXTA, PEREJEG, WYRABOTKA, O2GOL)
- [x] Input validation
- [x] Single-window UI navigation
- [x] Comprehensive documentation

### In Progress 🚧
- [ ] Counter replacement functionality in WYRABOTKA
- [ ] PDF/Excel report generation
- [ ] Data editing and deletion
- [ ] AKT module (Acts)
- [ ] SELEKTOR module (Mechanism selector)

## 📝 Usage Example

### Daily Workflow

1. **Morning (shift start):**
   - Record initial counter readings (WYRABOTKA)
   - Note technological parameters

2. **Evening (shift end):**
   - Enter final counter readings
   - Calculate generation
   - Input parameters and run BAXTA calculations
   - Enter burn data (PEREJEG)

3. **Weekly (Monday):**
   - Generate O2GOL consolidated report
   - Analyze results
   - Identify deviations

## 🤝 Contributing

Contributions are welcome! Please:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- Original KARAT/M system developers (1990-2005)
- TashGRES operational staff for domain knowledge
- Cursor AI for development assistance

## 📞 Contact

Project Link: [https://github.com/mufasadullaev/optonew](https://github.com/mufasadullaev/optonew)

## 📊 Project Status

**Status:** ✅ Production Ready (Core modules)

**Version:** 1.0.0

**Last Updated:** July 2026

---

Made with ❤️ for TashGRES Power Plant
