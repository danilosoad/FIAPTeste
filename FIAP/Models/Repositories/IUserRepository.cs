﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Models.Repositories
{
    public interface IUserRepository
    {
        void Add(UserModel user);
        void Delete(UserModel user);
        IEnumerable<UserModel> GetUsers();
        UserModel GetUsersById(int id);
    }
}
