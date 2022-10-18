using ElectoralApp.BAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.BAL.Repository.Code
{
    public class LookupRepository : ILookupReposiotry
    {
        private readonly electoraldbEntities _context;
        public LookupRepository(electoraldbEntities context)
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
        public IEnumerable<tblAssemblyConstituency> GetAssemblyConstituencies()
        {
            return _context.tblAssemblyConstituencies.ToList();
        }

        public IEnumerable<tblPollingStation> GetPollingStations()
        {
            return _context.tblPollingStations.ToList();
        }
        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
