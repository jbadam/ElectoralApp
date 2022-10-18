using ElectoralApp.BAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.BAL.Repository.Code
{
    public class UserRepository : IUserRepository
    {

        private readonly electoraldbEntities _context;
        private bool disposedValue;

        public UserRepository(electoraldbEntities context)
        {
            _context = context;
        }
        public long AddUser(tblUser tblUserEntity)
        {
            long result = -1;

            if (tblUserEntity != null)
            {
                _context.tblUsers.Add(tblUserEntity);
                _context.SaveChanges();
                result = tblUserEntity.Id;
            }
            return result;
        }

        public int AddUserRole(tblUserRole tblUserRoleEntity)
        {
            int result = -1;

            if (tblUserRoleEntity != null)
            {
                _context.tblUserRoles.Add(tblUserRoleEntity);
                _context.SaveChanges();
                result = (int)tblUserRoleEntity.Id;
            }
            return result;
        }

        public int UpdateUserRole(tblUserRole tblUserRoleEntity)
        {
            int result = -1;

            if (tblUserRoleEntity != null)
            {
                tblUserRole tblURole = new tblUserRole();
                 tblURole = _context.tblUserRoles.Where(x=> x.UserId == tblUserRoleEntity.UserId).FirstOrDefault();
                tblURole.RoleId = tblUserRoleEntity.RoleId;
                _context.Entry(tblURole).State = EntityState.Modified;
                _context.SaveChanges();
                result =(int)tblUserRoleEntity.Id;
            }
            return result;
        }


        public void DeleteUser(long userId)
        {
            tblUser tblUserEntity = _context.tblUsers.Find(userId);
            _context.tblUsers.Remove(tblUserEntity);
            _context.SaveChanges();
        }

        public IEnumerable<tblUser> GetAllUser()
        {
            return _context.tblUsers.ToList();
        }
        public IEnumerable<tblUserRole> GetUserRoles()
        {
            return _context.tblUserRoles.ToList();
        }


        public tblUser GetUserById(int userId)
        {
            return _context.tblUsers.Find(userId);
        }

        public long UpdateUser(tblUser tblUserEntity)
        {
            long result = -1;

            if (tblUserEntity != null)
            {
                _context.Entry(tblUserEntity).State = EntityState.Modified;
                _context.SaveChanges();
                result = tblUserEntity.Id;
            }
            return result;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UserRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
