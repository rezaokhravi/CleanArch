using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces {
    public interface IUserRepository {
        Task<IEnumerable<User>> GetUsers ();
        Task<User> GetUser (int userId);
        Task<User> AddUser (User user);
    }
}