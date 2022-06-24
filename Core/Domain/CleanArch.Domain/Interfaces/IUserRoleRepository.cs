using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Entities.User;

namespace CleanArch.Domain.Interfaces
{
    public interface IUserRoleRepository
    {
         Task<IEnumerable<UserRole>> GetUserRoles();
         Task<UserRole> GetUserRole(int userRoleid);
    }
}