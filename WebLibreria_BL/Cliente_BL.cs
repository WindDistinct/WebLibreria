using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibreria_ADO;
using WebLibreria_BE;

namespace WebLibreria_BL
{
    public class Cliente_BL
    {
        Cliente_ADO cliente_ADO = new Cliente_ADO();
        public List<Cliente_BE> ListarClientes()
        {
            return cliente_ADO.ListarClientes();
        }
        public List<Cliente_BE> FiltrarClientes (bool isNull)
        {
            return cliente_ADO.FiltrarClientes(isNull);
        }
    }
}
