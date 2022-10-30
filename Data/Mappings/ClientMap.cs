using GoBarber.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoBarber.Data.Mapping;

public class ClientMap : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("Clients");

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
        builder.Property(x => x.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETDATE()");
        builder.Property(x => x.UpdatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETDATE()");

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(320);
        
        builder.HasIndex(x => x.Email, "IX_User_Email").IsUnique();
    }
}