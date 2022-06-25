using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Entities;
using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Interfaces
{
    public interface IUserService
    {
        Task<ResponseViewModel> GetUser(int userId);

        Task<ResponseViewModel> AddUser(UserViewModel user);
    }
}