//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tallyho
{
    using System;
    using System.Collections.Generic;
    
    public partial class Well
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Well()
        {
            this.Strings = new HashSet<String>();
        }
    
        public int WellId { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string ServiceProvider { get; set; }
        public int RigNumber { get; set; }
        public string RigCompany { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<String> Strings { get; set; }
    }
}