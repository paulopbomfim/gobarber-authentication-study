using GoBarber.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoBarber.Data.Mapping;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
        
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x => x.Password)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x => x.Role)
            .IsRequired()
            .HasMaxLength(6);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(320);
        
        builder.HasIndex(x => x.Email, "IX_User_Email").IsUnique();
    }
}