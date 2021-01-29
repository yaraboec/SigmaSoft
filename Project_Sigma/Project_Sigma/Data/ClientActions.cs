using Project_Sigma.Interface;
using Project_Sigma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Sigma.Data
{
    public class ClientActions : IClient
    {
        private readonly ProjectSigmaContext _context;

        public ClientActions(ProjectSigmaContext context)
        {
            _context = context;
        }

        public void DeleteClient(Client client)
        {
            _context.Clients.Remove(client);
        }

        public List<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }

        public void InsertClient(Client client)
        {
            _context.Clients.Add(client);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateClient(Client client)
        {
            _context.Clients.Update(client);
        }
        public Client GetById(int id)
        {
            return _context.Clients.Where(e => e.IdClient == id).FirstOrDefault();
        }
    }
}
