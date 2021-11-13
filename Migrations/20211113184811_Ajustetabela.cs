using Microsoft.EntityFrameworkCore.Migrations;

namespace WS_Lanches.Migrations
{
    public partial class Ajustetabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoCompraItems_Lanches_LancheId",
                table: "CarrinhoCompraItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarrinhoCompraItems",
                table: "CarrinhoCompraItems");

            migrationBuilder.RenameTable(
                name: "CarrinhoCompraItems",
                newName: "CarrinhoCompraItens");

            migrationBuilder.RenameIndex(
                name: "IX_CarrinhoCompraItems_LancheId",
                table: "CarrinhoCompraItens",
                newName: "IX_CarrinhoCompraItens_LancheId");

            migrationBuilder.AlterColumn<string>(
                name: "CarrinhoCompraId",
                table: "CarrinhoCompraItens",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarrinhoCompraItens",
                table: "CarrinhoCompraItens",
                column: "CarrinhoCompraItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoCompraItens_Lanches_LancheId",
                table: "CarrinhoCompraItens",
                column: "LancheId",
                principalTable: "Lanches",
                principalColumn: "LancheId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoCompraItens_Lanches_LancheId",
                table: "CarrinhoCompraItens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarrinhoCompraItens",
                table: "CarrinhoCompraItens");

            migrationBuilder.RenameTable(
                name: "CarrinhoCompraItens",
                newName: "CarrinhoCompraItems");

            migrationBuilder.RenameIndex(
                name: "IX_CarrinhoCompraItens_LancheId",
                table: "CarrinhoCompraItems",
                newName: "IX_CarrinhoCompraItems_LancheId");

            migrationBuilder.AlterColumn<string>(
                name: "CarrinhoCompraId",
                table: "CarrinhoCompraItems",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarrinhoCompraItems",
                table: "CarrinhoCompraItems",
                column: "CarrinhoCompraItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoCompraItems_Lanches_LancheId",
                table: "CarrinhoCompraItems",
                column: "LancheId",
                principalTable: "Lanches",
                principalColumn: "LancheId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
