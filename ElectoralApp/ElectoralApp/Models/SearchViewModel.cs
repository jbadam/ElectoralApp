using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectoralApp.Models
{
    public class SearchViewModel
    {
        public int AssemblyConstituencyNo { get; set; }
                
        public string VoterEPICNo { get; set; }
        public string VoterOldEPIC { get; set; }

        public string RelationEPIC { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string RLFName { get; set; }

        public string RLLName { get; set; }

        public string VoterAddress { get; set; }

        public string VoterMobile1 { get; set; }

        public string VoterMobile2 { get; set; }

        public int? Age { get; set; }

        public string AppartmentName { get; set; }

        public string DateOfBirth { get; set; }

        public string VoterCity { get; set; }

        public string VoterCommunity { get; set; }

        public bool UseSoundEx { get; set; }

        public int? AgeMargin { get; set; }

        public int? LERId { get; set; }


        public List<AssemblyConstituencies> AssemblyConstituencies { get; set; }

        public List<GridData> ListData { get; set; }



    }

    public class GridData
    {
        public string VoterEPICNo { get; set; }
        public string VoterOldEPIC { get; set; }

        public string RelationEPIC { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string RLFName { get; set; }

        public string RLLName { get; set; }

        public string VoterAddress { get; set; }

        public string VoterMobile1 { get; set; }

        public string VoterMobile2 { get; set; }

        public int Age { get; set; }

        public string AppartmentName { get; set; }

        public string DateOfBirth { get; set; }

    }
}