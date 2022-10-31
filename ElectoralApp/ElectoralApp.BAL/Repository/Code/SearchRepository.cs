using ElectoralApp.BAL.Repository.Interfaces;
using ElectoralApp.BAL.Repository.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.BAL.Repository.Code
{
    public class SearchRepository : ISearchRepository
    {
        private readonly ElectoralDBEntities _context;

        public SearchRepository(ElectoralDBEntities context)
        {
            _context = context;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tblVoter> GetVoterList()
        {
           return _context.tblVoters.ToList();
        }

        public ObjectResult<uspGetVoters_Result> SearchVoterListNew(SearchModel searchModel)
        {
            //return _context.uspGetVoters(searchModel.FirstName, searchModel.LastName, searchModel.RLFName,
            //                            searchModel.VoterEPICNo, searchModel.VoterAddress, searchModel.VoterMobile1, searchModel.Age, false);

            //return _context.uspGetVoters(searchModel.FirstName, searchModel.LastName, searchModel.RLLName,
            //                            searchModel.VoterEPICNo,searchModel.VoterOldEPIC, searchModel.VoterAddress, searchModel.VoterMobile1, 
            //                            searchModel.Age,searchModel.RLFName,searchModel.VoterCity,searchModel.VoterCommunity,
            //                            searchModel.UseSoundEx,searchModel.AgeMargin,searchModel.LERId,searchModel.vLACNo);

            return _context.uspGetVoters(searchModel.FirstName, searchModel.LastName, searchModel.RLLName,
                                       searchModel.VoterEPICNo, searchModel.VoterOldEPIC, searchModel.VoterAddress, searchModel.VoterMobile1,
                                       searchModel.Age, searchModel.RLFName, searchModel.UseSoundEx, searchModel.AgeMargin,
                                       searchModel.LERId, searchModel.vLACNo);


        }

        public ObjectResult<uspGetVoters_Result> SearchVoterList(SearchModel searchModel)
        {
            //return _context.uspGetVoters(searchModel.FirstName, searchModel.LastName, searchModel.RLFName,
            //                            searchModel.VoterEPICNo, searchModel.VoterAddress, searchModel.VoterMobile1, searchModel.Age, false);

            return _context.uspGetVoters(searchModel.FirstName, searchModel.LastName, searchModel.RLLName,
                                        searchModel.VoterEPICNo, searchModel.VoterOldEPIC, searchModel.VoterAddress, searchModel.VoterMobile1,
                                        searchModel.Age, searchModel.RLFName, searchModel.UseSoundEx, searchModel.AgeMargin,
                                        searchModel.LERId, searchModel.vLACNo);



        }
    }
}
