//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterPol.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Adress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adress()
        {
            this.PartnersImport = new HashSet<PartnersImport>();
        }
    
        public int Id { get; set; }
        public int IdIndex { get; set; }
        public int IdRegion { get; set; }
        public int IdCity { get; set; }
        public int IdStreet { get; set; }
        public int HouseNum { get; set; }
    
        public virtual Cities Cities { get; set; }
        public virtual Indexes Indexes { get; set; }
        public virtual Regions Regions { get; set; }
        public virtual Streets Streets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnersImport> PartnersImport { get; set; }
    }
}
