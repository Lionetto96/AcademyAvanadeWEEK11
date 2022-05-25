using ClassLibrary_Biblioteca_Core.Entities;
using ClassLibrary_Biblioteca_Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary_Biblioteca_Mock.Repositories
{
    public class MockLibroRepository : ILibroRepository
    {
        private List<Libro1> _libri = new List<Libro1>()
        {
            new Libro1
            {
                Id = 1,
                ISBN ="1234567890123",
                Titolo ="I promessi sposi",
                Sommario ="\n introduzione    13 " +
                "\n capitolo 1      21"+
                "\n capitolo 2      35",
                Autore="Alessandro Manzoni"

            },
            new Libro1
            {
                Id=2,
                ISBN ="1234567890166",
                Titolo ="L'amica geniale",
                Sommario ="\n introduzione    5 " +
                "\n capitolo 1      20"+
                "\n capitolo 2      42",
                Autore="Elena Ferrante"
            },
            new Libro1
            {
                Id=3,
                ISBN ="1234567890155",
                Titolo ="E' tutta vita",
                Sommario ="\n introduzione    8 " +
                "\n capitolo 1      18"+
                "\n capitolo 2      38",
                Autore="Fabio Volo"
            },
            new Libro1
            {
                Id=4,
                ISBN ="1234567890144",
                Titolo ="Gomorra",
                Sommario ="\n introduzione    10 " +
                "\n capitolo 1      22"+
                "\n capitolo 2      51",
                Autore="Roberto Saviano"
            },



        };
        public bool Add(Libro1 newItem)
        {
            var exists = _libri.Exists(l => l.ISBN== newItem.ISBN);
            if (exists)
                throw new Exception($"Book with isbn {newItem.ISBN} alredy exist");
            _libri.Add(newItem);
            return true;
        }

        public bool Delete(Libro1 deleteItem)
        {
            if(_libri.Contains(deleteItem))
                _libri.Remove(deleteItem);
                

            return false;
        }

        

     

        public IEnumerable<Libro1> Fetch(Func<Libro1, bool> filter = null)
        {
            if (filter == null)
                return _libri;
            return _libri.Where(filter);
        }

        public Libro1 GetById(int id)
        {
            return _libri.SingleOrDefault(l=>l.Id == id);
        }

        public Libro1 GetByIsbn(string isbn)
        {
            return _libri.SingleOrDefault(l=>l.ISBN== isbn);
        }

        public Libro1 GetLibroByTitolo(string titolo)
        {
            return _libri.SingleOrDefault(l => l.Titolo == titolo);
        }

        public bool Update(Libro1 updateItem)
        {
            var exists = _libri.Exists(l => l.ISBN == updateItem.ISBN);
            if (exists)
            {
                updateItem.Autore = "nuovo autore";
                
                return true;
            }
            return false;
            
        }
    }
}
