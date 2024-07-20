using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibreria_ADO;
using WebLibreria_BE;

namespace WebLibreria_BL
{
    public class Renta_BL
    {
        Renta_ADO objRenta_ADO = new Renta_ADO();

        public List<RentaLibro_BE> FiltrarLibrosRentados(int? genId, int? autId, DateTime fecIn, DateTime fecEn)
        {
            return objRenta_ADO.FiltrarLibrosRentados(genId, autId, fecIn, fecEn);
        }

        public List<RentaMensual_BE> ListarRentaMensual()
        {
            return objRenta_ADO.ListarRentaMensual();
        }

        public List<RentaxGenero_BE> ListarRentaxGenero()
        {
            return objRenta_ADO.ListarRentaxGenero();
        }
    }
}
