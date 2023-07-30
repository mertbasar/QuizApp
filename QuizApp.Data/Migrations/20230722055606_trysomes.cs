using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class trysomes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quizzes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bilim" },
                    { 2, "Tarih" },
                    { 3, "Spor" },
                    { 4, "Sanat" },
                    { 5, "Müzik" },
                    { 6, "Film" },
                    { 7, "Teknoloji" },
                    { 8, "Gezi" },
                    { 9, "Gastronomi" },
                    { 10, "Edebiyat" }
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Bilimle ilgili genel kültür soruları", "Bilim Quiz" },
                    { 2, 2, "Tarihle ilgili genel kültür soruları", "Tarih Quiz" },
                    { 3, 3, "Sporla ilgili genel kültür soruları", "Spor Quiz" },
                    { 4, 4, "Sanatla ilgili genel kültür soruları", "Sanat Quiz" },
                    { 5, 5, "Müzikle ilgili genel kültür soruları", "Müzik Quiz" },
                    { 6, 6, "Filmle ilgili genel kültür soruları", "Film Quiz" },
                    { 7, 7, "Teknolojiyle ilgili genel kültür soruları", "Teknoloji Quiz" },
                    { 8, 8, "Gezi ve seyahatle ilgili genel kültür soruları", "Gezi Quiz" },
                    { 9, 9, "Gastronomiyle ilgili genel kültür soruları", "Gastronomi Quiz" },
                    { 10, 10, "Edebiyatla ilgili genel kültür soruları", "Edebiyat Quiz" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "QuizId", "Text" },
                values: new object[,]
                {
                    { 1, 1, "Saatte kaç kez nefes alırız?" },
                    { 2, 1, "Dünyanın en büyük okyanusu hangisidir?" },
                    { 3, 1, "İlk insan hangi gezegende yürüdü?" },
                    { 4, 2, "Hangi yıl Türkiye Cumhuriyeti kuruldu?" },
                    { 5, 2, "Hangi yılda İstanbul'un fethi gerçekleşti?" },
                    { 6, 2, "Osmanlı İmparatorluğu hangi yılda sona erdi?" },
                    { 7, 3, "Hangi spor dalında gol atılmaz?" },
                    { 8, 3, "FIFA'nın kuruluş yılı nedir?" },
                    { 9, 3, "En uzun Grand Slam tenis maçı hangi turnuvada oynanmıştır?" },
                    { 10, 4, "Mona Lisa tablosunun yaratıcısı kimdir?" },
                    { 11, 4, "Hangi ressam, 'Yıldızlı Gece' adlı eseriyle ünlüdür?" },
                    { 12, 4, "Hangi heykel, Özgürlük Heykeli olarak da bilinir?" },
                    { 13, 5, "Hangi enstrüman tuşlu bir çalgıdır?" },
                    { 14, 5, "Hangi müzik türü 17. yüzyılda ortaya çıkmıştır?" },
                    { 15, 5, "Hangi şarkıcı, 'Thriller' albümünü çıkarmıştır?" },
                    { 16, 6, "Hangi film, 'Hakuna Matata' şarkısıyla ünlüdür?" },
                    { 17, 6, "Hangi yönetmen, 'The Godfather' serisini yönetmiştir?" },
                    { 18, 6, "Hangi film, 'May the Force be with you' repliğiyle ünlüdür?" },
                    { 19, 7, "Hangi şirket, iPhone'u geliştirmiştir?" },
                    { 20, 7, "Hangi programlama dili, web geliştirmede kullanılır?" },
                    { 21, 7, "Hangi buluş, elektrikli lambayı icat etmiştir?" },
                    { 22, 8, "Hangi şehir, Eyfel Kulesi'ne ev sahipliği yapar?" },
                    { 23, 8, "Hangi ülke, Ayasofya Camii'ne ev sahipliği yapar?" },
                    { 24, 8, "Hangi şehir, Büyük Patlama'ya ev sahipliği yapmıştır?" },
                    { 25, 9, "Hangi ülke, pizza'nın doğum yeri olarak bilinir?" },
                    { 26, 9, "Hangi baharat, en çok kullanılan baharatlardan biridir?" },
                    { 27, 9, "Hangi meyve, 'Dünya'nın elması' olarak bilinir?" },
                    { 28, 10, "Hangi yazar, '1984' romanını yazmıştır?" },
                    { 29, 10, "Hangi yazar, 'Anna Karenina' romanını yazmıştır?" },
                    { 30, 10, "Hangi yazar, 'Beyaz Diş' romanını yazmıştır?" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 1, 1, "5000" },
                    { 2, 1, "20.000" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 3, true, 2, "Cıva" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 4, 2, "Oksijen" },
                    { 5, 3, "Mars" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 6, true, 3, "Dünya" },
                    { 7, true, 4, "Astronomi" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 8, 4, "Biyoloji" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 9, true, 5, "Mona Lisa" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 10, 5, "Pablo Picasso" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 11, true, 6, "Özgürlük Heykeli" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 12, 6, "David" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 13, true, 7, "Apple" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 14, 7, "Microsoft" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 15, true, 8, "C#" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 16, 8, "Java" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 17, true, 9, "Thomas Edison" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 18, 9, "Albert Einstein" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 19, true, 10, "George Orwell" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 20, 10, "Leo Tolstoy" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 21, true, 11, "Simba" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 22, 11, "Mufasa" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 23, true, 12, "Francis Ford Coppola" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 24, 12, "Martin Scorsese" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 25, true, 13, "Star Wars" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 26, 13, "The Matrix" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 27, true, 14, "İtalya" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 28, 14, "Fransa" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 29, true, 15, "Büyük Patlama" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 30, 15, "Büyük Sel" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 31, true, 16, "Michael Jackson" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 32, 16, "Prince" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 33, true, 17, "Francis Ford Coppola" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 34, 17, "Steven Spielberg" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 35, true, 18, "Star Wars" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 36, 18, "Indiana Jones" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 37, true, 19, "Eiffel Kulesi" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 38, 19, "Kremlin Sarayı" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 39, true, 20, "İtalya" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 40, 20, "İspanya" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 41, true, 21, "Büyük Patlama" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 42, 21, "Büyük Sel" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 43, true, 22, "Pablo Picasso" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 44, 22, "Salvador Dali" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 45, true, 23, "Auguste Rodin" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 46, 23, "Michelangelo" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 47, true, 24, "George Orwell" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 48, 24, "Fyodor Dostoyevsky" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 49, true, 25, "Mark Twain" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 50, 25, "J.R.R. Tolkien" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 51, true, 26, "İtalya" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 52, 26, "Fransa" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 53, true, 27, "Tarçın" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 54, 27, "Kimyon" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 55, true, 28, "Elma" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 56, 28, "Armut" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 57, true, 29, "George Orwell" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 58, 29, "Fyodor Dostoyevsky" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[] { 59, true, 30, "Jack London" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[] { 60, 30, "Mark Twain" });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizId",
                table: "Questions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_CategoryId",
                table: "Quizzes",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
