using ElectoralApp.BAL;
using ElectoralApp.BAL.Repository;
using ElectoralApp.BAL.Repository.Code;
using ElectoralApp.BAL.Repository.Interfaces;
using ElectoralApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectoralApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private IUserManager _userManager;
        private ILookupManager _lookupManager;

        public LoginController()
        {
            //_userManager = new UserManager();
           // _lookupRepository = new LookupRepository(new ElectoralDBEntities());
        }
        public LoginController(IUserManager userManager, ILookupManager lookupManager)
        {
            _userManager = userManager;
            _lookupManager = lookupManager;
        }
        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        public ActionResult Index()
        {
            var model = (from ls in _userManager.GetAllUser().ToList()
                         select new UserModel
                         {
                             Id=ls.Id,
                             FirstName =ls.FirstName,
                             LastName =ls.LastName,
                             Gender = ls.Gender,
                             Relation= ls.Relation,
                             RelationFirstname= ls.RelationFirstName,
                             RelationLasttname = ls.RelationLastName,
                             Email = ls.Email
                         }
                        ).ToList();
            return View(model);
        }

        public ActionResult NewUser(long Id)
        {
            UserModel userModel = new UserModel();
            if (Id > 0)
            {
                userModel = (from ls in _userRepository.GetAllUser()
                             join ls1 in _userRepository.GetUserRoles() on ls.Id equals ls1.UserId
                             select new UserModel
                             {
                                 Id = ls.Id,
                                 FirstName = ls.FirstName,
                                 LastName = ls.LastName,
                                 Gender = ls.Gender,
                                 Relation = ls.Relation,
                                 RelationFirstname = ls.RelationFirstName,
                                 RelationLasttname = ls.RelationLastName,
                                 Email = ls.Email,
                                // StateID = ls.State,
                                 AssemblyConstituencyNo =(int)ls.AssemblyConstituencyId,
                                // Active=ls.Status,
                                 MobileNo = ls.MobileNo,
                                 AltMobileNo =ls.AltMobileNo,
                                // EpicId=ls.EPICId,
                                 Address=ls.Address,
                                 RoleId=(int)ls1.RoleId,
                                // PollingBoothID= (int)ls.PollingBoothId,
                                 Age=(int)ls.Age,
                                 //CommunityID= Convert.ToInt32(ls.CommunityName.ToString())
                                 
                             }).Where(u => u.Id == Id).FirstOrDefault();
                        

            }
            userModel.States = (from ls in _lookupRepository.GetStates()
                                select new clsState
                                {
                                    Text = ls.Name,
                                    Value = ls.ShortCode
                                }).ToList();


            userModel.AssemblyConstituencies = (from ls in _lookupRepository.GetAssemblyConstituencies()
                                                select new AssemblyConstituencies
                                                {
                                                    Text = ls.Name,
                                                    Value = ls.ACNo
                                                }
                                                ).ToList();

            userModel.CommunityList = (from ls in _lookupRepository.GetCommunityList()
                                       select new Community
                                       {
                                           Text =ls.Name,
                                           Value=(int)ls.Id

                                       }).ToList();

            userModel.RolesList = (from ls in _lookupRepository.GetRolesList()
                                   select new Roles
                                   {
                                       Text = ls.Name,
                                       Value=ls.Id
                                   }
                                  ).ToList();

            userModel.PollingboothList = (from ls in _lookupRepository.GetPollingStations()
                                   select new PollingBooth
                                   {
                                       Text = Convert.ToString(ls.StationNo) + "-" + ls.StationAddress,
                                       Value =(int)ls.Id
                                   }
                                  ).ToList();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult NewUser(UserModel model)
        {
            tblUserRole tUserRole = new tblUserRole();
            if (ModelState.IsValid)
            {
                tblUser tbluserEntities=new tblUser();
                tbluserEntities.Address = model.Address;
                tbluserEntities.AltMobileNo = model.AltMobileNo;
                //tbluserEntities.City = model.City;
                tbluserEntities.Email = model.Email;
                tbluserEntities.FirstName = model.FirstName;
                tbluserEntities.LastName = model.LastName;
                tbluserEntities.LoginPwd = model.LoginPwd;
                tbluserEntities.ParentUserId = 1;
               // tbluserEntities.PinCode = model.PinCode;
                tbluserEntities.MobileNo = model.MobileNo;
                //tbluserEntities.State = model.StateID;
                tbluserEntities.AssemblyConstituencyId = model.AssemblyConstituencyNo;
                tbluserEntities.Gender = model.Gender;
                tbluserEntities.Relation = model.Relation;
                tbluserEntities.RelationFirstName = model.RelationFirstname;
                tbluserEntities.RelationLastName = model.RelationLasttname;
               // tbluserEntities.Status = model.Active;
                tbluserEntities.LoginPwd = "XXXX";
                tbluserEntities.Age = model.Age;
               // tbluserEntities.EPICId = model.EpicId;
               // tbluserEntities.CommunityName = model.CommunityID.ToString();
               // tbluserEntities.PollingBoothId = model.PollingBoothID;

                long result = 0;
                if (model.Id > 0)
                {
                    tbluserEntities.Id = model.Id;

                    result = _userRepository.UpdateUser(tbluserEntities);

                    tUserRole.UserId = (int)result;
                    tUserRole.RoleId = model.RoleId;
                    _userRepository.UpdateUserRole(tUserRole);
                    ViewBag.ResultMessage = "User profile updated successfully.";
                }
                else
                {   
                    result = _userRepository.AddUser(tbluserEntities);
                    tUserRole.UserId = (int)result;
                    tUserRole.RoleId = model.RoleId;
                    _userRepository.AddUserRole(tUserRole);
                    ViewBag.ResultMessage = "User profile created successfully.";
                }
                if (result > 0)
                {
                    
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    TempData["Failed"] = "Failed";
                    return RedirectToAction("AddUser", "UserModel");
                }
            }
            return View(model);
        }

        public ActionResult DeleteUser(long Id)
        {
            if (Id > 0)
            {
                _userRepository.DeleteUser(Id);
            }
            return RedirectToAction("Index", "Login");
        }
    }
}