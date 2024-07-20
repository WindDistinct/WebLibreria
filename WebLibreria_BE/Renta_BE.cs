using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibreria_BE
{
    public class Renta_BE
    {
        public Int16 rent_id { get; set; }
        public DateTime rent_fec { get; set; }
        public DateTime rent_fec_dev { get; set; }
        public Int16 ejem_id { get; set; }
        public Int16 lib_id { get; set; }
        public String lib_nom { get; set; }
        public Int16 aut_id { get; set; }
        public String aut_nom { get; set; }
        public String aut_ape { get; set; }
        public Int16 gen_id { get; set; }
        public String gen_desc { get; set; }
        public Int16 edi_id { get; set; }
        public String edi_nom { get; set; }
    }

    public class RentaLibro_BE
    {
        public Int16 lib_id { get; set; }
        public String lib_nom { get; set; }
        public String gen_desc { get; set; }
        public String autor { get; set; }
        public Int16 rent_count { get; set; }
    }

    public class RentaMensual_BE
    {
        public Int16 Mes { get; set; }
        public Int16 Rentas { get; set; }
    }

    public class RentaxGenero_BE
    {
        public String genero { get; set; }
        public Decimal porcentaje { get; set; }
    }
}
