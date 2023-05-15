using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dizimo.Migrations
{
    /// <inheritdoc />
    public partial class CriaAteControleDizimo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comunidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFundacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControlePagamentoModelId = table.Column<int>(type: "int", nullable: true),
                    UsuarioModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comunidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ComunidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Comunidades_ComunidadeId",
                        column: x => x.ComunidadeId,
                        principalTable: "Comunidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ControlePagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DizimistaId = table.Column<int>(type: "int", nullable: false),
                    ComunidadeId = table.Column<int>(type: "int", nullable: false),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    MesAno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Janeiro = table.Column<bool>(type: "bit", nullable: false),
                    Fevereiro = table.Column<bool>(type: "bit", nullable: false),
                    Marco = table.Column<bool>(type: "bit", nullable: false),
                    Abril = table.Column<bool>(type: "bit", nullable: false),
                    Maio = table.Column<bool>(type: "bit", nullable: false),
                    Junho = table.Column<bool>(type: "bit", nullable: false),
                    Julho = table.Column<bool>(type: "bit", nullable: false),
                    Agosto = table.Column<bool>(type: "bit", nullable: false),
                    Setembro = table.Column<bool>(type: "bit", nullable: false),
                    Outubro = table.Column<bool>(type: "bit", nullable: false),
                    Novembro = table.Column<bool>(type: "bit", nullable: false),
                    Dezembro = table.Column<bool>(type: "bit", nullable: false),
                    Atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlePagamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlePagamentos_Comunidades_ComunidadeId",
                        column: x => x.ComunidadeId,
                        principalTable: "Comunidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dizimistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CpfCnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ControlePagamentoModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dizimistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dizimistas_ControlePagamentos_ControlePagamentoModelId",
                        column: x => x.ControlePagamentoModelId,
                        principalTable: "ControlePagamentos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comunidades_ControlePagamentoModelId",
                table: "Comunidades",
                column: "ControlePagamentoModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Comunidades_UsuarioModelId",
                table: "Comunidades",
                column: "UsuarioModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlePagamentos_ComunidadeId",
                table: "ControlePagamentos",
                column: "ComunidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlePagamentos_DizimistaId",
                table: "ControlePagamentos",
                column: "DizimistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dizimistas_ControlePagamentoModelId",
                table: "Dizimistas",
                column: "ControlePagamentoModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ComunidadeId",
                table: "Usuarios",
                column: "ComunidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comunidades_ControlePagamentos_ControlePagamentoModelId",
                table: "Comunidades",
                column: "ControlePagamentoModelId",
                principalTable: "ControlePagamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comunidades_Usuarios_UsuarioModelId",
                table: "Comunidades",
                column: "UsuarioModelId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ControlePagamentos_Dizimistas_DizimistaId",
                table: "ControlePagamentos",
                column: "DizimistaId",
                principalTable: "Dizimistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comunidades_ControlePagamentos_ControlePagamentoModelId",
                table: "Comunidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Dizimistas_ControlePagamentos_ControlePagamentoModelId",
                table: "Dizimistas");

            migrationBuilder.DropForeignKey(
                name: "FK_Comunidades_Usuarios_UsuarioModelId",
                table: "Comunidades");

            migrationBuilder.DropTable(
                name: "ControlePagamentos");

            migrationBuilder.DropTable(
                name: "Dizimistas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Comunidades");
        }
    }
}
