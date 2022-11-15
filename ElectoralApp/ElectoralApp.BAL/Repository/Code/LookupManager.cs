using ElectoralApp.BAL.Repository.Interfaces;
using ElectoralApp.BAL.Repository.Model;
using ElectoralApp.DAL;
using ElectoralApp.DAL.Repository.Code;
using ElectoralApp.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.BAL.Repository.Code
{
    public class LookupManager : ILookupManager
    {
        private  ILookupReposiotry _lookupRepository;
        private readonly ElectoralDBEntities _context;

        public LookupManager(ElectoralDBEntities context)
        {
            _lookupRepository = new LookupRepository(context);
        }
        public LookupManager(ILookupReposiotry lookupRepository, ElectoralDBEntities context)
        {
            _lookupRepository = lookupRepository;
            _context = context;
        }

        public IEnumerable<AssemblyConstituency> GetAssemblyConstituencies(long UserId)
        {
            var assemblyConstituency = (from ls in _lookupRepository.GetAssemblyConstituencies(UserId)
                                        select new AssemblyConstituency 
                                        {
                                          AssemblyConstituencyId=   ls.AssemblyConstituencyId,
                                          Name=  ls.Name

                                        }).ToList();
            return assemblyConstituency;
            //throw new NotImplementedException();
        }

        public IEnumerable<City> GetCityList(long assemblyConstituencyId)
        {
            var cityList = (from ls in _lookupRepository.GetCityList(assemblyConstituencyId)
                                        select new City
                                        {
                                            Id = (int) ls.Id,
                                            Name = ls.Name

                                        }).ToList();
            return cityList;
        }



        public IEnumerable<CommuityModel> GetCommunityList()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PollingStationModel> GetPollingStations()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoleModel> GetRolesList()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StateModel> GetStates()
        {
            throw new NotImplementedException();
        }
    }
}
