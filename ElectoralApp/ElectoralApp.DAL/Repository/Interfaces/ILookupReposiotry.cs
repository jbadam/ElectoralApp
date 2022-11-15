using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.DAL.Repository.Interfaces
{
    public interface ILookupReposiotry
    {

        IEnumerable<tblCommunity> GetCommunityList();

        IEnumerable<tblCity> GetCityList(long AssemblyConstituencyId);

        IEnumerable<tblState> GetStates();
        IEnumerable<tblAssemblyConstituency> GetAssemblyConstituencies(long UserId);

        IEnumerable<tblRole> GetRolesList();

        IEnumerable<tblPollingStation> GetPollingStations();
    }
}
