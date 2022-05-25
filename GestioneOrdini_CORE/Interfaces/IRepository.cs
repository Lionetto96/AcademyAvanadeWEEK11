using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneOrdini_CORE.Interfaces
{
    //
    public interface IRepository<T>
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IEnumerable<T> GetAll();
    }
}
