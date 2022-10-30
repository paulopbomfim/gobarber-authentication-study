using Microsoft.EntityFrameworkCore;

using GoBarber.Models;

namespace GoBarber.Data;

public interface IApplicationDataContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Barber> Barbers { get; set; }
    public int SaveChanges();
}