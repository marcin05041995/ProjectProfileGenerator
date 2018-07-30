using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApiToProject.Migrations
{
    public partial class DbInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Employees_EmployeeId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Employees_EmployeeId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_EmployeeId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Languages_EmployeeId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Languages");

            migrationBuilder.CreateTable(
                name: "EmployeeLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLanguage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeLanguage_Languages_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeLanguage_Employees_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSkill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeSkill_Skills_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeSkill_Employees_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLanguage_LanguageId",
                table: "EmployeeLanguage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLanguage_EmployeeId_LanguageId",
                table: "EmployeeLanguage",
                columns: new[] { "EmployeeId", "LanguageId" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSkill_SkillId",
                table: "EmployeeSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSkill_EmployeeId_SkillId",
                table: "EmployeeSkill",
                columns: new[] { "EmployeeId", "SkillId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeLanguage");

            migrationBuilder.DropTable(
                name: "EmployeeSkill");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Languages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_EmployeeId",
                table: "Skills",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_EmployeeId",
                table: "Languages",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Employees_EmployeeId",
                table: "Languages",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Employees_EmployeeId",
                table: "Skills",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
