using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibreria_BE;

namespace WebLibreria_ADO
{
    public class Autor_ADO
    {
        public List<Autor_BE> listarAutor()
        {
            try
            {
                dbLibreriaEntities entidades = new dbLibreriaEntities();
                List<Autor_BE> autores = new List<Autor_BE>();

                var query = (from miAutor in entidades.tb_Autor
                             select new Autor_BE
                             {
                                 aut_id = (short)miAutor.aut_id,
                                 aut_nom_ape = miAutor.aut_nom + " " + miAutor.aut_ape,
                             }).ToList();

                foreach (var autor in query)
                {
                    Autor_BE autor_BE = new Autor_BE();
                    autor_BE.aut_id = autor.aut_id;
                    autor_BE.aut_nom_ape = autor.aut_nom_ape;

                    autores.Add(autor_BE);
                }
                return autores;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
