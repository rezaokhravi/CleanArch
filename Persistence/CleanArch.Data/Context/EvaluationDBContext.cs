using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Data.Context {
    public class EvaluationDBContext : DbContext {
        public EvaluationDBContext (DbContextOptions<EvaluationDBContext> options) : base (options) {

        }

        #region User

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        #endregion

    }
}