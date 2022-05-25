using GestioneOrdini_CORE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneOrdini_CORE.Interfaces
{
    //
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente GetClienteByCode (string codiceCliente);
        Cliente GetClienteById(int id);
    }
}
