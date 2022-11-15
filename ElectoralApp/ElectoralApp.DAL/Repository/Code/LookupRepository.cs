using ElectoralApp.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.DAL.Repository.Code
{
    public class LookupRepository : ILookupReposiotry
    {
        private readonly ElectoralDBEntities _context;
               
        public LookupRepository(ElectoralDBEntities context)
        {
            _context = context;
        }

        public IEnumerable<tblCommunity> GetCommunityList()
        {
            return _context.tblCommunities.ToList();
        }

        public IEnumerable<tblRole> GetRolesList()
        {
            return _context.tblRoles.ToList();
        }

        public IEnumerable<tblState> GetStates()
        {
            return _context.tblStates.ToList();
        }
        public IEnumerable<tblAssemblyConstituency> GetAssemblyConstituencies(long UserId)
        {
            var assemblyConstituenciesList = (from ls in _context.tblAssemblyConstituencies
                                              join ls1 in _context.tblUsers on ls.AssemblyConstituencyId equals ls1.AssemblyConstituencyId
                                              where ls1.Id == UserId
                                              select ls 
                                             ).ToList();
            return assemblyConstituenciesList;
        }

        public IEnumerable<tblCity> GetCityList(long AssemblyConstituencyId)
        {
            var cityList = (from ls in _context.tblCities
                                join ls1 in _context.tblAssemblyConstituencies on ls.AssemblyConstituencyId equals ls1.AssemblyConstituencyId
                                where ls1.AssemblyConstituencyId == AssemblyConstituencyId
                                select ls
                            ).ToList();
            return cityList;
        }

        public IEnumerable<tblPollingStation> GetPollingStations()
        {
            return _context.tblPollingStations.ToList();
        }
       // void IDisposable.Dispose() => throw new NotImplementedException();
    }
}
