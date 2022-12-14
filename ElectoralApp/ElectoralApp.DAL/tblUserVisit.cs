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
    
    public partial class tblUserVisit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUserVisit()
        {
            this.tblVoterRequests = new HashSet<tblVoterRequest>();
        }
    
        public long Id { get; set; }
        public long UserId { get; set; }
        public long VoterId { get; set; }
        public System.DateTime VisitStart { get; set; }
        public System.DateTime VisitEnd { get; set; }
        public string GeoTag { get; set; }
        public string AvailabilityStatus { get; set; }
        public bool IsVerified { get; set; }
        public Nullable<int> TotalHeadCount { get; set; }
        public Nullable<int> TotalRequests { get; set; }
    
        public virtual tblUser tblUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblVoterRequest> tblVoterRequests { get; set; }
    }
}
