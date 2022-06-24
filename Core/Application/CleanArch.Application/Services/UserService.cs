using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services {
    public class UserService {

        private readonly IUserRepository _user;
        public UserService (IUserRepository user) {
            _user = user;
        }

        

    }
}