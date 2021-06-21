using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
  public partial class SeedData : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.InsertData(
          table: "Animals",
          columns: new[] { "AnimalId", "Age", "Gender", "Name", "Species" },
          values: new object[,]
          {
                    { 1, 45, "Male", "Mimi", "Cat" },
                    { 2, 14, "Female", "Snowy", "Cat" },
                    { 3, 20, "Female", "Rocky", "Dog" },
                    { 4, 45, "Female", "Sunny", "Bird" },
                    { 5, 23, "Male", "Pikachu", "Bird" }
          });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DeleteData(
          table: "Animals",
          keyColumn: "AnimalId",
          keyValue: 1);

      migrationBuilder.DeleteData(
          table: "Animals",
          keyColumn: "AnimalId",
          keyValue: 2);

      migrationBuilder.DeleteData(
          table: "Animals",
          keyColumn: "AnimalId",
          keyValue: 3);

      migrationBuilder.DeleteData(
          table: "Animals",
          keyColumn: "AnimalId",
          keyValue: 4);

      migrationBuilder.DeleteData(
          table: "Animals",
          keyColumn: "AnimalId",
          keyValue: 5);
    }
  }
}
