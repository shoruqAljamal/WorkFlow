using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkFlow.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WFStatus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WFStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlows",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WFStatusId = table.Column<int>(type: "int", nullable: false),
                    CurrentProgressNumberWFStep = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlows", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WorkFlows_WFStatus_WFStatusId",
                        column: x => x.WFStatusId,
                        principalTable: "WFStatus",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "WFSteps",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    IsFirst = table.Column<bool>(type: "bit", nullable: false),
                    IsFinal = table.Column<bool>(type: "bit", nullable: false),
                    WFStatusId = table.Column<int>(type: "int", nullable: false),
                    WFId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WFSteps", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WFSteps_WFStatus_WFStatusId",
                        column: x => x.WFStatusId,
                        principalTable: "WFStatus",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WFSteps_WorkFlows_WFId",
                        column: x => x.WFId,
                        principalTable: "WorkFlows",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "WFTasks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WFId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WFTasks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WFTasks_WorkFlows_WFId",
                        column: x => x.WFId,
                        principalTable: "WorkFlows",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_WFSteps_Number",
                table: "WFSteps",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WFSteps_WFId",
                table: "WFSteps",
                column: "WFId");

            migrationBuilder.CreateIndex(
                name: "IX_WFSteps_WFStatusId",
                table: "WFSteps",
                column: "WFStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_WFTasks_WFId",
                table: "WFTasks",
                column: "WFId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlows_WFStatusId",
                table: "WorkFlows",
                column: "WFStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WFSteps");

            migrationBuilder.DropTable(
                name: "WFTasks");

            migrationBuilder.DropTable(
                name: "WorkFlows");

            migrationBuilder.DropTable(
                name: "WFStatus");
        }
    }
}
