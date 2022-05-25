using GestioneOrdini_CORE.Interfaces;
using GestioneOrdini_CORE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneOrdini_CORE.BusinessLayer
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IClienteRepository _clienteRepo;
        private readonly IOrdineRepository _ordineRepo;
        public BusinessLayer(IClienteRepository repoC, IOrdineRepository repoO)
        {
            _clienteRepo = repoC;
            _ordineRepo = repoO;
        }
        //costruttore con collegamento alle  dipendenze 
        public BusinessLayer()
        {
            _clienteRepo=DependenciesCointainer3.Resolve<IClienteRepository>();
            _ordineRepo=DependenciesCointainer3.Resolve<IOrdineRepository>();

        }
        public bool AddCliente(Cliente newCliente)
        {
            if(newCliente == null)
                return false;
            return _clienteRepo.Add(newCliente);
        }

        public bool AddOrdine(Ordine newOrdine)
        {
            if(newOrdine == null)
                return false ;
            return _ordineRepo.Add(newOrdine);
        }

        public IEnumerable<Cliente> GetAllClienti()
        {
            return _clienteRepo.GetAll();
        }

        public IEnumerable<Ordine> GetAllOrdini()
        {
            return _ordineRepo.GetAll();
        }

        public IEnumerable<Ordine> GetAllOrdiniByCliente(int idCliente)
        {
            
            if (idCliente <= 0)
                return null;
            return _ordineRepo.GetOrdiniByIdCliente(idCliente);


        }

        public Cliente GetClienteByCode(string codiceCliente)
        {
            if(string.IsNullOrEmpty(codiceCliente))
                return null;
            return _clienteRepo.GetClienteByCode(codiceCliente);
        }

        public Cliente GetClienteById(int id)
        {
            if (id <= 0)
                throw new ArgumentException($"id non valido");
            return _clienteRepo.GetClienteById(id);
        }

        public Ordine GetOrdineById(int id)
        {
            if (id <= 0)
                throw new ArgumentException($"id non valido");
            return _ordineRepo.GetOrdineById(id);
        }

        public bool RemoveCliente(Cliente cliente)
        {
            if(cliente == null)
                return false;
            return _clienteRepo.Delete(cliente);
        }

        public bool RemoveOrdine(Ordine ordine)
        {
            if(ordine == null)
                return false ;
            return _ordineRepo.Delete(ordine);
        }

        public bool UpdateCliente(Cliente cliente)
        {
            if(cliente==null)
                return false;
            return _clienteRepo.Update(cliente);
        }

        public bool UpdateOrdine(Ordine ordine)
        {
            if(ordine==null)
                return false;
            return _ordineRepo.Update(ordine);
        }
    }
}
