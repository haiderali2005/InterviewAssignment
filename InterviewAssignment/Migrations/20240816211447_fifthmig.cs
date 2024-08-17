using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewAssignment.Migrations
{
    public partial class fifthmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_table_orderdetail_table_order_Order_Id",
                table: "table_orderdetail");

            migrationBuilder.RenameColumn(
                name: "Order_Id",
                table: "table_orderdetail",
                newName: "Order_id");

            migrationBuilder.RenameIndex(
                name: "IX_table_orderdetail_Order_Id",
                table: "table_orderdetail",
                newName: "IX_table_orderdetail_Order_id");

            migrationBuilder.AddForeignKey(
                name: "FK_table_orderdetail_table_order_Order_id",
                table: "table_orderdetail",
                column: "Order_id",
                principalTable: "table_order",
                principalColumn: "Order_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_table_orderdetail_table_order_Order_id",
                table: "table_orderdetail");

            migrationBuilder.RenameColumn(
                name: "Order_id",
                table: "table_orderdetail",
                newName: "Order_Id");

            migrationBuilder.RenameIndex(
                name: "IX_table_orderdetail_Order_id",
                table: "table_orderdetail",
                newName: "IX_table_orderdetail_Order_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_table_orderdetail_table_order_Order_Id",
                table: "table_orderdetail",
                column: "Order_Id",
                principalTable: "table_order",
                principalColumn: "Order_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
