//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebLibreria_ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Personal
    {
        public int per_id { get; set; }
        public string per_nom { get; set; }
        public string per_ape_pat { get; set; }
        public string per_ape_mat { get; set; }
        public string per_dir { get; set; }
        public string ubg_id { get; set; }
        public string per_tel { get; set; }
        public string per_dni { get; set; }
        public string per_mail { get; set; }
        public string per_pass { get; set; }
        public byte[] per_foto { get; set; }
        public Nullable<System.DateTime> per_fec_ing { get; set; }
        public string per_user_reg { get; set; }
        public System.DateTime per_fec_reg { get; set; }
        public string per_user_mod { get; set; }
        public Nullable<System.DateTime> per_fec_mod { get; set; }
        public bool per_state { get; set; }
    
        public virtual tb_Ubigeo tb_Ubigeo { get; set; }
    }
}