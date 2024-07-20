using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibreria_BE
{
    public class Editorial_BE
    {
        public Int16 edi_id { get; set; }
        public String edi_nom { get; set; }
        public String edi_dir { get; set; }
        public Int16 ubg_id { get; set; }
        public String edi_tel { get; set; }
        public String edi_mail { get; set; }
        public String edi_user_reg { get; set; }
        public DateTime edi_fec_reg { get; set; }
        public String edi_user_mod { get; set; }
        public DateTime edi_fec_mod { get; set; }
        public Boolean edi_state { get; set; }

    }
}
