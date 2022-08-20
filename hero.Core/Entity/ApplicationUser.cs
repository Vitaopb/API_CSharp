using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace hero.Core.Entity
{
    public class ApplicationUser : IdentityUser<string>
    {
        [NotMapped]
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
