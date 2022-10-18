using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.BAL.Repository.Interfaces
{
    public interface ILookupReposiotry : IDisposable
    {
        IEnumerable<tblCommunity> GetCommunityList();

        IEnumerable<tblState> GetStates();
        IEnumerable<tblAssemblyConstituency> GetAssemblyConstituencies();

        IEnumerable<tblRole> GetRolesList();

        IEnumerable<tblPollingStation> GetPollingStations();
                
    }
}
