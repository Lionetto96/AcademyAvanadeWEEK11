using GestioneOrdini_CORE.Interfaces;
using GestioneOrdini_CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestioneOrdini_Mock.RepositoriesMock
{
    public class MockRepoOrdine : IOrdineRepository
        
    {
        private List<Ordine> _ordini = new List<Ordine>()
        {
            new Ordine()
            {
                Id=1,
                DataOrdine=new DateTime(2022,01,30),
                CodiceOrdine="CO001",
                CodiceProdotto="CP001",
                Importo=189,
                IdCliente=1
            },
             new Ordine()
            {
                Id=2,
                DataOrdine=new DateTime(2022,01,28),
                CodiceOrdine="CO002",
                CodiceProdotto="CP002",
                Importo=189,
                IdCliente=2
            }
        };
        public bool Add(Ordine entity)
        {
            var exist = _ordini.Exists(c => c.Id == entity.Id);
            if (exist)
                throw new Exception($"Order with id {entity.Id} alredy exist");
            _ordini.Add(entity);
            return true;
        }

        public bool Delete(Ordine entity)
        {
            var exist = _ordini.Exists(c => c.Id == entity.Id);
            if (!exist)
                throw new Exception($"Order with id {entity.Id} not exist");
            _ordini.Remove(entity);
            return true;
        }

        public IEnumerable<Ordine> GetAll()
        {
            return _ordini;
        }

        public Ordine GetOrdineById(int id)
        {
            return _ordini.SingleOrDefault(o => o.Id == id);
        }

        public IEnumerable<Ordine> GetOrdiniByIdCliente(int idCliente)
        {
            return (IEnumerable<Ordine>)_ordini.SingleOrDefault(_ordini=>_ordini.IdCliente == idCliente);
        }

        public bool Update(Ordine entity)
        {
            var exist = _ordini.Exists(c => c.Id == entity.Id);
            if (!exist)
                throw new Exception($"Order with id {entity.Id} not exist");

            entity.Importo = 160;
            return true;
        }
    }
}
