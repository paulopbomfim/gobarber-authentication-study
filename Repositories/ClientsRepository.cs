using GoBarber.Data;
using GoBarber.Models;

namespace GoBarber.Repositories;

public class ClientsRepository : IClientsRepository
{
    private readonly ApplicationDataContext _context;

    public ClientsRepository(ApplicationDataContext context)
    {
        this._context = context;
    }

    public Client Create(Client client)
    {
        var entry = _context.Clients.Add(client);
        _context.SaveChanges();
        return entry.Entity;
    }
}