using Pacagroup.Comercial.Creditos.Dominio;
using System;
using System.Collections.Generic;

namespace Pacagroup.Comercial.Creditos.Fachada
{
    public class ClienteFachada:IDisposable
    {
        public Cliente ObtenerCliente(string NumeroDocumento)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ListarCliente()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);  
        }
    }
}
