using Microsoft.EntityFrameworkCore;

using GoBarber.Models;

namespace GoBarber.Data;

public interface IApplicationDataContext
{
    public DbSet<User> Users { get; set; }
    public int SaveChanges();
}