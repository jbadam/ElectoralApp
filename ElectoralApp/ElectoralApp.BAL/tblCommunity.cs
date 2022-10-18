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
    
    public partial class tblCommunity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCommunity()
        {
            this.tblCommunityCordinators = new HashSet<tblCommunityCordinator>();
            this.tblVoterExts = new HashSet<tblVoterExt>();
            this.tblVoterExts1 = new HashSet<tblVoterExt>();
        }
    
        public long Id { get; set; }
        public int CommunityTypeId { get; set; }
        public int ACNo { get; set; }
        public string Name { get; set; }
        public string Locality { get; set; }
        public string Landmark { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string DoorNo { get; set; }
    
        public virtual tblAssemblyConstituency tblAssemblyConstituency { get; set; }
        public virtual tblCommunityType tblCommunityType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCommunityCordinator> tblCommunityCordinators { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblVoterExt> tblVoterExts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblVoterExt> tblVoterExts1 { get; set; }
    }
}