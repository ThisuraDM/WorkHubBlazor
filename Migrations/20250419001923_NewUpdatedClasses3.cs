using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class NewUpdatedClasses3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Job");

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Work",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Description",
                table: "Job",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "Job",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Job",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Work_JobId",
                table: "Work",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Work_Job_JobId",
                table: "Work",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Work_Job_JobId",
                table: "Work");

            migrationBuilder.DropIndex(
                name: "IX_Work_JobId",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Job");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Job",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
