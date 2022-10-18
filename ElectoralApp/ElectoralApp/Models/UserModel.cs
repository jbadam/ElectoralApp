using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectoralApp.Models
{
    public class UserModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Relation { get; set; }

        public string RelationFirstname { get; set; }

        public string RelationLasttname { get; set; }

        public string Gender { get; set; }
        public int Age { get; set; }

        public string EpicId { get; set; }

        public string Address { get; set; }

        public int CommunityID { get; set; }

        public int PollingBoothID { get; set; }

        public string MobileNo { get; set; }
        public string AltMobileNo { get; set; }
        public string Email { get; set; }

        public int AssemblyConstituencyNo { get; set; }
        public string LoginPwd { get; set; }
        
        public string City { get; set; }

        public string StateID { get; set; }

        public string StateName { get; set; }

        public int RoleId { get; set; }
        public string Active { get; set; }
        public string PinCode { get; set; }
        public Nullable<long> ParentUserId { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifledBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        public List<clsState>  States  { get; set; }

        public List<AssemblyConstituencies> AssemblyConstituencies { get; set; }

        public List<Community> CommunityList { get; set; }


        public List<PollingBooth> PollingboothList { get; set; }

        public List<Roles> RolesList { get; set; }

        public Status SelectStatusType { get; set; }

    }

    public class Roles
    {
        public string Text { get; set; }
        public int Value { get; set; }

    }

    public class PollingBooth
    {
        public string Text { get; set; }
        public int Value { get; set; }

    }

    public class clsState
    {
        public string Text { get; set; }
        public string Value { get; set; }

    }
    public class AssemblyConstituencies
    {
        public string Text { get; set; }
        public int Value { get; set; }

    }
    public class Community
    {
        public string Text { get; set; }
        public int Value { get; set; }

    }

    public enum Status
    {
        Active=1, 
        InActive=0
    }



}