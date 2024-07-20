using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibreria_ADO;
using WebLibreria_BE;

namespace WebLibreria_BL
{
    public class Autor_BL
    {
        Autor_ADO objAutorADO = new Autor_ADO();

        public List<Autor_BE> listarAutor()
        {
            return objAutorADO.listarAutor();
        }
    }
}
