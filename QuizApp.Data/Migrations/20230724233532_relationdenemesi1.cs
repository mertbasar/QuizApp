using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class relationdenemesi1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId1",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionId1",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "QuestionId1",
                table: "Answers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionId1",
                table: "Answers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 14,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 15,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 18,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 19,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 20,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 21,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 25,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 26,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 27,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 30,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 31,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 32,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 33,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 39,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 40,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 41,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 42,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 43,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 44,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 45,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 46,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 47,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 48,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 49,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 50,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 51,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 52,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 53,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 54,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 55,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 56,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 57,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 58,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 59,
                column: "QuestionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 60,
                column: "QuestionId1",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId1",
                table: "Answers",
                column: "QuestionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId1",
                table: "Answers",
                column: "QuestionId1",
                principalTable: "Questions",
                principalColumn: "Id");
        }
    }
}
