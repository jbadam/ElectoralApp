//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectoralApp.BAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblParliamentConstituency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblParliamentConstituency()
        {
            this.tblAssemblyConstituencies = new HashSet<tblAssemblyConstituency>();
        }
    
        public int PCNo { get; set; }
        public int StateId { get; set; }
        public string Name { get; set; }
        public Nullable<int> ReservedFor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAssemblyConstituency> tblAssemblyConstituencies { get; set; }
        public virtual tblState tblState { get; set; }
    }
}
