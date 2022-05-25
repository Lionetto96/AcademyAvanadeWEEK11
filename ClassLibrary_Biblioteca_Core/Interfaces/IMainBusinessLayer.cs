using ClassLibrary_Biblioteca_Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Biblioteca_Core.Interfaces
{
    public interface IMainBusinessLayer
    {
        IEnumerable<Libro1> GetAllLibri(Func<Libro1, bool> filter = null);

        Libro1 GetLibroByIsbn(string isbn);
        Libro1 GetLibroById(int id);
        bool AddNewLibro(Libro1 libro);
        bool DeleteLibroById(int id);
        bool UpdateLibro(Libro1 libro);

        Prestito GetPrestitoById(int id);
        bool LoanBook(int idLibro,string utente);
        bool ReturnBook(int idLibro);
        

        
    }
}
