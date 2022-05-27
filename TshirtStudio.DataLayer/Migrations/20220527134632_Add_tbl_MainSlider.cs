using Microsoft.EntityFrameworkCore.Migrations;

namespace TshirtStudio.DataLayer.Migrations
{
    public partial class Add_tbl_MainSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mainSliders",
                columns: table => new
                {
                    Sliderid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SliderTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sliderAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderSort = table.Column<int>(type: "int", nullable: false),
                    SliderLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainSliders", x => x.Sliderid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mainSliders");
        }
    }
}
