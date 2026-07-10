using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TashGresOpto.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPerejegTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perejeg_PereType_TypeId",
                table: "Perejeg");

            migrationBuilder.DropTable(
                name: "PereType");

            migrationBuilder.DropIndex(
                name: "IX_Perejeg_Date_BlockNumber",
                table: "Perejeg");

            migrationBuilder.DropIndex(
                name: "IX_Perejeg_TypeId",
                table: "Perejeg");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Perejeg",
                newName: "Nomer");

            migrationBuilder.RenameColumn(
                name: "SpecificOverburn",
                table: "Perejeg",
                newName: "Sblok");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Perejeg",
                newName: "Blok9");

            migrationBuilder.RenameColumn(
                name: "Hours",
                table: "Perejeg",
                newName: "Blok8");

            migrationBuilder.RenameColumn(
                name: "FuelConsumption",
                table: "Perejeg",
                newName: "Blok7");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Perejeg",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BlockNumber",
                table: "Perejeg",
                newName: "Nome");

            migrationBuilder.AddColumn<double>(
                name: "Blok1",
                table: "Perejeg",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Blok10",
                table: "Perejeg",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Blok11",
                table: "Perejeg",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Blok12",
                table: "Perejeg",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Blok2",
                table: "Perejeg",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Blok3",
                table: "Perejeg",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Blok4",
                table: "Perejeg",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Blok5",
                table: "Perejeg",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Blok6",
                table: "Perejeg",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "PerejegTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nomer = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerejegTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PerejegTypes",
                columns: new[] { "Id", "CreatedDate", "Name", "Nomer", "Note" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4453), "Отключение РВВ", 1, "" },
                    { 2, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4468), "Снижение СН", 2, "" },
                    { 3, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4470), "Отключение группы ПВД", 3, "" },
                    { 4, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4471), "Снижение нагр. парообр.", 4, "" },
                    { 5, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4472), "Отключение острого ОЕ", 5, "" },
                    { 6, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4473), "Перевод дн.мельниц на уголь", 6, "" },
                    { 7, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4474), "Снижение авар. рез.", 7, "" },
                    { 8, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4475), "Сумма 1-7", 8, "" },
                    { 9, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4476), "Отключение РВВ", 9, "" },
                    { 10, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4477), "Снижение СН", 10, "" },
                    { 11, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4478), "Отключение группы ПВД", 11, "" },
                    { 12, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4479), "Снижение нагр. парообр.", 12, "" },
                    { 13, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4481), "Отключение острого ОЕ", 13, "" },
                    { 14, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4482), "Перевод дн.мельниц на уголь", 14, "" },
                    { 15, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4483), "Снижение авар. рез.", 15, "" },
                    { 16, new DateTime(2026, 7, 8, 13, 56, 36, 820, DateTimeKind.Local).AddTicks(4484), "Сумма 9-15", 16, "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Perejeg_Nome_Nomer",
                table: "Perejeg",
                columns: new[] { "Nome", "Nomer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerejegTypes");

            migrationBuilder.DropIndex(
                name: "IX_Perejeg_Nome_Nomer",
                table: "Perejeg");

            migrationBuilder.DropColumn(
                name: "Blok1",
                table: "Perejeg");

            migrationBuilder.DropColumn(
                name: "Blok10",
                table: "Perejeg");

            migrationBuilder.DropColumn(
                name: "Blok11",
                table: "Perejeg");

            migrationBuilder.DropColumn(
                name: "Blok12",
                table: "Perejeg");

            migrationBuilder.DropColumn(
                name: "Blok2",
                table: "Perejeg");

            migrationBuilder.DropColumn(
                name: "Blok3",
                table: "Perejeg");

            migrationBuilder.DropColumn(
                name: "Blok4",
                table: "Perejeg");

            migrationBuilder.DropColumn(
                name: "Blok5",
                table: "Perejeg");

            migrationBuilder.DropColumn(
                name: "Blok6",
                table: "Perejeg");

            migrationBuilder.RenameColumn(
                name: "Sblok",
                table: "Perejeg",
                newName: "SpecificOverburn");

            migrationBuilder.RenameColumn(
                name: "Nomer",
                table: "Perejeg",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Perejeg",
                newName: "BlockNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Perejeg",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "Blok9",
                table: "Perejeg",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "Blok8",
                table: "Perejeg",
                newName: "Hours");

            migrationBuilder.RenameColumn(
                name: "Blok7",
                table: "Perejeg",
                newName: "FuelConsumption");

            migrationBuilder.CreateTable(
                name: "PereType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Coefficient = table.Column<double>(type: "REAL", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Note = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Unit = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PereType", x => x.Id);
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
                name: "IX_Perejeg_Date_BlockNumber",
                table: "Perejeg",
                columns: new[] { "Date", "BlockNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_Perejeg_TypeId",
                table: "Perejeg",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perejeg_PereType_TypeId",
                table: "Perejeg",
                column: "TypeId",
                principalTable: "PereType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
