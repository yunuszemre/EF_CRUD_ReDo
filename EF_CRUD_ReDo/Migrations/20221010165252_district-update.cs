using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CRUD_ReDo.Migrations
{
    public partial class districtupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Customers_CustomerId",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Districts_CustomerId",
                table: "Districts");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Districts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CustomerId",
                table: "Districts",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Customers_CustomerId",
                table: "Districts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Customers_CustomerId",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Districts_CustomerId",
                table: "Districts");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Districts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CustomerId",
                table: "Districts",
                column: "CustomerId",
                unique: true,
                filter: "[CustomerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Customers_CustomerId",
                table: "Districts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");
        }
    }
}
