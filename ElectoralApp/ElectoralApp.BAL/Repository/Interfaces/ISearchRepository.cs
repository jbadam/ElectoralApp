using ElectoralApp.BAL.Repository.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.BAL.Repository.Interfaces
{
    public interface ISearchRepository : IDisposable
    {
        IEnumerable<tblVoter> GetVoterList();

        ObjectResult<uspGetVoters_Result> SearchVoterList(SearchModel searchModel);

        ObjectResult<uspGetVoters_Result> SearchVoterListNew(SearchModel searchModel);
    }
}
