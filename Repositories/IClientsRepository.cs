using GoBarber.Models;

namespace GoBarber.Repositories;

public interface IClientsRepository
{
    public Client Create(Client client);
}