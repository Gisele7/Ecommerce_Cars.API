//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ecommerce.API.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MARCA_CARRO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MARCA_CARRO()
        {
            this.MODELO_CARRO = new HashSet<MODELO_CARRO>();
        }
    
        public int MACodigo { get; set; }
        public string MADescricao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MODELO_CARRO> MODELO_CARRO { get; set; }
    }
}
