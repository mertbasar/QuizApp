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
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Questions"); // Tablo adını belirtmek için kullanılır
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Text).IsRequired().HasMaxLength(500);

            builder.HasMany(q => q.Answers)
                   .WithOne(a => a.Question)
                   .HasForeignKey(a => a.QuestionId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(
            // Quiz 1 - Bilim Quiz
            new Question { Id = 1, Text = "Saatte kaç kez nefes alırız?",  QuizId = 1 },
            new Question { Id = 2, Text = "Dünyanın en büyük okyanusu hangisidir?", QuizId = 1 },
            new Question { Id = 3, Text = "İlk insan hangi gezegende yürüdü?", QuizId = 1 },
            // Quiz 2 - Tarih Quiz
            new Question { Id = 4, Text = "Hangi yıl Türkiye Cumhuriyeti kuruldu?", QuizId = 2 },
            new Question { Id = 5, Text = "Hangi yılda İstanbul'un fethi gerçekleşti?", QuizId = 2 },
            new Question { Id = 6, Text = "Osmanlı İmparatorluğu hangi yılda sona erdi?", QuizId = 2 },
            // Quiz 3 - Spor Quiz
            new Question { Id = 7, Text = "Hangi spor dalında gol atılmaz?", QuizId = 3 },
            new Question { Id = 8, Text = "FIFA'nın kuruluş yılı nedir?", QuizId = 3 },
            new Question { Id = 9, Text = "En uzun Grand Slam tenis maçı hangi turnuvada oynanmıştır?", QuizId = 3 },
            // Quiz 4 - Sanat Quiz
            new Question { Id = 10, Text = "Mona Lisa tablosunun yaratıcısı kimdir?", QuizId = 4 },
            new Question { Id = 11, Text = "Hangi ressam, 'Yıldızlı Gece' adlı eseriyle ünlüdür?", QuizId = 4 },
            new Question { Id = 12, Text = "Hangi heykel, Özgürlük Heykeli olarak da bilinir?", QuizId = 4 },
            // Quiz 5 - Müzik Quiz
            new Question { Id = 13, Text = "Hangi enstrüman tuşlu bir çalgıdır?", QuizId = 5 },
            new Question { Id = 14, Text = "Hangi müzik türü 17. yüzyılda ortaya çıkmıştır?", QuizId = 5 },
            new Question { Id = 15, Text = "Hangi şarkıcı, 'Thriller' albümünü çıkarmıştır?", QuizId = 5 },
            // Quiz 6 - Film Quiz
            new Question { Id = 16, Text = "Hangi film, 'Hakuna Matata' şarkısıyla ünlüdür?", QuizId = 6 },
            new Question { Id = 17, Text = "Hangi yönetmen, 'The Godfather' serisini yönetmiştir?", QuizId = 6 },
            new Question { Id = 18, Text = "Hangi film, 'May the Force be with you' repliğiyle ünlüdür?", QuizId = 6 },
            // Quiz 7 - Teknoloji Quiz
            new Question { Id = 19, Text = "Hangi şirket, iPhone'u geliştirmiştir?", QuizId = 7 },
            new Question { Id = 20, Text = "Hangi programlama dili, web geliştirmede kullanılır?", QuizId = 7 },
            new Question { Id = 21, Text = "Hangi buluş, elektrikli lambayı icat etmiştir?", QuizId = 7 },
            // Quiz 8 - Gezi Quiz
            new Question { Id = 22, Text = "Hangi şehir, Eyfel Kulesi'ne ev sahipliği yapar?", QuizId = 8 },
            new Question { Id = 23, Text = "Hangi ülke, Ayasofya Camii'ne ev sahipliği yapar?", QuizId = 8 },
            new Question { Id = 24, Text = "Hangi şehir, Büyük Patlama'ya ev sahipliği yapmıştır?", QuizId = 8 },
            // Quiz 9 - Gastronomi Quiz
            new Question { Id = 25, Text = "Hangi ülke, pizza'nın doğum yeri olarak bilinir?", QuizId = 9 },
            new Question { Id = 26, Text = "Hangi baharat, en çok kullanılan baharatlardan biridir?", QuizId = 9 },
            new Question { Id = 27, Text = "Hangi meyve, 'Dünya'nın elması' olarak bilinir?", QuizId = 9 },
            // Quiz 10 - Edebiyat Quiz
            new Question { Id = 28, Text = "Hangi yazar, '1984' romanını yazmıştır?", QuizId = 10 },
            new Question { Id = 29, Text = "Hangi yazar, 'Anna Karenina' romanını yazmıştır?", QuizId = 10 },
            new Question { Id = 30, Text = "Hangi yazar, 'Beyaz Diş' romanını yazmıştır?", QuizId = 10 }

        );
        }
    }
}
