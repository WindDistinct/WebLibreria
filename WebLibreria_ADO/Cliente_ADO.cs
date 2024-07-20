using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibreria_BE;

namespace WebLibreria_ADO
{
    public class Cliente_ADO
    {
        public List<Cliente_BE> ListarClientes ()
        {
            try
            {
                dbLibreriaEntities dbLibreriaEntities = new dbLibreriaEntities();
                List<Cliente_BE> clientes = new List<Cliente_BE>();

                var query = dbLibreriaEntities.usp_ListarClienteSimple();

                foreach (var resultado in query)
                {
                    Cliente_BE cliente = new Cliente_BE
                    {
                        cli_id = (short)resultado.Id,
                        cliente = resultado.cliente,
                        cli_tel = resultado.Telefono,
                        cli_mail = resultado.Correo,
                        cli_memb_tipo = resultado.Tipo_Membresia.HasValue ? (short?)resultado.Tipo_Membresia.Value : null,
                        cli_memb_cad = resultado.Caducidad.HasValue ? (DateTime?)resultado.Caducidad.Value : null 
                    };
                    clientes.Add(cliente);
                }
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Cliente_BE> FiltrarClientes(bool isNull)
        {
            try
            {
                dbLibreriaEntities dbLibreriaEntities = new dbLibreriaEntities();
                List<Cliente_BE> clientes = new List<Cliente_BE>();

                var query = dbLibreriaEntities.usp_FiltrarClientes(isNull);

                foreach (var resultado in query)
                {
                    Cliente_BE cliente = new Cliente_BE
                    {
                        cli_id = (short)resultado.cli_id,
                        cliente = resultado.cliente,
                        cli_tel = resultado.cli_tel,
                        cli_mail = resultado.cli_mail,
                        cli_memb_tipo = resultado.cli_memb_tipo.HasValue ? (short?)resultado.cli_memb_tipo.Value : null,
                        cli_memb_cad = resultado.cli_memb_cad.HasValue ? (DateTime?)resultado.cli_memb_cad.Value : null
                    };
                    clientes.Add(cliente);
                }
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
