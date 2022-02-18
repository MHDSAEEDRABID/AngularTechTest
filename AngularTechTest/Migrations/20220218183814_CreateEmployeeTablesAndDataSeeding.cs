using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularTechTest.Migrations
{
    public partial class CreateEmployeeTablesAndDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "IT", "Jhon", 100000 },
                    { 2, "HR", "Rimi", 200000 },
                    { 3, "Operation", "Jim", 50000 },
                    { 4, "IT", "Dev", 150000 },
                    { 5, "HR", "Sarah", 60000 },
                    { 6, "IT", "Steve", 170000 },
                    { 7, "Operation", "Henry", 60000 },
                    { 8, "IT", "Tony", 80000 },
                    { 9, "IT", "Ema", 85000 },
                    { 10, "Operation", "Dani", 90000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
