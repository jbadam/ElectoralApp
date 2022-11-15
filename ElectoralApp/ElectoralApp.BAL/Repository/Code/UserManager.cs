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
    
    public class UserManager
    {
        //private readonly ILookupRepository _lookRepository;
        private readonly IUserRepository _UserRepository;
        public UserManager(IUserRepository userRepository)
        { 
        
        }
    }
}
