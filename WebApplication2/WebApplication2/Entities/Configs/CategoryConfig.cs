using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Models;


namespace WebApplication2.Entities.Configs
{
    internal sealed class CategoryConfig : IEntityTypeConfiguration<CategoryModel>
    {
        public void Configure(EntityTypeBuilder<CategoryModel> entity)
        {
            entity.ToTable(nameof(CategoryModel));

            entity.HasKey(x => x.CategoryId);
            entity.Property(x => x.CategoryId).ValueGeneratedNever();

            entity.Property(x => x.CategoryName).IsRequired().HasMaxLength(64);
            
        }
    }
}