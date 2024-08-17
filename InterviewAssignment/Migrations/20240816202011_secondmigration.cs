using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewAssignment.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tavle_orderdetail_tavle_order_Order_Id",
                table: "tavle_orderdetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tavle_orderdetail",
                table: "tavle_orderdetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tavle_order",
                table: "tavle_order");

            migrationBuilder.RenameTable(
                name: "tavle_orderdetail",
                newName: "table_orderdetail");

            migrationBuilder.RenameTable(
                name: "tavle_order",
                newName: "table_order");

            migrationBuilder.RenameIndex(
                name: "IX_tavle_orderdetail_Order_Id",
                table: "table_orderdetail",
                newName: "IX_table_orderdetail_Order_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_table_orderdetail",
                table: "table_orderdetail",
                column: "OrderDetail_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_table_order",
                table: "table_order",
                column: "Order_id");

            migrationBuilder.AddForeignKey(
                name: "FK_table_orderdetail_table_order_Order_Id",
                table: "table_orderdetail",
                column: "Order_Id",
                principalTable: "table_order",
                principalColumn: "Order_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_table_orderdetail_table_order_Order_Id",
                table: "table_orderdetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_table_orderdetail",
                table: "table_orderdetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_table_order",
                table: "table_order");

            migrationBuilder.RenameTable(
                name: "table_orderdetail",
                newName: "tavle_orderdetail");

            migrationBuilder.RenameTable(
                name: "table_order",
                newName: "tavle_order");

            migrationBuilder.RenameIndex(
                name: "IX_table_orderdetail_Order_Id",
                table: "tavle_orderdetail",
                newName: "IX_tavle_orderdetail_Order_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tavle_orderdetail",
                table: "tavle_orderdetail",
                column: "OrderDetail_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tavle_order",
                table: "tavle_order",
                column: "Order_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tavle_orderdetail_tavle_order_Order_Id",
                table: "tavle_orderdetail",
                column: "Order_Id",
                principalTable: "tavle_order",
                principalColumn: "Order_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
