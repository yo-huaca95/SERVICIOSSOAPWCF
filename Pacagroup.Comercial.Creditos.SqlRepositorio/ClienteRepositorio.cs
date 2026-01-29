using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;

namespace Pacagroup.Comercial.Creditos.SqlRepositorio
{
    public class ClienteRepositorio: IClienteRepositorio
    {
        public Cliente ObtenerCliente(string NumeroDocumento)
        {
            using (IDbConnection conexion = new MySqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("p_numero_documento", NumeroDocumento);

                var cliente = conexion.QuerySingleOrDefault<Cliente>(
                    "sp_obtener_cliente_por_documento", 
                    param: parametros, 
                    commandType: CommandType.StoredProcedure);
                
                return cliente;
            }
        }

        public IEnumerable<Cliente> ListarCliente()
        {
            using (IDbConnection conexion = new MySqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();

                var clientes = conexion.Query<Cliente>(
                    "sp_obtener_clientes",
                    commandType: CommandType.StoredProcedure);

                return clientes;
            }
        }

    }
}
