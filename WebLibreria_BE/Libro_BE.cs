using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibreria_BE
{
    public class Libro_BE
    {
        public Int16 lib_id { get; set; }
        public String lib_nom { get; set; }
        public Int16 aut_id { get; set; }
        public Int16 gen_id { get; set; }
        public String lib_edi { get; set; }
        public Int16 lib_fec_pub { get; set; }
        public Int16 lib_disp_stock { get; set; }
        public Int16 edi_id { get; set; }
        public String lib_user_reg { get; set; }
        public DateTime lib_fec_reg { get; set; }
        public String lib_user_mod { get; set; }
        public DateTime lib_fec_mod { get; set; }
        public Boolean lib_state { get; set; }
    }
}
