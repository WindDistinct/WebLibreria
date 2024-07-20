using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibreria_ADO;
using WebLibreria_BE;

namespace WebLibreria_BL
{
    public class Genero_BL
    {
        Genero_ADO genero_ADO = new Genero_ADO();

        public List<Genero_BE> listarGenero()
        {
            return genero_ADO.listarGenero();
        }
    }
}
