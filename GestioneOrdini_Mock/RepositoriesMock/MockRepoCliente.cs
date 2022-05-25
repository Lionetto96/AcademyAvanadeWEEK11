using GestioneOrdini_CORE.Interfaces;
using GestioneOrdini_CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestioneOrdini_Mock.RepositoriesMock
{
    public class MockRepoCliente : IClienteRepository
    {
        private List<Cliente> _clienteList = new List<Cliente>()
        {
            new Cliente()
            {
                Id = 1,
                CodiceCliente ="C001",
                Nome ="alessia",
                Cognome="Lionetto"
            },
            new Cliente()
            {
                Id=2,
                CodiceCliente ="C002",
                Nome="piero",
                Cognome="rossi"
            }
        };
        public bool Add(Cliente entity)
        {
            var exist=_clienteList.Exists(c=>c.Id == entity.Id);
            if(exist)
                throw new Exception($"Customer with id {entity.Id} alredy exist");
            _clienteList.Add(entity);
            return true;
        }

        public bool Delete(Cliente entity)
        {
            var exist = _clienteList.Exists(c => c.Id == entity.Id);
            if (!exist)
                throw new Exception($"Customer with id {entity.Id} not exist");
            _clienteList.Remove(entity);
            return true;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _clienteList;
        }

        public Cliente GetClienteByCode(string codiceCliente)
        {
            return _clienteList.SingleOrDefault(c=>c.CodiceCliente==codiceCliente);
           
        }

        public Cliente GetClienteById(int id)
        {
            return _clienteList.SingleOrDefault(c => c.Id == id);
        }

        public bool Update(Cliente entity)
        {
            var exist = _clienteList.Exists(c => c.Id == entity.Id);
            if (!exist)
                throw new Exception($"Customer with id {entity.Id} not exist");
            var upC=_clienteList.SingleOrDefault(c=>c.Id == entity.Id);
            if (upC != null)
            {
                upC.Nome =entity.Nome;
            }
            
            return true;
        }
    }
}
