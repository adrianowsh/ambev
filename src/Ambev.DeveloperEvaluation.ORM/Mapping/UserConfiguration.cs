using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

        builder.Property(u => u.FirstName).IsRequired().HasMaxLength(100);
        builder.Property(u => u.LastName).IsRequired().HasMaxLength(100);

        builder.Property(u => u.Username).IsRequired().HasMaxLength(50);
        builder.Property(u => u.Password).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Phone).HasMaxLength(20);

        builder.Property(u => u.Status)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(u => u.Role)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.OwnsOne(address => address.Address, addressBuilder =>
        {
            addressBuilder.Property(a => a.City).HasMaxLength(50).HasColumnName("city");
            addressBuilder.Property(a => a.Street).HasMaxLength(100).HasColumnName("street");
            addressBuilder.Property(a => a.Number).HasColumnName("number");
            addressBuilder.Property(a => a.ZipCode).HasMaxLength(10).HasColumnName("zip_code");
            addressBuilder.Property(a => a.Lat).HasMaxLength(20).HasColumnName("latitude");
            addressBuilder.Property(a => a.Long).HasMaxLength(20).HasColumnName("longitude");
        });

        builder.Property(u => u.IdentityId)
            .HasConversion<string>()
            .HasMaxLength(500);

        builder.HasIndex(u => u.Email).IsUnique();

        builder.HasIndex(u => u.IdentityId).IsUnique();
    }
}
