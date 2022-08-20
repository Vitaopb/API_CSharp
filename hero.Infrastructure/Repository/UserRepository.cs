using hero.Core.Entity;
using hero.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero.Infrastructure.Repository
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRepository(ApplicationDbContext db, UserManager<ApplicationUser> UserManeger)
        {
            _db = db;
            _userManager = UserManeger;
        }


    }
}
