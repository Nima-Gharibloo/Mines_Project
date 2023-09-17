﻿using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : RepositoryBase<User, AccountsDbContext>, IUserRepository
    {
        private readonly AccountsDbContext _context;

        public UserRepository(AccountsDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User?> Get(string username, string password)
        {
            var users = await GetAll();
            var correspondingUser = users.SingleOrDefault(user => user.Username.ToLower() == username.ToLower() && user.Password == password);

            if (correspondingUser != null)
            {
                return correspondingUser;
            }
            return null;
        }
    }
}
