using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class NewUpdatedClasses4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerOccupation_Occupation_OccupationId",
                table: "WorkerOccupation");

            migrationBuilder.DropIndex(
                name: "IX_WorkerOccupation_OccupationId",
                table: "WorkerOccupation");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_WorkerOccupation_OccupationId",
                table: "WorkerOccupation",
                column: "OccupationId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerOccupation_Occupation_OccupationId",
                table: "WorkerOccupation",
                column: "OccupationId",
                principalTable: "Occupation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
