using Pacagroup.Comercial.Creditos.Dominio;
using System.Collections.Generic;

namespace Pacagroup.Comercial.Creditos.ContratoRepositorio
{
    public interface IClienteRepositorio
    {
        Cliente ObtenerCliente(string NumeroDocumento);

        IEnumerable<Cliente> ListarCliente();
    }
}
