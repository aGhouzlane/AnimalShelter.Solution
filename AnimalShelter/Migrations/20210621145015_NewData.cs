using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class NewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                columns: new[] { "Age", "Species" },
                values: new object[] { 3, "Cat" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Age", "Species" },
                values: new object[] { 1, "Dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Gender", "Species" },
                values: new object[] { "Male", "Cat" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Age", "Species" },
                values: new object[] { 3, "Bird" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                columns: new[] { "Age", "Gender", "Species" },
                values: new object[] { 2, "Female", "Bird" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                columns: new[] { "Age", "Species" },
                values: new object[] { 7, "Woolly Mammoth" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Age", "Species" },
                values: new object[] { 10, "Dinosaur" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Gender", "Species" },
                values: new object[] { "Female", "Dinosaur" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Age", "Species" },
                values: new object[] { 4, "Shark" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                columns: new[] { "Age", "Gender", "Species" },
                values: new object[] { 22, "Male", "Dinosaur" });
        }
    }
}
