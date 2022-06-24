using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Data.Context;
using CleanArch.Domain.Entities.User;
using CleanArch.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EvaluationDBContext _ctx;
        public UserRepository(EvaluationDBContext ctx) => _ctx = ctx;

        public async Task<User> GetUser(int userId)
        {
            return await _ctx.Users.SingleOrDefaultAsync(u=>u.UserId == userId);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
             return await _ctx.Users.ToListAsync();
        }
    }
}