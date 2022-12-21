using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FuzzySearchApi.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:fuzzystrmatch", ",,");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[,]
                {
                    { 1, 20, "Azamjon" },
                    { 2, 18, "MuhammadDiyor" },
                    { 3, 26, "Nuriddin" },
                    { 4, 17, "Abdulaziz" },
                    { 5, 26, "Umidbek" },
                    { 6, 20, "Botirjon" },
                    { 7, 19, "Jamoliddin" },
                    { 8, 23, "Shaxzod" },
                    { 9, 25, "Javlon" },
                    { 10, 26, "Abduvohid" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
