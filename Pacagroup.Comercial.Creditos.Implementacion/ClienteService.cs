using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.Fachada;
using System;
using System.Collections.Generic;

namespace Pacagroup.Comercial.Creditos.Implementacion
{
    public class ClienteService:IClienteService
    {
        public Cliente ObtenerCliente(string NumeroDocumento)
        {
            using (ClienteFachada instancia= new ClienteFachada())
            {
                return instancia.ObtenerCliente(NumeroDocumento);
            }
        }

        public IEnumerable<Cliente> ListarCliente()
        {
           using (ClienteFachada instancia = new ClienteFachada())
            {
                return instancia.ListarCliente();
            }
        }
    }
}