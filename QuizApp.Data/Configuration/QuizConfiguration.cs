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
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.ToTable("Quizzes"); // Tablo adını belirtmek için kullanılır
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Name).IsRequired().HasMaxLength(100);
            builder.Property(q => q.Description).HasMaxLength(500);
            builder.Property(q => q.CreatedAt).IsRequired().HasDefaultValueSql("GETDATE()");

            builder.HasOne(q => q.Category)
                .WithMany()
                .HasForeignKey(q => q.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(
            new Quiz { Id = 1, Name = "Bilim Quiz", Description = "Bilimle ilgili genel kültür soruları", CategoryId = 1 },
            new Quiz { Id = 2, Name = "Tarih Quiz", Description = "Tarihle ilgili genel kültür soruları", CategoryId = 2 },
            new Quiz { Id = 3, Name = "Spor Quiz", Description = "Sporla ilgili genel kültür soruları", CategoryId = 3 },
            new Quiz { Id = 4, Name = "Sanat Quiz", Description = "Sanatla ilgili genel kültür soruları", CategoryId = 4 },
            new Quiz { Id = 5, Name = "Müzik Quiz", Description = "Müzikle ilgili genel kültür soruları", CategoryId = 5 },
            new Quiz { Id = 6, Name = "Film Quiz", Description = "Filmle ilgili genel kültür soruları", CategoryId = 6 },
            new Quiz { Id = 7, Name = "Teknoloji Quiz", Description = "Teknolojiyle ilgili genel kültür soruları", CategoryId = 7 },
            new Quiz { Id = 8, Name = "Gezi Quiz", Description = "Gezi ve seyahatle ilgili genel kültür soruları", CategoryId = 8 },
            new Quiz { Id = 9, Name = "Gastronomi Quiz", Description = "Gastronomiyle ilgili genel kültür soruları", CategoryId = 9 },
            new Quiz { Id = 10, Name = "Edebiyat Quiz", Description = "Edebiyatla ilgili genel kültür soruları", CategoryId = 10 }
        );
        }
    }
}
