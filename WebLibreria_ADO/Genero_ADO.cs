using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibreria_BE;

namespace WebLibreria_ADO
{
    public class Genero_ADO
    {
        public List<Genero_BE> listarGenero()
        {
            try
            {
                dbLibreriaEntities entidades = new dbLibreriaEntities();
                List<Genero_BE> generos = new List<Genero_BE>();

                var query = (from miGenero in entidades.tb_Genero
                             select new Genero_BE
                             {
                                 gen_id = (short)miGenero.gen_id,
                                 gen_desc = miGenero.gen_desc,
                             }).ToList();

                foreach (var genero in query)
                {
                    Genero_BE genero_BE = new Genero_BE();
                    genero_BE.gen_id = genero.gen_id;
                    genero_BE.gen_desc = genero.gen_desc;

                    generos.Add(genero_BE);
                }
                return generos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
