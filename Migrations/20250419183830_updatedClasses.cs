using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class updatedClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Work_Job_JobId",
                table: "Work");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerOccupation_Job_JobId",
                table: "WorkerOccupation");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropIndex(
                name: "IX_WorkerOccupation_JobId",
                table: "WorkerOccupation");

            migrationBuilder.DropIndex(
                name: "IX_Work_JobId",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "WorkerOccupation");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Work");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "WorkerOccupation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Work",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkerOccupation_JobId",
                table: "WorkerOccupation",
                column: "JobId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerOccupation_Job_JobId",
                table: "WorkerOccupation",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
