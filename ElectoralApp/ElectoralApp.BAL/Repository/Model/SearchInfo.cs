using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.BAL.Repository.Model
{
    public class SearchInfo
    {
        public long RecCount { get; set; }

        public IList<VoterList> VoterList { get; set; }
    }


    public class VoterList
    {
        public string Address { get; set; }

        public int Age { get; set; }

        public string  EPICNo { get; set; }

        public string Firstname { get; set; }

        public string Gender { get; set; }

        public string HashValue { get; set; }

        public string Lastname { get; set; }

        public string Mobile { get; set; }

        public string RName { get; set; }

        public long VoterId { get; set; }

        public int Ward { get; set; }
           
    }
}
