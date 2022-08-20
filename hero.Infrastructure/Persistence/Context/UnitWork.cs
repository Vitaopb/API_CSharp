using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero.Infrastructure.Persistence.Context
{
    public interface IUnitWork 
    {
        Task Commit();
        void Clear();
    }

    public class UnitWork : IUnitWork
    {
        private readonly ApplicationDbContext _db;

        public UnitWork(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Commit()
        {
            await _db.SaveChangesAsync();
        }
        public void Clear()
        { 
            _db.ChangeTracker.Clear();
        }
    }
}
