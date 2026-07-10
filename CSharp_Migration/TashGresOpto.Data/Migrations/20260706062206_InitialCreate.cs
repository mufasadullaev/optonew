using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TashGresOpto.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baxta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NZ = table.Column<int>(type: "INTEGER", nullable: false),
                    NB = table.Column<int>(type: "INTEGER", nullable: false),
                    MMDD = table.Column<int>(type: "INTEGER", nullable: false),
                    Smena = table.Column<int>(type: "INTEGER", nullable: false),
                    Nagr = table.Column<double>(type: "REAL", nullable: false),
                    PUG = table.Column<double>(type: "REAL", nullable: false),
                    WAK = table.Column<double>(type: "REAL", nullable: false),
                    DOP = table.Column<double>(type: "REAL", nullable: false),
                    TOP = table.Column<double>(type: "REAL", nullable: false),
                    TPP = table.Column<double>(type: "REAL", nullable: false),
                    SN = table.Column<double>(type: "REAL", nullable: false),
                    TPW = table.Column<double>(type: "REAL", nullable: false),
                    WSEGO = table.Column<double>(type: "REAL", nullable: false),
                    GKBT = table.Column<double>(type: "REAL", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baxta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaxtaCounter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlockNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    CounterNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CounterType = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Coefficient = table.Column<double>(type: "REAL", nullable: false),
                    ReadingStart = table.Column<double>(type: "REAL", nullable: false),
                    ReadingEnd = table.Column<double>(type: "REAL", nullable: false),
                    InstallDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaxtaCounter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaxtaParams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlockNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Smena = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    THW = table.Column<double>(type: "REAL", nullable: false),
                    TUG = table.Column<double>(type: "REAL", nullable: false),
                    O2 = table.Column<double>(type: "REAL", nullable: false),
                    TK = table.Column<double>(type: "REAL", nullable: false),
                    POP = table.Column<double>(type: "REAL", nullable: false),
                    TOP = table.Column<double>(type: "REAL", nullable: false),
                    TPP = table.Column<double>(type: "REAL", nullable: false),
                    TPW = table.Column<double>(type: "REAL", nullable: false),
                    DRO = table.Column<double>(type: "REAL", nullable: false),
                    PWD = table.Column<int>(type: "INTEGER", nullable: false),
                    TIM = table.Column<double>(type: "REAL", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaxtaParams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PereType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Coefficient = table.Column<double>(type: "REAL", nullable: false),
                    Unit = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Note = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PereType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Selektor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MechanismNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    MechanismName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Group = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    BlockNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    CounterNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ReadingStart = table.Column<double>(type: "REAL", nullable: false),
                    ReadingEnd = table.Column<double>(type: "REAL", nullable: false),
                    Consumption = table.Column<double>(type: "REAL", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Selektor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wyrab",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BlockNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    GeneratorCounterNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    GeneratorCoefficient = table.Column<double>(type: "REAL", nullable: false),
                    ReadingStart = table.Column<double>(type: "REAL", nullable: false),
                    ReadingEnd = table.Column<double>(type: "REAL", nullable: false),
                    Generation = table.Column<double>(type: "REAL", nullable: false),
                    Power = table.Column<double>(type: "REAL", nullable: false),
                    Hours = table.Column<double>(type: "REAL", nullable: false),
                    SNCounterNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SNCoefficient = table.Column<double>(type: "REAL", nullable: false),
                    SNReadingStart = table.Column<double>(type: "REAL", nullable: false),
                    SNReadingEnd = table.Column<double>(type: "REAL", nullable: false),
                    SN = table.Column<double>(type: "REAL", nullable: false),
                    SNPercent = table.Column<double>(type: "REAL", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wyrab", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WyrabCounter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MechanismType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    MechanismNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    MechanismName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    CounterNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Coefficient = table.Column<double>(type: "REAL", nullable: false),
                    ReadingStart = table.Column<double>(type: "REAL", nullable: false),
                    ReadingEnd = table.Column<double>(type: "REAL", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WyrabCounter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perejeg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BlockNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<double>(type: "REAL", nullable: false),
                    Hours = table.Column<double>(type: "REAL", nullable: false),
                    FuelConsumption = table.Column<double>(type: "REAL", nullable: false),
                    SpecificOverburn = table.Column<double>(type: "REAL", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perejeg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perejeg_PereType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "PereType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "PereType",
                columns: new[] { "Id", "Code", "Coefficient", "IsActive", "Name", "Note", "Unit" },
                values: new object[,]
                {
                    { 1, "RVV", 10.6, true, "ЋвЄ«озҐ­ЁҐ 1 ђ‚‚", "", "ЄЈ г.в./Њ‚въз" },
                    { 2, "CN", 7.0999999999999996, true, "ђ Ў®в  1 –Ќ", "", "ЄЈ г.в./Њ‚въз" },
                    { 3, "PVD", 6.0, true, "ЋвЄ«озҐ­ЁҐ ЈагЇЇл Џ‚„", "", "ЄЈ г.в./Њ‚въз" },
                    { 4, "SPD", 1.8999999999999999, true, "ђ Ў®в  ЎҐ§ ®Ў®Ёе ‘Џ„", "", "ЄЈ г.в./Њ‚въз" },
                    { 5, "OE", 0.69999999999999996, true, "‚Є«озҐ­ЁҐ ўв®а®Ј® Ћќ", "", "ЄЈ г.в./Њ‚въз" },
                    { 6, "ROU", 20.0, true, "ЏҐаҐў®¤ бҐв.Ї®¤®Ја. ­  ђЋ“", "", "ЄЈ г.в." },
                    { 7, "AVAR", 444.0, true, "ђ Ў®в   ў а. ўЇа.", "", "бЇҐжЁ «м­ п" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Baxta_MMDD_NB",
                table: "Baxta",
                columns: new[] { "MMDD", "NB" });

            migrationBuilder.CreateIndex(
                name: "IX_Perejeg_Date_BlockNumber",
                table: "Perejeg",
                columns: new[] { "Date", "BlockNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_Perejeg_TypeId",
                table: "Perejeg",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Selektor_Date_MechanismNumber",
                table: "Selektor",
                columns: new[] { "Date", "MechanismNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_Wyrab_Date_BlockNumber",
                table: "Wyrab",
                columns: new[] { "Date", "BlockNumber" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baxta");

            migrationBuilder.DropTable(
                name: "BaxtaCounter");

            migrationBuilder.DropTable(
                name: "BaxtaParams");

            migrationBuilder.DropTable(
                name: "Perejeg");

            migrationBuilder.DropTable(
                name: "Selektor");

            migrationBuilder.DropTable(
                name: "Wyrab");

            migrationBuilder.DropTable(
                name: "WyrabCounter");

            migrationBuilder.DropTable(
                name: "PereType");
        }
    }
}
