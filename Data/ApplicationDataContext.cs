using Microsoft.EntityFrameworkCore;

using GoBarber.Models;
using GoBarber.Data.Mapping;

namespace GoBarber.Data;

public class ApplicationDataContext : DbContext, IApplicationDataContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var connectionString = Environment.GetEnvironmentVariable("SQLSERVER_CONNECTION_STRING");

        if (connectionString == null)
        {
            throw new Exception("Connection string not found");
        }

        options.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserMap());
    }
}