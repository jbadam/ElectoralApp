using ElectoralApp.BAL;
using ElectoralApp.BAL.Repository.Code;
using ElectoralApp.BAL.Repository.Interfaces;
using ElectoralApp.BAL.Repository.Model;
using ElectoralApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectoralApp.Controllers
{
    public class HomeController : Controller
    {

        private ILookupReposiotry _lookupRepository;
        private ISearchRepository _searchRepository;

        public HomeController()
        {
            
            _lookupRepository = new LookupRepository(new electoraldbEntities());
            _searchRepository = new SearchRepository(new electoraldbEntities());
        }
        public HomeController(ISearchRepository searchRepository, ILookupReposiotry lookupReposiotry)
        {
            _lookupRepository = lookupReposiotry;
            _searchRepository = searchRepository;

        }
        public ActionResult Index()
        {
            return View();
        }
        [HandleError]
        public ActionResult Search()
        {
                     
            SearchViewModel sModel = new SearchViewModel();
            sModel.AssemblyConstituencies = (from ls in _lookupRepository.GetAssemblyConstituencies()
                                                select new AssemblyConstituencies
                                                {
                                                    Text = ls.Name,
                                                    Value = ls.ACNo
                                                }
                                                ).ToList();
           sModel.ListData = new List<GridData>();
           return View(sModel);

        }
        [HandleError]
        [HttpPost]
        public ActionResult Search(SearchViewModel sModel)
        {

            try
            {
                SearchModel searchModel = new SearchModel();

                searchModel.FirstName = sModel.FirstName;
                searchModel.LastName = sModel.LastName;
                searchModel.RLLName = sModel.RLLName;
                searchModel.VoterEPICNo = sModel.VoterEPICNo;
                searchModel.VoterOldEPIC = sModel.VoterOldEPIC;
                searchModel.VoterAddress = sModel.VoterAddress;
                searchModel.VoterMobile1 = sModel.VoterMobile1;
                searchModel.Age = sModel.Age;
                searchModel.RLFName = sModel.RLFName;
                searchModel.VoterCity = sModel.VoterCity;
                searchModel.VoterCommunity = sModel.VoterCommunity;
                searchModel.UseSoundEx = sModel.UseSoundEx;
                searchModel.AgeMargin = 3;
                searchModel.LERId = 1;
                if (sModel.AssemblyConstituencyNo == 0)
                    searchModel.vLACNo = null;
                else
                    searchModel.vLACNo = sModel.AssemblyConstituencyNo;

                sModel.ListData = (from ls in _searchRepository.SearchVoterListNew(searchModel)
                                   select new GridData
                                   {
                                       VoterEPICNo = ls.EPICNo,
                                       FirstName = ls.FirstName,
                                       LastName = ls.LastName,
                                       RLFName = ls.RelationFirstName,
                                       RLLName = ls.RelationLastName,
                                       Age = ls.Age,
                                       VoterMobile1 = ls.MobileNo,
                                       VoterAddress = ls.Address
                                   }).ToList();




                //sModel.ListData = (from ls in _searchRepository.SearchVoterList(searchModel)
                //                 select new GridData
                //                 {
                //                     VoterEPICNo =ls.EPICNo,
                //                     FirstName = ls.FirstName,
                //                     LastName =ls.LastName,
                //                     RLFName = ls.RelationFirstName,
                //                     RLLName = ls.RelationLastName,
                //                     Age= ls.Age,
                //                     VoterMobile1 = ls.MobileNo,
                //                     VoterAddress= ls.Address
                //                 }).ToList();






                sModel.AssemblyConstituencies = (from ls in _lookupRepository.GetAssemblyConstituencies()
                                                 select new AssemblyConstituencies
                                                 {
                                                     Text = ls.Name,
                                                     Value = ls.ACNo
                                                 }
                                                    ).ToList();


                return View(sModel);


            }
            catch (Exception)
            {
                throw;
                
            }

        }
        public ActionResult ViewVoter(string Mobile)
        {
            SearchModel searchModel = new SearchModel();

            
            searchModel.VoterMobile1 = Mobile;
                      
            searchModel.AgeMargin = 3;
            searchModel.LERId = 1;
            searchModel.vLACNo = null;
           

            var ListData = (from ls in _searchRepository.SearchVoterListNew(searchModel)
                               select new GridData
                               {
                                   VoterEPICNo = ls.EPICNo,
                                   FirstName = ls.FirstName,
                                   LastName = ls.LastName,
                                   RLFName = ls.RelationFirstName,
                                   RLLName = ls.RelationLastName,
                                   Age = ls.Age,
                                   VoterMobile1 = ls.MobileNo,
                                   VoterAddress = ls.Address
                               }).FirstOrDefault();

            return View(ListData);
        }



    }
}