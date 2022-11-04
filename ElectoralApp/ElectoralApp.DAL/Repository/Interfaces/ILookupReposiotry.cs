using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.DAL.Repository.Interfaces
{
    interface ILookupReposiotry
    {

        IEnumerable<tblCommunity> GetCommunityList();

        IEnumerable<tblState> GetStates();
        IEnumerable<tblAssemblyConstituency> GetAssemblyConstituencies();

        IEnumerable<tblRole> GetRolesList();

        IEnumerable<tblPollingStation> GetPollingStations();
    }
}
