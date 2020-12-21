using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkFlow.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WFStatus",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Create" },
                    { 2, "In Progress" },
                    { 3, "Finished" },
                    { 4, "Declined" }
                });

            migrationBuilder.InsertData(
                table: "WorkFlows",
                columns: new[] { "ID", "CurrentProgressNumberWFStep", "Name", "WFStatusId" },
                values: new object[] { 1, 0, "Add User", 1 });

            migrationBuilder.InsertData(
                table: "WFSteps",
                columns: new[] { "ID", "IsFinal", "IsFirst", "Number", "WFId", "WFStatusId" },
                values: new object[,]
                {
                    { 1, false, true, 1, 1, 1 },
                    { 2, false, false, 2, 1, 1 },
                    { 3, true, false, 3, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "WFTasks",
                columns: new[] { "ID", "Description", "WFId" },
                values: new object[,]
                {
                    { 1, "add name", 1 },
                    { 2, "add gender", 1 },
                    { 3, "add age", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WFStatus",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WFStatus",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WFStatus",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WFSteps",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WFSteps",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WFSteps",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WFTasks",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WFTasks",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WFTasks",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkFlows",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WFStatus",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
