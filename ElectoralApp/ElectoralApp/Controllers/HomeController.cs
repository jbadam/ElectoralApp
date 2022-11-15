using ElectoralApp.BAL.Repository.Code;
using ElectoralApp.BAL.Repository.Interfaces;
using ElectoralApp.BAL.Repository.Model;
using ElectoralApp.DAL;
using ElectoralApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Configuration;


namespace ElectoralApp.Controllers
{
    public class HomeController : Controller
    {

        private ILookupManager _lookupManager;
        private ISearchManager _searchManager;
        private readonly ElectoralDBEntities _context;
        //private Iconfiguration 

       // ElectoralAPI.ElectoralUnifiedAPIClient obj = new ElectoralAPI.ElectoralUnifiedAPIClient();
        public HomeController()
        {
            _lookupManager = new LookupManager(new ElectoralDBEntities());
            _searchManager = new SearchManager(new ElectoralDBEntities());
        }
        public HomeController(ISearchManager searchManager, ILookupManager lookupManager)
        {
            _searchManager = searchManager;
            _lookupManager = lookupManager;
            

        }
        public ActionResult Index()
        {
            return View();
        }
        [HandleError]
        public ActionResult Search()
        {
            long lUserId = 3;         
            SearchViewModel sModel = new SearchViewModel();
            List<SelectListItem> assemblyConstituencyName = new List<SelectListItem>();
            assemblyConstituencyName = (from ls in _lookupManager.GetAssemblyConstituencies(lUserId).ToList()
                                           select new SelectListItem
                                           {
                                               Text = ls.Name,
                                               Value = ls.AssemblyConstituencyId.ToString()

                                           }).ToList();
            sModel.AssemblyConstituency = assemblyConstituencyName;
           sModel.ListData = new List<GridData>();
           return View(sModel);

        }

        [HttpPost]
        public ActionResult GetCity(string acId)
        {

            List<SelectListItem> citiName = new List<SelectListItem>();
            if (!string.IsNullOrEmpty(acId))
            {
                citiName = (from ls in _lookupManager.GetCityList(long.Parse(acId)).ToList()
                            select new SelectListItem
                            {
                                Text = ls.Name,
                                Value = ls.Id.ToString()
                            }).ToList();
            }
            return Json(citiName, JsonRequestBehavior.AllowGet);
        }

        [HandleError]
        [HttpPost]
        public ActionResult Search(SearchViewModel sModel)
        {

            try
            {
                BAL.ElectoralAPI.SearchFiltersInfoReq sFilterReq = new BAL.ElectoralAPI.SearchFiltersInfoReq();

                sFilterReq.ACId = sModel.AssemblyConstituencyNo;
                sFilterReq.Firstname = sModel.FirstName;
                sFilterReq.Lastname = sModel.LastName;
                sFilterReq.RFName = sModel.RLFName;
                sFilterReq.EPICNo = sModel.VoterEPICNo;
                sFilterReq.Mobile = sModel.VoterMobile1;
                sFilterReq.UserId = 3;
                sFilterReq.HashValue = "8776f108e247ab1e2b323042c049c266407c81fbad41bde1e8dfc1bb66fd267e";
                if (!String.IsNullOrEmpty(sModel.Age))
                    sFilterReq.Age = int.Parse(sModel.Age.ToString());
                sFilterReq.RLName = sModel.RLFName;
                if (!String.IsNullOrEmpty(sModel.VoterCity))
                    sFilterReq.CityId = int.Parse(sModel.VoterCity.ToString());
                SearchInfo  serachInfo = _searchManager.SearchVoterListNew(sFilterReq);
                sModel.ListData = (from ls in serachInfo.VoterList
                                   select new GridData
                                   {
                                       VoterEPICNo=ls.EPICNo,
                                       FirstName = ls.Firstname,
                                       LastName = ls.Lastname,
                                       Age = int.Parse(ls.Age.ToString()),
                                       RLFName = ls.RName,
                                       VoterMobile1 = ls.Mobile,
                                       VoterAddress=ls.Address,
                                       VoterId=ls.VoterId

                                   }).ToList();

                long lUserId = 3;
                List<SelectListItem> assemblyConstituencyName = new List<SelectListItem>();
                assemblyConstituencyName = (from ls in _lookupManager.GetAssemblyConstituencies(lUserId).ToList()
                                            select new SelectListItem
                                            {
                                                Text = ls.Name,
                                                Value = ls.AssemblyConstituencyId.ToString()

                                            }).ToList();
                sModel.AssemblyConstituency = assemblyConstituencyName;

                return View(sModel);
            }
            catch (Exception)
            {
                throw;
                
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="VoterId"></param>
        /// <returns></returns>
        [HttpGet]
        [HandleError]
        public ActionResult ViewVoter(long VoterId)
        {
            try
            {
                int UserId = 3;
                string HashValue = "8776f108e247ab1e2b323042c049c266407c81fbad41bde1e8dfc1bb66fd267e";
                VoterInfo voterInfo = new VoterInfo();
                voterInfo = _searchManager.GetVoterDetails(VoterId, UserId, HashValue);
                return View(voterInfo);
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}