using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial_Setup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    SectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.SectionId);
                });

            migrationBuilder.CreateTable(
                name: "StudentPersonal",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardianName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPersonal", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "ClassId", "ClassName", "CreateDate", "CreatedBy", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1001, "Class 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rovid Kashyap", "Rovid Kashyap", null },
                    { 1002, "Class 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rovid Kashyap", "Rovid Kashyap", null },
                    { 1003, "Class 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rovid Kashyap", "Rovid Kashyap", null },
                    { 1004, "Class 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rovid Kashyap", "Rovid Kashyap", null }
                });

            migrationBuilder.InsertData(
                table: "Section",
                columns: new[] { "SectionId", "CreateDate", "CreatedBy", "SectionName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1111, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rovid Kashyap", "A", "Rovid Kashyap", null },
                    { 1112, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rovid Kashyap", "B", "Rovid Kashyap", null },
                    { 1113, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rovid Kashyap", "C", "Rovid Kashyap", null },
                    { 1114, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rovid Kashyap", "D", "Rovid Kashyap", null }
                });

            migrationBuilder.InsertData(
                table: "StudentPersonal",
                columns: new[] { "StudentId", "ClassId", "CreateDate", "CreatedBy", "Email", "FatherName", "FirstName", "GuardianName", "LastName", "Mobile", "MotherName", "SectionId", "UpdatedBy", "UpdatedDate", "gender" },
                values: new object[,]
                {
                    { 10001, 1001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rovid Kashyap", "ashish.singh@gmail.com", "Ravi Singh", "Ashish", "Shiv Dubey", "Singh", "9045102010", "Urmi Singh", 1111, "Rovid Kashyap", null, "Male" },
                    { 10002, 1002, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rovid Kashyap", "arjun.singh@gmail.com", "Rohan Singh", "Arjun", "Rishab Yadav", "Singh", "9760332211", "Laxmi Singh", 1112, "Rovid Kashyap", null, "Male" },
                    { 10003, 1003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rovid Kashyap", "pooja.tomar@gmail.com", "Ravi Tomar", "Pooja", "Ashish Chanchal", "Tomar", "7854122321", "Shweta Tomar", 1111, "Rovid Kashyap", null, "Female" },
                    { 10004, 1004, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rovid Kashyap", "rashi.verma@gmail.com", "Pankaj Verma", "Rashi", "Ashok Nagar", "Verma", "9897202010", "Rashmi Verma", 1113, "Rovid Kashyap", null, "Female" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "StudentPersonal");
        }
    }
}
