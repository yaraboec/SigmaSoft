using Project_Sigma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Sigma.Interface
{
    public interface IClient
    {
        List<Client> GetAllClients();
        void InsertClient(Client client);
        void UpdateClient(Client client);
        void DeleteClient(Client client);
        Client GetById(int id);
        void Save();
    }
}
