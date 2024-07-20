using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibreria_BE
{
    public class Cliente_BE
    {
        public Int16 cli_id {  get; set; }
        public String cliente { get; set; }
        public String cli_tel { get; set; }
        public String cli_mail { get; set; }
        public Int16? cli_memb_tipo { get; set; }
        public DateTime? cli_memb_cad {  get; set; }
    }
}
