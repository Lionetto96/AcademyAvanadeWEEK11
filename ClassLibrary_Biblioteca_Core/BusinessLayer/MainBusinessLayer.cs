using ClassLibrary_Biblioteca_Core.Entities;
using ClassLibrary_Biblioteca_Core.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary_Biblioteca_Core.BusinessLayer
{
    public class MainBusinessLayer : IMainBusinessLayer
    {
        private ILibroRepository _libroRepository;
        private IPrestitoRepository _prestitoRepository;

        //iniettiamo la dipendenza con Ninject
        public MainBusinessLayer()
        {
            _libroRepository = DependenciesCointainer2.Resolve<ILibroRepository>();
            _prestitoRepository= DependenciesCointainer2.Resolve<IPrestitoRepository>();
        }
        //specifico quale Repo  utilizzare
        public MainBusinessLayer(ILibroRepository repo, IPrestitoRepository repo2)
        {
            _libroRepository = repo;
            _prestitoRepository = repo2;

        }
        
        public bool AddNewLibro(Libro1 libro)
        {
            if (libro == null)
                return false;
            return _libroRepository.Add(libro);
        }

       

     

        public bool DeleteLibroById(int id)
        {
            if (id <= 0)
                return false;

            Libro1 bookToBeDeleted = _libroRepository.GetById(id);

            if (bookToBeDeleted != null)
                return _libroRepository.Delete(bookToBeDeleted);

            return false;
        }

       

        public IEnumerable<Libro1> GetAllLibri(Func<Libro1, bool> filter = null)
        {
            if (filter != null)
                return _libroRepository.Fetch().Where(filter);

            return _libroRepository.Fetch();
        }

       

        public Libro1 GetLibroById(int id)
        {
            if(id <= 0)
                return null;
            return _libroRepository.GetById(id);
        }

        public Libro1 GetLibroByIsbn(string isbn)
        {
            if(string.IsNullOrEmpty(isbn))
                return null;
            return _libroRepository.GetByIsbn(isbn);
        }

        public Prestito GetPrestitoById(int id)
        {
            if (id <= 0)
                return null;
            return _prestitoRepository.GetById(id);
        }

        public bool LoanBook(int idLibro, string utente)
        {
            if (string.IsNullOrWhiteSpace(utente))
                return false;

            var lentBook = _libroRepository.GetById(idLibro);

            if (lentBook == null)
                return false;

            // TODO check se il libro è disponibile

            return _prestitoRepository.Add(new Prestito()
            {
                Libro = lentBook,
                DataPrestito = DateTime.Now,
                Utente = utente
            });
        }

        public bool ReturnBook(int idLibro)
        {
            if(idLibro <= 0)
                return false;
            Libro1 prestitoLibro=_libroRepository.GetById(idLibro);

            if (prestitoLibro == null)
                return false;
            var prestito = prestitoLibro.Prestiti.SingleOrDefault(p => p.DataReso == null);
            
            if (prestito == null)
                return false;
            prestito.DataReso = DateTime.Now;
            return _prestitoRepository.Update(prestito);

        }

        public bool UpdateLibro(Libro1 libro)
        {
            if (libro == null)
                return false;
            return _libroRepository.Update(libro);
        }

        
    }
}
