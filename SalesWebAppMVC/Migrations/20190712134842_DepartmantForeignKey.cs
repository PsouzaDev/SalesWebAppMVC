using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebAppMVC.Migrations
{
    public partial class DepartmantForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departmant_DepartmantId",
                table: "Seller");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmantId",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departmant_DepartmantId",
                table: "Seller",
                column: "DepartmantId",
                principalTable: "Departmant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departmant_DepartmantId",
                table: "Seller");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmantId",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departmant_DepartmantId",
                table: "Seller",
                column: "DepartmantId",
                principalTable: "Departmant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
