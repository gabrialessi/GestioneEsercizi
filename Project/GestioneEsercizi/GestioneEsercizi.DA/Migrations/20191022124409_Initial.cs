using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestioneEsercizi.DA.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Annata = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    AnnoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classi_Anno_AnnoId",
                        column: x => x.AnnoId,
                        principalTable: "Anno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Moduli",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    AnnoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moduli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moduli_Anno_AnnoId",
                        column: x => x.AnnoId,
                        principalTable: "Anno",
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
                    AnnoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prove", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prove_Anno_AnnoId",
                        column: x => x.AnnoId,
                        principalTable: "Anno",
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
                name: "Esercizi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titolo = table.Column<string>(nullable: true),
                    Testo = table.Column<string>(nullable: true),
                    ModuloId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    EsercizioId = table.Column<int>(nullable: true),
                    ProvaId = table.Column<int>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Esercizi_Esercizi_EsercizioId",
                        column: x => x.EsercizioId,
                        principalTable: "Esercizi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Esercizi_Prove_ProvaId",
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
                name: "IX_Esercizi_EsercizioId",
                table: "Esercizi",
                column: "EsercizioId");

            migrationBuilder.CreateIndex(
                name: "IX_Esercizi_ProvaId",
                table: "Esercizi",
                column: "ProvaId");

            migrationBuilder.CreateIndex(
                name: "IX_Moduli_AnnoId",
                table: "Moduli",
                column: "AnnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prove_AnnoId",
                table: "Prove",
                column: "AnnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tematiche_ModuloId",
                table: "Tematiche",
                column: "ModuloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classi");

            migrationBuilder.DropTable(
                name: "Esercizi");

            migrationBuilder.DropTable(
                name: "Tematiche");

            migrationBuilder.DropTable(
                name: "Prove");

            migrationBuilder.DropTable(
                name: "Moduli");

            migrationBuilder.DropTable(
                name: "Anno");
        }
    }
}
