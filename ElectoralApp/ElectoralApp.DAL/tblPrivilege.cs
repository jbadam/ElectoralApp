//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectoralApp.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPrivilege
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPrivilege()
        {
            this.tblRolePrivileges = new HashSet<tblRolePrivilege>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string PageId { get; set; }
        public string PageName { get; set; }
        public string ElementId { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRolePrivilege> tblRolePrivileges { get; set; }
    }
}
