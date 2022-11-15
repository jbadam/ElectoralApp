using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.BAL.Repository.Model
{
    public class VoterInfo
    {
        public ElectoralInfo electoralInfo { get; set; }

        public RelationInfo relationInfo { get; set; }

        public PersonalInfo personalInfo { get; set; }


        public string HashValue { get; set; }

        public string Message { get; set; }

        public int Status { get; set; }

    }
    public class ElectoralInfo
    {
        public int ACId { get; set; }

        public string ACName { get; set; }

        public string City { get; set; }

        public int CityId { get; set; }

        public int DistrictId { get; set; }

        public string District { get; set; }

        public string EPICNo { get; set; }

        public string OldEPICNo { get; set; }

        public string PCName { get; set; }

        public int PSId { get; set; }

        public string PSAddress { get; set; }


        public string PSName { get; set; }

        public int PSNo { get; set; }

        public string PSSName { get; set; }


        public string State { get; set; }

        public int PSSId { get; set; }

        public int StateId { get; set; }
        public int SerialNo { get; set; }

        public string WardNo { get; set; }

        public string WardSNo { get; set; }

    }

    public class PersonalInfo
    {
        public string Address { get; set; }

        public string Firstname { get; set; }


        public string Lastname { get; set; }


        public string Gender { get; set; }

        public string MobileNo { get; set; }


        public string DOB { get; set; }


        public int Age { get; set; }
    }


    public class RelationInfo
    {
        public string REPICNo { get; set; }

        public string RFirstname { get; set; }


        public string RLastname { get; set; }

        public string Relation { get; set; }

    }
}
