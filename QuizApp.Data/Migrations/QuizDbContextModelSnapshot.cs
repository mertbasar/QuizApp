﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizApp.Data;

#nullable disable

namespace QuizApp.Data.Migrations
{
    [DbContext(typeof(QuizDbContext))]
    partial class QuizDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuizApp.Domain.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCorrect")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsCorrect = false,
                            QuestionId = 1,
                            Text = "5000"
                        },
                        new
                        {
                            Id = 2,
                            IsCorrect = false,
                            QuestionId = 1,
                            Text = "20.000"
                        },
                        new
                        {
                            Id = 3,
                            IsCorrect = true,
                            QuestionId = 2,
                            Text = "Cıva"
                        },
                        new
                        {
                            Id = 4,
                            IsCorrect = false,
                            QuestionId = 2,
                            Text = "Oksijen"
                        },
                        new
                        {
                            Id = 5,
                            IsCorrect = false,
                            QuestionId = 3,
                            Text = "Mars"
                        },
                        new
                        {
                            Id = 6,
                            IsCorrect = true,
                            QuestionId = 3,
                            Text = "Dünya"
                        },
                        new
                        {
                            Id = 7,
                            IsCorrect = true,
                            QuestionId = 4,
                            Text = "Astronomi"
                        },
                        new
                        {
                            Id = 8,
                            IsCorrect = false,
                            QuestionId = 4,
                            Text = "Biyoloji"
                        },
                        new
                        {
                            Id = 9,
                            IsCorrect = true,
                            QuestionId = 5,
                            Text = "Mona Lisa"
                        },
                        new
                        {
                            Id = 10,
                            IsCorrect = false,
                            QuestionId = 5,
                            Text = "Pablo Picasso"
                        },
                        new
                        {
                            Id = 11,
                            IsCorrect = true,
                            QuestionId = 6,
                            Text = "Özgürlük Heykeli"
                        },
                        new
                        {
                            Id = 12,
                            IsCorrect = false,
                            QuestionId = 6,
                            Text = "David"
                        },
                        new
                        {
                            Id = 13,
                            IsCorrect = true,
                            QuestionId = 7,
                            Text = "Apple"
                        },
                        new
                        {
                            Id = 14,
                            IsCorrect = false,
                            QuestionId = 7,
                            Text = "Microsoft"
                        },
                        new
                        {
                            Id = 15,
                            IsCorrect = true,
                            QuestionId = 8,
                            Text = "C#"
                        },
                        new
                        {
                            Id = 16,
                            IsCorrect = false,
                            QuestionId = 8,
                            Text = "Java"
                        },
                        new
                        {
                            Id = 17,
                            IsCorrect = true,
                            QuestionId = 9,
                            Text = "Thomas Edison"
                        },
                        new
                        {
                            Id = 18,
                            IsCorrect = false,
                            QuestionId = 9,
                            Text = "Albert Einstein"
                        },
                        new
                        {
                            Id = 19,
                            IsCorrect = true,
                            QuestionId = 10,
                            Text = "George Orwell"
                        },
                        new
                        {
                            Id = 20,
                            IsCorrect = false,
                            QuestionId = 10,
                            Text = "Leo Tolstoy"
                        },
                        new
                        {
                            Id = 21,
                            IsCorrect = true,
                            QuestionId = 11,
                            Text = "Simba"
                        },
                        new
                        {
                            Id = 22,
                            IsCorrect = false,
                            QuestionId = 11,
                            Text = "Mufasa"
                        },
                        new
                        {
                            Id = 23,
                            IsCorrect = true,
                            QuestionId = 12,
                            Text = "Francis Ford Coppola"
                        },
                        new
                        {
                            Id = 24,
                            IsCorrect = false,
                            QuestionId = 12,
                            Text = "Martin Scorsese"
                        },
                        new
                        {
                            Id = 25,
                            IsCorrect = true,
                            QuestionId = 13,
                            Text = "Star Wars"
                        },
                        new
                        {
                            Id = 26,
                            IsCorrect = false,
                            QuestionId = 13,
                            Text = "The Matrix"
                        },
                        new
                        {
                            Id = 27,
                            IsCorrect = true,
                            QuestionId = 14,
                            Text = "İtalya"
                        },
                        new
                        {
                            Id = 28,
                            IsCorrect = false,
                            QuestionId = 14,
                            Text = "Fransa"
                        },
                        new
                        {
                            Id = 29,
                            IsCorrect = true,
                            QuestionId = 15,
                            Text = "Büyük Patlama"
                        },
                        new
                        {
                            Id = 30,
                            IsCorrect = false,
                            QuestionId = 15,
                            Text = "Büyük Sel"
                        },
                        new
                        {
                            Id = 31,
                            IsCorrect = true,
                            QuestionId = 16,
                            Text = "Michael Jackson"
                        },
                        new
                        {
                            Id = 32,
                            IsCorrect = false,
                            QuestionId = 16,
                            Text = "Prince"
                        },
                        new
                        {
                            Id = 33,
                            IsCorrect = true,
                            QuestionId = 17,
                            Text = "Francis Ford Coppola"
                        },
                        new
                        {
                            Id = 34,
                            IsCorrect = false,
                            QuestionId = 17,
                            Text = "Steven Spielberg"
                        },
                        new
                        {
                            Id = 35,
                            IsCorrect = true,
                            QuestionId = 18,
                            Text = "Star Wars"
                        },
                        new
                        {
                            Id = 36,
                            IsCorrect = false,
                            QuestionId = 18,
                            Text = "Indiana Jones"
                        },
                        new
                        {
                            Id = 37,
                            IsCorrect = true,
                            QuestionId = 19,
                            Text = "Eiffel Kulesi"
                        },
                        new
                        {
                            Id = 38,
                            IsCorrect = false,
                            QuestionId = 19,
                            Text = "Kremlin Sarayı"
                        },
                        new
                        {
                            Id = 39,
                            IsCorrect = true,
                            QuestionId = 20,
                            Text = "İtalya"
                        },
                        new
                        {
                            Id = 40,
                            IsCorrect = false,
                            QuestionId = 20,
                            Text = "İspanya"
                        },
                        new
                        {
                            Id = 41,
                            IsCorrect = true,
                            QuestionId = 21,
                            Text = "Büyük Patlama"
                        },
                        new
                        {
                            Id = 42,
                            IsCorrect = false,
                            QuestionId = 21,
                            Text = "Büyük Sel"
                        },
                        new
                        {
                            Id = 43,
                            IsCorrect = true,
                            QuestionId = 22,
                            Text = "Pablo Picasso"
                        },
                        new
                        {
                            Id = 44,
                            IsCorrect = false,
                            QuestionId = 22,
                            Text = "Salvador Dali"
                        },
                        new
                        {
                            Id = 45,
                            IsCorrect = true,
                            QuestionId = 23,
                            Text = "Auguste Rodin"
                        },
                        new
                        {
                            Id = 46,
                            IsCorrect = false,
                            QuestionId = 23,
                            Text = "Michelangelo"
                        },
                        new
                        {
                            Id = 47,
                            IsCorrect = true,
                            QuestionId = 24,
                            Text = "George Orwell"
                        },
                        new
                        {
                            Id = 48,
                            IsCorrect = false,
                            QuestionId = 24,
                            Text = "Fyodor Dostoyevsky"
                        },
                        new
                        {
                            Id = 49,
                            IsCorrect = true,
                            QuestionId = 25,
                            Text = "Mark Twain"
                        },
                        new
                        {
                            Id = 50,
                            IsCorrect = false,
                            QuestionId = 25,
                            Text = "J.R.R. Tolkien"
                        },
                        new
                        {
                            Id = 51,
                            IsCorrect = true,
                            QuestionId = 26,
                            Text = "İtalya"
                        },
                        new
                        {
                            Id = 52,
                            IsCorrect = false,
                            QuestionId = 26,
                            Text = "Fransa"
                        },
                        new
                        {
                            Id = 53,
                            IsCorrect = true,
                            QuestionId = 27,
                            Text = "Tarçın"
                        },
                        new
                        {
                            Id = 54,
                            IsCorrect = false,
                            QuestionId = 27,
                            Text = "Kimyon"
                        },
                        new
                        {
                            Id = 55,
                            IsCorrect = true,
                            QuestionId = 28,
                            Text = "Elma"
                        },
                        new
                        {
                            Id = 56,
                            IsCorrect = false,
                            QuestionId = 28,
                            Text = "Armut"
                        },
                        new
                        {
                            Id = 57,
                            IsCorrect = true,
                            QuestionId = 29,
                            Text = "George Orwell"
                        },
                        new
                        {
                            Id = 58,
                            IsCorrect = false,
                            QuestionId = 29,
                            Text = "Fyodor Dostoyevsky"
                        },
                        new
                        {
                            Id = 59,
                            IsCorrect = true,
                            QuestionId = 30,
                            Text = "Jack London"
                        },
                        new
                        {
                            Id = 60,
                            IsCorrect = false,
                            QuestionId = 30,
                            Text = "Mark Twain"
                        });
                });

            modelBuilder.Entity("QuizApp.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bilim"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tarih"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Spor"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sanat"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Müzik"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Film"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Teknoloji"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Gezi"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Gastronomi"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Edebiyat"
                        });
                });

            modelBuilder.Entity("QuizApp.Domain.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            QuizId = 1,
                            Text = "Saatte kaç kez nefes alırız?"
                        },
                        new
                        {
                            Id = 2,
                            QuizId = 1,
                            Text = "Dünyanın en büyük okyanusu hangisidir?"
                        },
                        new
                        {
                            Id = 3,
                            QuizId = 1,
                            Text = "İlk insan hangi gezegende yürüdü?"
                        },
                        new
                        {
                            Id = 4,
                            QuizId = 2,
                            Text = "Hangi yıl Türkiye Cumhuriyeti kuruldu?"
                        },
                        new
                        {
                            Id = 5,
                            QuizId = 2,
                            Text = "Hangi yılda İstanbul'un fethi gerçekleşti?"
                        },
                        new
                        {
                            Id = 6,
                            QuizId = 2,
                            Text = "Osmanlı İmparatorluğu hangi yılda sona erdi?"
                        },
                        new
                        {
                            Id = 7,
                            QuizId = 3,
                            Text = "Hangi spor dalında gol atılmaz?"
                        },
                        new
                        {
                            Id = 8,
                            QuizId = 3,
                            Text = "FIFA'nın kuruluş yılı nedir?"
                        },
                        new
                        {
                            Id = 9,
                            QuizId = 3,
                            Text = "En uzun Grand Slam tenis maçı hangi turnuvada oynanmıştır?"
                        },
                        new
                        {
                            Id = 10,
                            QuizId = 4,
                            Text = "Mona Lisa tablosunun yaratıcısı kimdir?"
                        },
                        new
                        {
                            Id = 11,
                            QuizId = 4,
                            Text = "Hangi ressam, 'Yıldızlı Gece' adlı eseriyle ünlüdür?"
                        },
                        new
                        {
                            Id = 12,
                            QuizId = 4,
                            Text = "Hangi heykel, Özgürlük Heykeli olarak da bilinir?"
                        },
                        new
                        {
                            Id = 13,
                            QuizId = 5,
                            Text = "Hangi enstrüman tuşlu bir çalgıdır?"
                        },
                        new
                        {
                            Id = 14,
                            QuizId = 5,
                            Text = "Hangi müzik türü 17. yüzyılda ortaya çıkmıştır?"
                        },
                        new
                        {
                            Id = 15,
                            QuizId = 5,
                            Text = "Hangi şarkıcı, 'Thriller' albümünü çıkarmıştır?"
                        },
                        new
                        {
                            Id = 16,
                            QuizId = 6,
                            Text = "Hangi film, 'Hakuna Matata' şarkısıyla ünlüdür?"
                        },
                        new
                        {
                            Id = 17,
                            QuizId = 6,
                            Text = "Hangi yönetmen, 'The Godfather' serisini yönetmiştir?"
                        },
                        new
                        {
                            Id = 18,
                            QuizId = 6,
                            Text = "Hangi film, 'May the Force be with you' repliğiyle ünlüdür?"
                        },
                        new
                        {
                            Id = 19,
                            QuizId = 7,
                            Text = "Hangi şirket, iPhone'u geliştirmiştir?"
                        },
                        new
                        {
                            Id = 20,
                            QuizId = 7,
                            Text = "Hangi programlama dili, web geliştirmede kullanılır?"
                        },
                        new
                        {
                            Id = 21,
                            QuizId = 7,
                            Text = "Hangi buluş, elektrikli lambayı icat etmiştir?"
                        },
                        new
                        {
                            Id = 22,
                            QuizId = 8,
                            Text = "Hangi şehir, Eyfel Kulesi'ne ev sahipliği yapar?"
                        },
                        new
                        {
                            Id = 23,
                            QuizId = 8,
                            Text = "Hangi ülke, Ayasofya Camii'ne ev sahipliği yapar?"
                        },
                        new
                        {
                            Id = 24,
                            QuizId = 8,
                            Text = "Hangi şehir, Büyük Patlama'ya ev sahipliği yapmıştır?"
                        },
                        new
                        {
                            Id = 25,
                            QuizId = 9,
                            Text = "Hangi ülke, pizza'nın doğum yeri olarak bilinir?"
                        },
                        new
                        {
                            Id = 26,
                            QuizId = 9,
                            Text = "Hangi baharat, en çok kullanılan baharatlardan biridir?"
                        },
                        new
                        {
                            Id = 27,
                            QuizId = 9,
                            Text = "Hangi meyve, 'Dünya'nın elması' olarak bilinir?"
                        },
                        new
                        {
                            Id = 28,
                            QuizId = 10,
                            Text = "Hangi yazar, '1984' romanını yazmıştır?"
                        },
                        new
                        {
                            Id = 29,
                            QuizId = 10,
                            Text = "Hangi yazar, 'Anna Karenina' romanını yazmıştır?"
                        },
                        new
                        {
                            Id = 30,
                            QuizId = 10,
                            Text = "Hangi yazar, 'Beyaz Diş' romanını yazmıştır?"
                        });
                });

            modelBuilder.Entity("QuizApp.Domain.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Quizzes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bilimle ilgili genel kültür soruları",
                            Name = "Bilim Quiz"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Tarihle ilgili genel kültür soruları",
                            Name = "Tarih Quiz"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sporla ilgili genel kültür soruları",
                            Name = "Spor Quiz"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sanatla ilgili genel kültür soruları",
                            Name = "Sanat Quiz"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Müzikle ilgili genel kültür soruları",
                            Name = "Müzik Quiz"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 6,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Filmle ilgili genel kültür soruları",
                            Name = "Film Quiz"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 7,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Teknolojiyle ilgili genel kültür soruları",
                            Name = "Teknoloji Quiz"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 8,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Gezi ve seyahatle ilgili genel kültür soruları",
                            Name = "Gezi Quiz"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 9,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Gastronomiyle ilgili genel kültür soruları",
                            Name = "Gastronomi Quiz"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 10,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Edebiyatla ilgili genel kültür soruları",
                            Name = "Edebiyat Quiz"
                        });
                });

            modelBuilder.Entity("QuizApp.Domain.Answer", b =>
                {
                    b.HasOne("QuizApp.Domain.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuizApp.Domain.Question", b =>
                {
                    b.HasOne("QuizApp.Domain.Quiz", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("QuizApp.Domain.Quiz", b =>
                {
                    b.HasOne("QuizApp.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("QuizApp.Domain.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("QuizApp.Domain.Quiz", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
