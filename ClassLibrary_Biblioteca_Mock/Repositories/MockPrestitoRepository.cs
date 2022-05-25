using ClassLibrary_Biblioteca_Core.Entities;
using ClassLibrary_Biblioteca_Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary_Biblioteca_Mock.Repositories
{
    public class MockPrestitoRepository : IPrestitoRepository
    {
        private List<Prestito> _prestiti = new List<Prestito>()
        {
            new Prestito
            {
                Libro =new Libro1 
                {
                    Id =1,
                    ISBN="12354678190235",
                    Titolo="Titolo 1",
                    Autore="Autore 1",
                    Sommario="Sommario 1"
                },
                Id = 1,
                IdLibro = 1,
                Utente = "ALESSIA",
                DataPrestito= new DateTime(2022,01,30),
                DataReso=new DateTime(2022,02,07)

            }
        };
        public bool Add(Prestito newItem)
        {
            var exists = _prestiti.Exists(p => p.Id == newItem.Id);
            if (exists)
                throw new Exception($"prestito with id {newItem.Id} alredy exist");
            _prestiti.Add(newItem);
            return true;
        }

        

        public bool Delete(Prestito deleteItem)
        {
            if(_prestiti.Contains(deleteItem))
                _prestiti.Remove(deleteItem);
                
            return false;
        }

        public IEnumerable<Prestito> Fetch(Func<Prestito, bool> filter = null)
        {
            if (filter == null)
                return _prestiti;
            return _prestiti.Where(filter);
        }

        

        public Prestito GetById(int id)
        {
            return _prestiti.SingleOrDefault(l => l.Id == id);
        }

        public bool Update(Prestito updateItem)
        {
            var exists = _prestiti.Exists(p => p.Id == updateItem.Id);
            if (exists)
                updateItem.DataReso=DateTime.Now;
             
            return false;
        }
    }
}
