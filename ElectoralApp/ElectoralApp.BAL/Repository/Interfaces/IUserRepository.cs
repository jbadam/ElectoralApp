using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.BAL.Repository.Interfaces
{
    public interface IUserRepository: IDisposable
    {
        IEnumerable<tblUser> GetAllUser();
        tblUser GetUserById(int userId);
        long AddUser(tblUser tblUserEntity);
        long UpdateUser(tblUser tblUserEntity);
        void DeleteUser(long userId);

        int AddUserRole(tblUserRole tblUserRoleEntity);

        int UpdateUserRole(tblUserRole tblUserRoleEntity);

        IEnumerable<tblUserRole> GetUserRoles();
    }
}
