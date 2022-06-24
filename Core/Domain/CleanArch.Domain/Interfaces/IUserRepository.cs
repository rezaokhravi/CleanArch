using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Entities.User;

namespace CleanArch.Domain.Interfaces {
    public interface IUserRepository {
        Task<IEnumerable<User>> GetUsers ();
        Task<User> GetUser (int userId);
    }
}