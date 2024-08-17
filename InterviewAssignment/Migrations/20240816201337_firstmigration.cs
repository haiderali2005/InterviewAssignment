using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewAssignment.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tavle_order",
                columns: table => new
                {
                    Order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tavle_order", x => x.Order_id);
                });

            migrationBuilder.CreateTable(
                name: "tavle_orderdetail",
                columns: table => new
                {
                    OrderDetail_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_Id = table.Column<int>(type: "int", nullable: false),
                    FruitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tavle_orderdetail", x => x.OrderDetail_id);
                    table.ForeignKey(
                        name: "FK_tavle_orderdetail_tavle_order_Order_Id",
                        column: x => x.Order_Id,
                        principalTable: "tavle_order",
                        principalColumn: "Order_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tavle_orderdetail_Order_Id",
                table: "tavle_orderdetail",
                column: "Order_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tavle_orderdetail");

            migrationBuilder.DropTable(
                name: "tavle_order");
        }
    }
}
