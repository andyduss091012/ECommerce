using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Data;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder) {
        builder.ToTable("Products");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
               .HasColumnType("varchar(50)")
               .IsRequired();

        builder.Property(p => p.IsActive)
               .HasColumnType("bit")
               .HasDefaultValue(true);

        builder.Property(p => p.Name)
               .HasMaxLength(200)
               .IsRequired(false);

        builder.Property(p => p.Price)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.Property(p => p.Stock)
               .HasColumnType("int")
               .HasDefaultValue(0);

        builder.Property(p => p.CreatedAt)
               .HasColumnType("datetime2")
               .HasDefaultValueSql("GETDATE()");

        builder.Property(p => p.CategoryId)
               .HasColumnType("varchar(50)")
               .IsRequired();

        builder.HasOne(p => p.Category)
               .WithMany(c => c.Products)
               .HasForeignKey(p => p.CategoryId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
