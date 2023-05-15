using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dizimo.Migrations
{
    /// <inheritdoc />
    public partial class atualizaCP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ControlePagamentos_Comunidades_ComunidadeId",
                table: "ControlePagamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_ControlePagamentos_Dizimistas_DizimistaId",
                table: "ControlePagamentos");

            migrationBuilder.DropIndex(
                name: "IX_ControlePagamentos_ComunidadeId",
                table: "ControlePagamentos");

            migrationBuilder.DropIndex(
                name: "IX_ControlePagamentos_DizimistaId",
                table: "ControlePagamentos");

            migrationBuilder.AddColumn<int>(
                name: "comunidadecpId",
                table: "ControlePagamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "dizimistacpId",
                table: "ControlePagamentos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ControlePagamentos_comunidadecpId",
                table: "ControlePagamentos",
                column: "comunidadecpId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlePagamentos_dizimistacpId",
                table: "ControlePagamentos",
                column: "dizimistacpId");

            migrationBuilder.AddForeignKey(
                name: "FK_ControlePagamentos_Comunidades_comunidadecpId",
                table: "ControlePagamentos",
                column: "comunidadecpId",
                principalTable: "Comunidades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ControlePagamentos_Dizimistas_dizimistacpId",
                table: "ControlePagamentos",
                column: "dizimistacpId",
                principalTable: "Dizimistas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ControlePagamentos_Comunidades_comunidadecpId",
                table: "ControlePagamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_ControlePagamentos_Dizimistas_dizimistacpId",
                table: "ControlePagamentos");

            migrationBuilder.DropIndex(
                name: "IX_ControlePagamentos_comunidadecpId",
                table: "ControlePagamentos");

            migrationBuilder.DropIndex(
                name: "IX_ControlePagamentos_dizimistacpId",
                table: "ControlePagamentos");

            migrationBuilder.DropColumn(
                name: "comunidadecpId",
                table: "ControlePagamentos");

            migrationBuilder.DropColumn(
                name: "dizimistacpId",
                table: "ControlePagamentos");

            migrationBuilder.CreateIndex(
                name: "IX_ControlePagamentos_ComunidadeId",
                table: "ControlePagamentos",
                column: "ComunidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlePagamentos_DizimistaId",
                table: "ControlePagamentos",
                column: "DizimistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ControlePagamentos_Comunidades_ComunidadeId",
                table: "ControlePagamentos",
                column: "ComunidadeId",
                principalTable: "Comunidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ControlePagamentos_Dizimistas_DizimistaId",
                table: "ControlePagamentos",
                column: "DizimistaId",
                principalTable: "Dizimistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
