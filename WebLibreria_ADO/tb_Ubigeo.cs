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
    
    public partial class tb_Ubigeo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Ubigeo()
        {
            this.tb_Cliente = new HashSet<tb_Cliente>();
            this.tb_Editorial = new HashSet<tb_Editorial>();
            this.tb_Personal = new HashSet<tb_Personal>();
        }
    
        public string ubg_id { get; set; }
        public string ubg_reg_id { get; set; }
        public string ubg_prov_id { get; set; }
        public string ubg_dist_id { get; set; }
        public string ubg_reg { get; set; }
        public string ubg_prov { get; set; }
        public string ubg_dist { get; set; }
        public string ubg_user_reg { get; set; }
        public System.DateTime ubg_fec_reg { get; set; }
        public string ubg_user_mod { get; set; }
        public Nullable<System.DateTime> ubg_fec_mod { get; set; }
        public bool ubg_state { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Cliente> tb_Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Editorial> tb_Editorial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Personal> tb_Personal { get; set; }
    }
}
