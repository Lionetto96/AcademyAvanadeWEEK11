using GestioneOrdini_CORE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneOrdini_CORE.BusinessLayer
{
    public interface IBusinessLayer
    {
        #region Cliente
        //OPERAZIONI Cliente
        bool AddCliente(Cliente newCliente);
        bool RemoveCliente(Cliente cliente);
        bool UpdateCliente(Cliente cliente);
        Cliente GetClienteById(int id);
        Cliente GetClienteByCode(string codiceCliente);
        IEnumerable<Cliente> GetAllClienti();
        #endregion
        #region Ordine
        //Operazioni Ordine 
        bool AddOrdine(Ordine newOrdine);
        bool RemoveOrdine(Ordine ordine);
        bool UpdateOrdine(Ordine clienordinete);
        Ordine GetOrdineById(int id);
        IEnumerable<Ordine> GetAllOrdiniByCliente(int idCliente);
        
        IEnumerable<Ordine> GetAllOrdini();

        #endregion
    }
}
