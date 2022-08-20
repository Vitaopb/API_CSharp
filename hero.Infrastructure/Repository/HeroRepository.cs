using hero.Core.Entity;
using hero.Infrastructure.Persistence.Context;
using Horae.Infrastructure.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace hero.Infrastructure.Repository
{
    public class HeroRepository
    {
        private readonly ApplicationDbContext _db;

        public HeroRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public static IQueryable<Hero> GetIncludes(IQueryable<Hero> heros, params Expression<Func<Hero, object>>[] includes)
        {
            if (includes != null)
                heros = includes.Aggregate(heros, (current, include) => current.Include(include.AsPath()));

            return heros;
        }

        public async Task<Hero> AddASync(Hero entity)
        {
            await _db.Heroes.AddAsync(entity);
            return entity;
        }

        public Hero UpdateASync(Hero entity)
        {
            _db.Heroes.Update(entity);
            return entity;
        }

        public Hero DeleteAsync(Hero entity)
        {
            _db.Remove(entity);
            return entity;
        }

        public List<Hero> DeleteAllAsync(List<Hero> listEntity)
        {
            _db.RemoveRange(listEntity);
            return listEntity;
        }

        public async Task<IEnumerable<Hero>> GetAllAsync(params Expression<Func<Hero, object>>[] includes)
        {
            var result = _db.Heroes;
            return await GetIncludes(result, includes).ToListAsync();
        }       
    }
}
