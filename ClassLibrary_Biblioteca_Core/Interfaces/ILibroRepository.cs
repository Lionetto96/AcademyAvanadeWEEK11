using ClassLibrary_Biblioteca_Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Biblioteca_Core.Interfaces
{
    public interface ILibroRepository : IRepository<Libro1>
    {
        
        Libro1 GetByIsbn(string isbn);
    }
}
