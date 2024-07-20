using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibreria_BE;

namespace WebLibreria_ADO
{
    public class Renta_ADO
    {
        public List<RentaLibro_BE> FiltrarLibrosRentados(int? genId, int? autId, DateTime fecIn, DateTime fecEn)
        {
            try
            {
                dbLibreriaEntities librosRentados = new dbLibreriaEntities();
                List<RentaLibro_BE> renta_BEs = new List<RentaLibro_BE>();

                var query = librosRentados.usp_FiltrarLibrosxPeriodo(genId, autId, fecIn, fecEn);

                foreach (var resultdos in query)
                {
                    RentaLibro_BE objRentaBE = new RentaLibro_BE
                    {
                        lib_id = Convert.ToInt16(resultdos.lib_id),
                        lib_nom = resultdos.lib_nom,
                        autor = resultdos.autor,
                        gen_desc = resultdos.gen_desc,
                        rent_count = Convert.ToInt16(resultdos.rent_count)
                    };

                    renta_BEs.Add(objRentaBE);
                }
                return renta_BEs;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RentaMensual_BE> ListarRentaMensual()
        {
            try
            {
                dbLibreriaEntities dbLibreriaEntities = new dbLibreriaEntities();
                List<RentaMensual_BE> rentas = new List<RentaMensual_BE>();

                var query = dbLibreriaEntities.usp_RentasMensuales();

                foreach (var reporte in query)
                {
                    RentaMensual_BE objRenta = new RentaMensual_BE
                    {
                        Mes = Convert.ToInt16(reporte.Mes),
                        Rentas = Convert.ToInt16(reporte.Rentas)
                    };

                    rentas.Add(objRenta);
                }

                return rentas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RentaxGenero_BE> ListarRentaxGenero()
        {
            try
            {
                dbLibreriaEntities dbLibreriaEntities = new dbLibreriaEntities();
                List<RentaxGenero_BE> rentas = new List<RentaxGenero_BE>();

                var query = dbLibreriaEntities.usp_RentasxGenero();

                foreach (var reporte in query)
                {
                    RentaxGenero_BE obj = new RentaxGenero_BE
                    {
                        genero = reporte.Genero,
                        porcentaje = (decimal)reporte.Porcentaje
                    };
                    rentas.Add(obj);
                }
                return rentas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
