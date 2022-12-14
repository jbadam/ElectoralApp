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
    
    public partial class tblVoter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblVoter()
        {
            this.tblVoterExts = new HashSet<tblVoterExt>();
        }
    
        public long Id { get; set; }
        public int ERId { get; set; }
        public int ACNo { get; set; }
        public string WardNo { get; set; }
        public Nullable<int> WardSNo { get; set; }
        public int PartNo { get; set; }
        public int SerialNo { get; set; }
        public Nullable<int> PSSId { get; set; }
        public string EPICNo { get; set; }
        public string OldEPICNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNameTE { get; set; }
        public string LastNameTE { get; set; }
        public string Relation { get; set; }
        public string RelationFirstName { get; set; }
        public string RelationLastName { get; set; }
        public string RelationFirstNameTE { get; set; }
        public string RelationLastNameTE { get; set; }
        public string RelationEPICNo { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string AddressTE { get; set; }
        public string MobileNo { get; set; }
    
        public virtual tblAssemblyConstituency tblAssemblyConstituency { get; set; }
        public virtual tblElectoralRoll tblElectoralRoll { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblVoterExt> tblVoterExts { get; set; }
    }
}
