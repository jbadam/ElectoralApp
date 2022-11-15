using ElectoralApp.BAL.Repository.Model;
using ElectoralApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.BAL.Repository.Interfaces
{
    public interface IUserManager
    {
        IEnumerable<User> GetAllUser();
        User GetUserById(int userId);
        long AddUser(User UserEntity);
        long UpdateUser(User UserEntity);
        void DeleteUser(long userId);

        int AddUserRole(UserRole UserRoleEntity);

        int UpdateUserRole(UserRole UserRoleEntity);

        IEnumerable<UserRole> GetUserRoles();

    }
}
