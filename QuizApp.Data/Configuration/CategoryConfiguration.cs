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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories"); // Tablo adını belirtmek için kullanılır
            builder.HasKey(c => c.Id); // Primary key olarak Id özelliğini kullanır

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasData(
           new Category { Id = 1, Name = "Bilim" },
           new Category { Id = 2, Name = "Tarih" },
           new Category { Id = 3, Name = "Spor" },
           new Category { Id = 4, Name = "Sanat" },
           new Category { Id = 5, Name = "Müzik" },
           new Category { Id = 6, Name = "Film" },
           new Category { Id = 7, Name = "Teknoloji" },
           new Category { Id = 8, Name = "Gezi" },
           new Category { Id = 9, Name = "Gastronomi" },
           new Category { Id = 10, Name = "Edebiyat" }
       );
        }
    }
}
