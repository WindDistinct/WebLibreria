using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibreria_BE
{
    public class Ejemplar_BE
    {
        public Int16 ejem_id {  get; set; }
        public Int16 lib_id { get; set; }
        public Boolean ejem_disp { get; set; }
        public String ejem_condicion { get; set; }
        public Int16 alm_id { get; set; }
        public String ejem_user_reg { get; set; }
        public DateTime ejem_fec_reg { get; set; }
        public String ejem_user_mod { get; set; }
        public DateTime ejem_fec_mod { get; set; }

    }
}
