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
    
    public partial class tblPollingStationSection
    {
        public long Id { get; set; }
        public long PollingStationId { get; set; }
        public int SectionNo { get; set; }
        public string SectionName { get; set; }
        public string SectionNameTE { get; set; }
    }
}