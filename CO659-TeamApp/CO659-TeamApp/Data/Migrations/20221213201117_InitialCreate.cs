using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CO659_TeamApp.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountEmail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AccountPassword = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AccountLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MedicineType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MedicineDosage = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    MedicineQty = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SymptomName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SymptomType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SymptomDetails = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SymptomSeverity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Practitioners",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PractitionerFName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PractitionerLName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PractitionerTitle = table.Column<int>(type: "int", nullable: true),
                    PractitionerDept = table.Column<int>(type: "int", nullable: true),
                    AccountID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practitioners", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Practitioners_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientFName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PatientLName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PatientDOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressHouseNo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    AddressStreet = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AddressLineTwo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AddressTownCity = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AddressPostcode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: true),
                    PractitionerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Patients_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Patients_Practitioners_PractitionerID",
                        column: x => x.PractitionerID,
                        principalTable: "Practitioners",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApptDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApptLength = table.Column<int>(type: "int", nullable: false),
                    PatientID = table.Column<int>(type: "int", nullable: true),
                    PractitionerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Appointments_Practitioners_PractitionerID",
                        column: x => x.PractitionerID,
                        principalTable: "Practitioners",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrescriptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrescriptionPrice = table.Column<decimal>(type: "money", nullable: false),
                    PrescriptionQty = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    MedicinesID = table.Column<int>(type: "int", nullable: true),
                    PatientID = table.Column<int>(type: "int", nullable: true),
                    PractitionerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Medicines_MedicinesID",
                        column: x => x.MedicinesID,
                        principalTable: "Medicines",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Prescriptions_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Prescriptions_Practitioners_PractitionerID",
                        column: x => x.PractitionerID,
                        principalTable: "Practitioners",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientID",
                table: "Appointments",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PractitionerID",
                table: "Appointments",
                column: "PractitionerID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AccountID",
                table: "Patients",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PractitionerID",
                table: "Patients",
                column: "PractitionerID");

            migrationBuilder.CreateIndex(
                name: "IX_Practitioners_AccountID",
                table: "Practitioners",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_MedicinesID",
                table: "Prescriptions",
                column: "MedicinesID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatientID",
                table: "Prescriptions",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PractitionerID",
                table: "Prescriptions",
                column: "PractitionerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Symptoms");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Practitioners");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
