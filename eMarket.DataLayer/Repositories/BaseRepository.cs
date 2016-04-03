using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMarket.Datalayer;
using eMarket.DataLayer.Entities;
using System.Data.Entity;

namespace eMarket.DataLayer.Repositories
{
    public class BaseRepository
    {

        /////////////////////////////////////////////////////////////////////////////////////////

        public void AddOrUpdateEntity<TEntity>(TEntity entity) where TEntity : Entity
        {
            using (var _context = new EmarketContext())
            {
                if (entity.Id == 0)
                {
                    _context.Set<TEntity>().Add(entity);
                }
                else
                {
                    _context.Set<TEntity>().Attach(entity);
                    _context.Entry(entity).State = EntityState.Modified;
                }

                _context.SaveChanges();
            }
        }


         /////////////////////////////////////////////////////////////////////////////////////////

        public TEntity GetById<TEntity>(int id) where TEntity:Entity
        {
            using (var _context = new EmarketContext())
            {
                return _context.Set<TEntity>().FirstOrDefault(p => p.Id == id);
            }
            
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        public IQueryable<TEntity> Get<TEntity>(TEntity entity) where TEntity : Entity
        {
            using (var _context = new EmarketContext())
            {
                return _context.Set<TEntity>();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        public void Remove<TEntity>(TEntity entity) where TEntity:Entity
        {
            using (var _context = new EmarketContext())
            {
                _context.Entry<TEntity>(entity).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        public void RemoveById<TEntity>(int id) where TEntity : Entity
        {
            using (var _context = new EmarketContext())
            {
                TEntity entity = GetById<TEntity>(id);

                 _context.Entry<TEntity>(entity).State=EntityState.Deleted;
                 _context.SaveChanges();
            }
        }


    }
}
