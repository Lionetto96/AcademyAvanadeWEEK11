using GestioneOrdini_CORE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneOrdini_CORE.Interfaces
{
    public interface IOrdineRepository : IRepository<Ordine>
    {
        //
        IEnumerable<Ordine> GetOrdiniByIdCliente(int idCliente);
        Ordine GetOrdineById(int id);
    }
}
