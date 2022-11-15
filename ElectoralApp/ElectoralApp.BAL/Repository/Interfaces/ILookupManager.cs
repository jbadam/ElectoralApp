using ElectoralApp.BAL.Repository.Model;
using ElectoralApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.BAL.Repository.Interfaces
{
   public interface ILookupManager
    {

        IEnumerable<CommuityModel> GetCommunityList();

        IEnumerable<StateModel> GetStates();
        IEnumerable<AssemblyConstituency> GetAssemblyConstituencies(long UserId);

        IEnumerable<City> GetCityList(long AssemblyConstituencyId);

        IEnumerable<RoleModel> GetRolesList();

        IEnumerable<PollingStationModel> GetPollingStations();
    }
}
