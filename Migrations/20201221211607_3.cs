using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkFlow.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WFSteps_Number",
                table: "WFSteps");

            migrationBuilder.CreateIndex(
                name: "IX_WFSteps_Number_WFId",
                table: "WFSteps",
                columns: new[] { "Number", "WFId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WFSteps_Number_WFId",
                table: "WFSteps");

            migrationBuilder.CreateIndex(
                name: "IX_WFSteps_Number",
                table: "WFSteps",
                column: "Number",
                unique: true);
        }
    }
}
