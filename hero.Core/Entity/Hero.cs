using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero.Core.Entity
{
    public class Hero
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Power { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
