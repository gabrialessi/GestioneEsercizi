using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GestioneEsercizi.DA.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anni",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Annata = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anni", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    AnnoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classi_Anni_AnnoId",
                        column: x => x.AnnoId,
                        principalTable: "Anni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moduli",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    ClasseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moduli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moduli_Classi_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prove",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titolo = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    ClasseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prove", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prove_Classi_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Esercizi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titolo = table.Column<string>(nullable: true),
                    Testo = table.Column<string>(nullable: true),
                    ModuloId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Esercizi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Esercizi_Moduli_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "Moduli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tematiche",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    ModuloId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tematiche", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tematiche_Moduli_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "Moduli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EserciziProva",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EsercizioId = table.Column<int>(nullable: true),
                    ProvaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EserciziProva", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EserciziProva_Esercizi_EsercizioId",
                        column: x => x.EsercizioId,
                        principalTable: "Esercizi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EserciziProva_Prove_ProvaId",
                        column: x => x.ProvaId,
                        principalTable: "Prove",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classi_AnnoId",
                table: "Classi",
                column: "AnnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Esercizi_ModuloId",
                table: "Esercizi",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "IX_EserciziProva_EsercizioId",
                table: "EserciziProva",
                column: "EsercizioId");

            migrationBuilder.CreateIndex(
                name: "IX_EserciziProva_ProvaId",
                table: "EserciziProva",
                column: "ProvaId");

            migrationBuilder.CreateIndex(
                name: "IX_Moduli_ClasseId",
                table: "Moduli",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Prove_ClasseId",
                table: "Prove",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Tematiche_ModuloId",
                table: "Tematiche",
                column: "ModuloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EserciziProva");

            migrationBuilder.DropTable(
                name: "Tematiche");

            migrationBuilder.DropTable(
                name: "Esercizi");

            migrationBuilder.DropTable(
                name: "Prove");

            migrationBuilder.DropTable(
                name: "Moduli");

            migrationBuilder.DropTable(
                name: "Classi");

            migrationBuilder.DropTable(
                name: "Anni");
        }
    }
}
