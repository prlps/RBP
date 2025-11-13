using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoRent.Data.Migrations
{
 public partial class InitCreate : Migration
 {
 protected override void Up(MigrationBuilder migrationBuilder)
 {
 migrationBuilder.CreateTable(
 name: "Cars",
 columns: table => new
 {
 CarId = table.Column<int>(type: "INTEGER", nullable: false)
 .Annotation("Sqlite:Autoincrement", true),
 Make = table.Column<string>(type: "TEXT", maxLength:100, nullable: false),
 Type = table.Column<string>(type: "TEXT", maxLength:50, nullable: false),
 PurchasePrice = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
 RentalPricePerDay = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
 IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false)
 },
 constraints: table =>
 {
 table.PrimaryKey("PK_Cars", x => x.CarId);
 });

 migrationBuilder.CreateTable(
 name: "Clients",
 columns: table => new
 {
 ClientId = table.Column<int>(type: "INTEGER", nullable: false)
 .Annotation("Sqlite:Autoincrement", true),
 LastName = table.Column<string>(type: "TEXT", maxLength:100, nullable: false),
 FirstName = table.Column<string>(type: "TEXT", maxLength:100, nullable: false),
 MiddleName = table.Column<string>(type: "TEXT", nullable: true),
 Address = table.Column<string>(type: "TEXT", nullable: false),
 Phone = table.Column<string>(type: "TEXT", maxLength:50, nullable: false)
 },
 constraints: table =>
 {
 table.PrimaryKey("PK_Clients", x => x.ClientId);
 });

 migrationBuilder.CreateTable(
 name: "Rentals",
 columns: table => new
 {
 RentalId = table.Column<int>(type: "INTEGER", nullable: false)
 .Annotation("Sqlite:Autoincrement", true),
 CarId = table.Column<int>(type: "INTEGER", nullable: false),
 ClientId = table.Column<int>(type: "INTEGER", nullable: false),
 DateOut = table.Column<DateTime>(type: "TEXT", nullable: false),
 PlannedReturnDate = table.Column<DateTime>(type: "TEXT", nullable: false),
 ActualReturnDate = table.Column<DateTime>(type: "TEXT", nullable: true),
 PricePerDay = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
 TotalPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
 Notes = table.Column<string>(type: "TEXT", nullable: true)
 },
 constraints: table =>
 {
 table.PrimaryKey("PK_Rentals", x => x.RentalId);
 table.ForeignKey(
 name: "FK_Rentals_Cars_CarId",
 column: x => x.CarId,
 principalTable: "Cars",
 principalColumn: "CarId",
 onDelete: ReferentialAction.Cascade);
 table.ForeignKey(
 name: "FK_Rentals_Clients_ClientId",
 column: x => x.ClientId,
 principalTable: "Clients",
 principalColumn: "ClientId",
 onDelete: ReferentialAction.Cascade);
 });

 migrationBuilder.CreateIndex(
 name: "IX_Rentals_CarId",
 table: "Rentals",
 column: "CarId");

 migrationBuilder.CreateIndex(
 name: "IX_Rentals_ClientId",
 table: "Rentals",
 column: "ClientId");
 }

 protected override void Down(MigrationBuilder migrationBuilder)
 {
 migrationBuilder.DropTable(name: "Rentals");
 migrationBuilder.DropTable(name: "Clients");
 migrationBuilder.DropTable(name: "Cars");
 }
 }
}
