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
    
    public partial class String
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public String()
        {
            this.Casings = new HashSet<Casing>();
        }
    
        public int StringId { get; set; }
        public int WellId { get; set; }
        public string CasingType { get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }
        public string MeasuredBy { get; set; }
        public System.DateTime DateMeasured { get; set; }
        public string RunType { get; set; }
        public Nullable<int> StringPosition { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Casing> Casings { get; set; }
        public virtual Well Well { get; set; }
    }
}
