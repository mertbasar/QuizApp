using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using QuizApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Data.Configuration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.ToTable("Answers"); // Tablo adını belirtmek için kullanılır
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Text).IsRequired().HasMaxLength(500);
            builder.Property(a => a.IsCorrect).IsRequired().HasDefaultValue(false);

            builder.HasOne(a => a.Question)
                   .WithMany(q => q.Answers)
                   .HasForeignKey(a => a.QuestionId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(
            // Question 1
            new Answer { Id = 1, Text = "5000", IsCorrect = false, QuestionId = 1 },
            new Answer { Id = 2, Text = "20.000", IsCorrect = false, QuestionId = 1 },
            // Question 2
            new Answer { Id = 3, Text = "Cıva", IsCorrect = true, QuestionId = 2 },
            new Answer { Id = 4, Text = "Oksijen", IsCorrect = false, QuestionId = 2 },
            // Question 3
            new Answer { Id = 5, Text = "Mars", IsCorrect = false, QuestionId = 3 },
            new Answer { Id = 6, Text = "Dünya", IsCorrect = true, QuestionId = 3 },
            // Question 4
            new Answer { Id = 7, Text = "Astronomi", IsCorrect = true, QuestionId = 4 },
            new Answer { Id = 8, Text = "Biyoloji", IsCorrect = false, QuestionId = 4 },
            // Question 5
            new Answer { Id = 9, Text = "Mona Lisa", IsCorrect = true, QuestionId = 5 },
            new Answer { Id = 10, Text = "Pablo Picasso", IsCorrect = false, QuestionId = 5 },
            // Question 6
            new Answer { Id = 11, Text = "Özgürlük Heykeli", IsCorrect = true, QuestionId = 6 },
            new Answer { Id = 12, Text = "David", IsCorrect = false, QuestionId = 6 },
            // Question 7
            new Answer { Id = 13, Text = "Apple", IsCorrect = true, QuestionId = 7 },
            new Answer { Id = 14, Text = "Microsoft", IsCorrect = false, QuestionId = 7 },
            // Question 8
            new Answer { Id = 15, Text = "C#", IsCorrect = true, QuestionId = 8 },
            new Answer { Id = 16, Text = "Java", IsCorrect = false, QuestionId = 8 },
            // Question 9
            new Answer { Id = 17, Text = "Thomas Edison", IsCorrect = true, QuestionId = 9 },
            new Answer { Id = 18, Text = "Albert Einstein", IsCorrect = false, QuestionId = 9 },
            // Question 10
            new Answer { Id = 19, Text = "George Orwell", IsCorrect = true, QuestionId = 10 },
            new Answer { Id = 20, Text = "Leo Tolstoy", IsCorrect = false, QuestionId = 10 },
            // Question 11
            new Answer { Id = 21, Text = "Simba", IsCorrect = true, QuestionId = 11 },
            new Answer { Id = 22, Text = "Mufasa", IsCorrect = false, QuestionId = 11 },
            // Question 12
            new Answer { Id = 23, Text = "Francis Ford Coppola", IsCorrect = true, QuestionId = 12 },
            new Answer { Id = 24, Text = "Martin Scorsese", IsCorrect = false, QuestionId = 12 },
            // Question 13
            new Answer { Id = 25, Text = "Star Wars", IsCorrect = true, QuestionId = 13 },
            new Answer { Id = 26, Text = "The Matrix", IsCorrect = false, QuestionId = 13 },
            // Question 14
            new Answer { Id = 27, Text = "İtalya", IsCorrect = true, QuestionId = 14 },
            new Answer { Id = 28, Text = "Fransa", IsCorrect = false, QuestionId = 14 },
            // Question 15
            new Answer { Id = 29, Text = "Büyük Patlama", IsCorrect = true, QuestionId = 15 },
            new Answer { Id = 30, Text = "Büyük Sel", IsCorrect = false, QuestionId = 15 },
            // Question 16
            new Answer { Id = 31, Text = "Michael Jackson", IsCorrect = true, QuestionId = 16 },
            new Answer { Id = 32, Text = "Prince", IsCorrect = false, QuestionId = 16 },
            // Question 17
            new Answer { Id = 33, Text = "Francis Ford Coppola", IsCorrect = true, QuestionId = 17 },
            new Answer { Id = 34, Text = "Steven Spielberg", IsCorrect = false, QuestionId = 17 },
            // Question 18
            new Answer { Id = 35, Text = "Star Wars", IsCorrect = true, QuestionId = 18 },
            new Answer { Id = 36, Text = "Indiana Jones", IsCorrect = false, QuestionId = 18 },
            // Question 19
            new Answer { Id = 37, Text = "Eiffel Kulesi", IsCorrect = true, QuestionId = 19 },
            new Answer { Id = 38, Text = "Kremlin Sarayı", IsCorrect = false, QuestionId = 19 },
            // Question 20
            new Answer { Id = 39, Text = "İtalya", IsCorrect = true, QuestionId = 20 },
            new Answer { Id = 40, Text = "İspanya", IsCorrect = false, QuestionId = 20 },
            // Question 21
            new Answer { Id = 41, Text = "Büyük Patlama", IsCorrect = true, QuestionId = 21 },
            new Answer { Id = 42, Text = "Büyük Sel", IsCorrect = false, QuestionId = 21 },
            // Question 22
            new Answer { Id = 43, Text = "Pablo Picasso", IsCorrect = true, QuestionId = 22 },
            new Answer { Id = 44, Text = "Salvador Dali", IsCorrect = false, QuestionId = 22 },
            // Question 23
            new Answer { Id = 45, Text = "Auguste Rodin", IsCorrect = true, QuestionId = 23 },
            new Answer { Id = 46, Text = "Michelangelo", IsCorrect = false, QuestionId = 23 },
            // Question 24
            new Answer { Id = 47, Text = "George Orwell", IsCorrect = true, QuestionId = 24 },
            new Answer { Id = 48, Text = "Fyodor Dostoyevsky", IsCorrect = false, QuestionId = 24 },
            // Question 25
            new Answer { Id = 49, Text = "Mark Twain", IsCorrect = true, QuestionId = 25 },
            new Answer { Id = 50, Text = "J.R.R. Tolkien", IsCorrect = false, QuestionId = 25 },
            // Question 26
            new Answer { Id = 51, Text = "İtalya", IsCorrect = true, QuestionId = 26 },
            new Answer { Id = 52, Text = "Fransa", IsCorrect = false, QuestionId = 26 },
            // Question 27
            new Answer { Id = 53, Text = "Tarçın", IsCorrect = true, QuestionId = 27 },
            new Answer { Id = 54, Text = "Kimyon", IsCorrect = false, QuestionId = 27 },
            // Question 28
            new Answer { Id = 55, Text = "Elma", IsCorrect = true, QuestionId = 28 },
            new Answer { Id = 56, Text = "Armut", IsCorrect = false, QuestionId = 28 },
            // Question 29
            new Answer { Id = 57, Text = "George Orwell", IsCorrect = true, QuestionId = 29 },
            new Answer { Id = 58, Text = "Fyodor Dostoyevsky", IsCorrect = false, QuestionId = 29 },
            // Question 30
            new Answer { Id = 59, Text = "Jack London", IsCorrect = true, QuestionId = 30 },
            new Answer { Id = 60, Text = "Mark Twain", IsCorrect = false, QuestionId = 30 }
        );
        }
    }
}
