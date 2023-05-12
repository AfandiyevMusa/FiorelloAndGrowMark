using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrowMark_Backend.Migrations
{
    public partial class CreateProjectDetailsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "projectDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "projectDetails");
        }
    }
}
