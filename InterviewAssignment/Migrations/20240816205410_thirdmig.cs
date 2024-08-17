using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewAssignment.Migrations
{
    public partial class thirdmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "table_orderdetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "table_orderdetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
