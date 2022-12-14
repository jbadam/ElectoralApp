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
    
    public partial class tblPollingStation
    {
        public long Id { get; set; }
        public int ACNo { get; set; }
        public int StationNo { get; set; }
        public string StationName { get; set; }
        public string StationNameTE { get; set; }
        public string StationAddress { get; set; }
        public string StationAddressTE { get; set; }
        public string MainTown { get; set; }
        public string PoliceStation { get; set; }
        public string Mandal { get; set; }
        public string RevenueDivision { get; set; }
        public string District { get; set; }
        public string PinCode { get; set; }
        public Nullable<int> StartSerialNo { get; set; }
        public Nullable<int> EndSerialNo { get; set; }
        public Nullable<int> TotalElectors { get; set; }
        public Nullable<int> TotalMale { get; set; }
        public Nullable<int> TotalFemale { get; set; }
        public Nullable<int> TotalOthers { get; set; }
    
        public virtual tblAssemblyConstituency tblAssemblyConstituency { get; set; }
    }
}
