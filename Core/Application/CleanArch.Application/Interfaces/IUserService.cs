using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Entities.User;

namespace CleanArch.Application.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUser (int userId);
    }
}