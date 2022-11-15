using ElectoralApp.BAL.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.BAL.Repository.Interfaces
{
    public interface ISearchManager
    {
        SearchInfo SearchVoterListNew(ElectoralAPI.SearchFiltersInfoReq sFilterReq);

        VoterInfo GetVoterDetails(long VoterId, int userId, string hashValue);
    }
}
