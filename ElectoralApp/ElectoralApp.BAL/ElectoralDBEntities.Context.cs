﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class electoraldbEntities : DbContext
    {
        public electoraldbEntities()
            : base("name=electoraldbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblAssemblyConstituency> tblAssemblyConstituencies { get; set; }
        public virtual DbSet<tblCaste> tblCastes { get; set; }
        public virtual DbSet<tblCommunity> tblCommunities { get; set; }
        public virtual DbSet<tblCommunityCordinator> tblCommunityCordinators { get; set; }
        public virtual DbSet<tblCommunityType> tblCommunityTypes { get; set; }
        public virtual DbSet<tblDistrict> tblDistricts { get; set; }
        public virtual DbSet<tblElectoralRoll> tblElectoralRolls { get; set; }
        public virtual DbSet<tblParliamentConstituency> tblParliamentConstituencies { get; set; }
        public virtual DbSet<tblPoliticalParty> tblPoliticalParties { get; set; }
        public virtual DbSet<tblPollingStation> tblPollingStations { get; set; }
        public virtual DbSet<tblPollingStationSection> tblPollingStationSections { get; set; }
        public virtual DbSet<tblPrivilege> tblPrivileges { get; set; }
        public virtual DbSet<tblRequestAttribute> tblRequestAttributes { get; set; }
        public virtual DbSet<tblRequestType> tblRequestTypes { get; set; }
        public virtual DbSet<tblRole> tblRoles { get; set; }
        public virtual DbSet<tblRolePrivilege> tblRolePrivileges { get; set; }
        public virtual DbSet<tblState> tblStates { get; set; }
        public virtual DbSet<tblSubCaste> tblSubCastes { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUserRole> tblUserRoles { get; set; }
        public virtual DbSet<tblUserVisit> tblUserVisits { get; set; }
        public virtual DbSet<tblVoter> tblVoters { get; set; }
        public virtual DbSet<tblVoterDemo> tblVoterDemoes { get; set; }
        public virtual DbSet<tblVoterExt> tblVoterExts { get; set; }
        public virtual DbSet<tblVoterRequest> tblVoterRequests { get; set; }
        public virtual DbSet<tblVoterRequestExt> tblVoterRequestExts { get; set; }
        public virtual DbSet<tblVoter_Stage_old> tblVoter_Stage_old { get; set; }
        public virtual DbSet<tblSetting> tblSettings { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<uspGetExactFNameSimilarLName_Result> uspGetExactFNameSimilarLName()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetExactFNameSimilarLName_Result>("uspGetExactFNameSimilarLName");
        }
    
        public virtual ObjectResult<uspGetExactLNameSimilarFName_Result> uspGetExactLNameSimilarFName()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetExactLNameSimilarFName_Result>("uspGetExactLNameSimilarFName");
        }
    
        public virtual ObjectResult<uspGetVoters_Result> uspGetVoters(string voterFirstName, string voterLastName, string rLName, string voterEPICNo, string voterOldEPICNo, string voterAddress, string voterMobile, Nullable<int> voterAge, string voterRLFName, Nullable<bool> useSoundex, Nullable<int> ageMargin, Nullable<int> vLERId, Nullable<int> vLACNo)
        {
            var voterFirstNameParameter = voterFirstName != null ?
                new ObjectParameter("VoterFirstName", voterFirstName) :
                new ObjectParameter("VoterFirstName", typeof(string));
    
            var voterLastNameParameter = voterLastName != null ?
                new ObjectParameter("VoterLastName", voterLastName) :
                new ObjectParameter("VoterLastName", typeof(string));
    
            var rLNameParameter = rLName != null ?
                new ObjectParameter("RLName", rLName) :
                new ObjectParameter("RLName", typeof(string));
    
            var voterEPICNoParameter = voterEPICNo != null ?
                new ObjectParameter("VoterEPICNo", voterEPICNo) :
                new ObjectParameter("VoterEPICNo", typeof(string));
    
            var voterOldEPICNoParameter = voterOldEPICNo != null ?
                new ObjectParameter("VoterOldEPICNo", voterOldEPICNo) :
                new ObjectParameter("VoterOldEPICNo", typeof(string));
    
            var voterAddressParameter = voterAddress != null ?
                new ObjectParameter("VoterAddress", voterAddress) :
                new ObjectParameter("VoterAddress", typeof(string));
    
            var voterMobileParameter = voterMobile != null ?
                new ObjectParameter("VoterMobile", voterMobile) :
                new ObjectParameter("VoterMobile", typeof(string));
    
            var voterAgeParameter = voterAge.HasValue ?
                new ObjectParameter("VoterAge", voterAge) :
                new ObjectParameter("VoterAge", typeof(int));
    
            var voterRLFNameParameter = voterRLFName != null ?
                new ObjectParameter("VoterRLFName", voterRLFName) :
                new ObjectParameter("VoterRLFName", typeof(string));
    
            var useSoundexParameter = useSoundex.HasValue ?
                new ObjectParameter("UseSoundex", useSoundex) :
                new ObjectParameter("UseSoundex", typeof(bool));
    
            var ageMarginParameter = ageMargin.HasValue ?
                new ObjectParameter("AgeMargin", ageMargin) :
                new ObjectParameter("AgeMargin", typeof(int));
    
            var vLERIdParameter = vLERId.HasValue ?
                new ObjectParameter("VLERId", vLERId) :
                new ObjectParameter("VLERId", typeof(int));
    
            var vLACNoParameter = vLACNo.HasValue ?
                new ObjectParameter("VLACNo", vLACNo) :
                new ObjectParameter("VLACNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetVoters_Result>("uspGetVoters", voterFirstNameParameter, voterLastNameParameter, rLNameParameter, voterEPICNoParameter, voterOldEPICNoParameter, voterAddressParameter, voterMobileParameter, voterAgeParameter, voterRLFNameParameter, useSoundexParameter, ageMarginParameter, vLERIdParameter, vLACNoParameter);
        }
    
        public virtual ObjectResult<uspFindVoters_Result> uspFindVoters(string fName)
        {
            var fNameParameter = fName != null ?
                new ObjectParameter("FName", fName) :
                new ObjectParameter("FName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspFindVoters_Result>("uspFindVoters", fNameParameter);
        }
    
        public virtual ObjectResult<uspGetConditionalDuplicateVoters_Result> uspGetConditionalDuplicateVoters()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetConditionalDuplicateVoters_Result>("uspGetConditionalDuplicateVoters");
        }
    
        public virtual ObjectResult<uspGetDuplicateVoters_Result> uspGetDuplicateVoters()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetDuplicateVoters_Result>("uspGetDuplicateVoters");
        }
    
        public virtual ObjectResult<uspGetExactFirstNameSimilarLastName_Result> uspGetExactFirstNameSimilarLastName()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetExactFirstNameSimilarLastName_Result>("uspGetExactFirstNameSimilarLastName");
        }
    
        public virtual ObjectResult<uspGetExactLastNameSimilarFirstName_Result> uspGetExactLastNameSimilarFirstName()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetExactLastNameSimilarFirstName_Result>("uspGetExactLastNameSimilarFirstName");
        }
    
        public virtual ObjectResult<uspGetVotersNew_Result> uspGetVotersNew(string voterFirstName, string voterLastName, string rLName, string voterEPICNo, string voterOldEPICNo, string voterAddress, string voterMobile, Nullable<int> voterAge, string voterRLFName, string voterCity, string voterCommunity, Nullable<bool> useSoundex, Nullable<int> ageMargin, Nullable<int> vLERId, Nullable<int> vLACNo)
        {
            var voterFirstNameParameter = voterFirstName != null ?
                new ObjectParameter("VoterFirstName", voterFirstName) :
                new ObjectParameter("VoterFirstName", typeof(string));
    
            var voterLastNameParameter = voterLastName != null ?
                new ObjectParameter("VoterLastName", voterLastName) :
                new ObjectParameter("VoterLastName", typeof(string));
    
            var rLNameParameter = rLName != null ?
                new ObjectParameter("RLName", rLName) :
                new ObjectParameter("RLName", typeof(string));
    
            var voterEPICNoParameter = voterEPICNo != null ?
                new ObjectParameter("VoterEPICNo", voterEPICNo) :
                new ObjectParameter("VoterEPICNo", typeof(string));
    
            var voterOldEPICNoParameter = voterOldEPICNo != null ?
                new ObjectParameter("VoterOldEPICNo", voterOldEPICNo) :
                new ObjectParameter("VoterOldEPICNo", typeof(string));
    
            var voterAddressParameter = voterAddress != null ?
                new ObjectParameter("VoterAddress", voterAddress) :
                new ObjectParameter("VoterAddress", typeof(string));
    
            var voterMobileParameter = voterMobile != null ?
                new ObjectParameter("VoterMobile", voterMobile) :
                new ObjectParameter("VoterMobile", typeof(string));
    
            var voterAgeParameter = voterAge.HasValue ?
                new ObjectParameter("VoterAge", voterAge) :
                new ObjectParameter("VoterAge", typeof(int));
    
            var voterRLFNameParameter = voterRLFName != null ?
                new ObjectParameter("VoterRLFName", voterRLFName) :
                new ObjectParameter("VoterRLFName", typeof(string));
    
            var voterCityParameter = voterCity != null ?
                new ObjectParameter("VoterCity", voterCity) :
                new ObjectParameter("VoterCity", typeof(string));
    
            var voterCommunityParameter = voterCommunity != null ?
                new ObjectParameter("VoterCommunity", voterCommunity) :
                new ObjectParameter("VoterCommunity", typeof(string));
    
            var useSoundexParameter = useSoundex.HasValue ?
                new ObjectParameter("UseSoundex", useSoundex) :
                new ObjectParameter("UseSoundex", typeof(bool));
    
            var ageMarginParameter = ageMargin.HasValue ?
                new ObjectParameter("AgeMargin", ageMargin) :
                new ObjectParameter("AgeMargin", typeof(int));
    
            var vLERIdParameter = vLERId.HasValue ?
                new ObjectParameter("VLERId", vLERId) :
                new ObjectParameter("VLERId", typeof(int));
    
            var vLACNoParameter = vLACNo.HasValue ?
                new ObjectParameter("VLACNo", vLACNo) :
                new ObjectParameter("VLACNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetVotersNew_Result>("uspGetVotersNew", voterFirstNameParameter, voterLastNameParameter, rLNameParameter, voterEPICNoParameter, voterOldEPICNoParameter, voterAddressParameter, voterMobileParameter, voterAgeParameter, voterRLFNameParameter, voterCityParameter, voterCommunityParameter, useSoundexParameter, ageMarginParameter, vLERIdParameter, vLACNoParameter);
        }
    
        public virtual int Test_Vote()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Test_Vote");
        }
    }
}
