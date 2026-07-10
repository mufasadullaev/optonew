using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TashGresOpto.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddWyrabReplacementTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WyrabReplacement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CounterNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    NewCoefficient = table.Column<double>(type: "REAL", nullable: false),
                    InitialReading = table.Column<double>(type: "REAL", nullable: false),
                    OldFinalReading = table.Column<double>(type: "REAL", nullable: false),
                    EnergyBypass = table.Column<double>(type: "REAL", nullable: false),
                    NewCounterSerialNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ReplacedFinalReading = table.Column<double>(type: "REAL", nullable: false),
                    ReplacementDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsProcessed = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WyrabReplacement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WyrabReplacementHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CounterNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    OldCoefficient = table.Column<double>(type: "REAL", nullable: false),
                    OldBypassReading = table.Column<double>(type: "REAL", nullable: false),
                    FinalReading = table.Column<double>(type: "REAL", nullable: false),
                    EnergyBypass = table.Column<double>(type: "REAL", nullable: false),
                    OldSerialNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ReplacementDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WyrabReplacementHistory", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 10, 9, 48, 6, 795, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.CreateIndex(
                name: "IX_WyrabReplacement_ReplacementDate_CounterNumber",
                table: "WyrabReplacement",
                columns: new[] { "ReplacementDate", "CounterNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_WyrabReplacementHistory_ReplacementDate_CounterNumber",
                table: "WyrabReplacementHistory",
                columns: new[] { "ReplacementDate", "CounterNumber" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WyrabReplacement");

            migrationBuilder.DropTable(
                name: "WyrabReplacementHistory");

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "PerejegTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4484));
        }
    }
}
