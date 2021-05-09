using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Models;

namespace WebApplication2.Entities.Configs
{
    internal sealed class BookConfig: IEntityTypeConfiguration<BookModel>
    {
        public void Configure(EntityTypeBuilder<BookModel> entity)
        {
            entity.ToTable(nameof(BookModel));

            entity.HasKey(x => x.BookId);
            entity.Property(x => x.BookId).ValueGeneratedNever();

            entity.Property(x => x.Title).IsRequired().HasMaxLength(128);
            entity.Property(x => x.Author).IsRequired().HasMaxLength(128);
            entity.Property(x => x.Category).IsRequired().HasMaxLength(128);
            entity.Property(x => x.Language).IsRequired().HasMaxLength(128);
            entity.Property(x => x.Cover).IsRequired().HasMaxLength(1024);

            entity.Property(x => x.PublicationDate).HasColumnType("date");
        }
    }
}