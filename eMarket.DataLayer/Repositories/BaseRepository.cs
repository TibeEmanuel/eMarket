using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMarket.Datalayer;
using eMarket.DataLayer.Entities;

namespace eMarket.DataLayer.Repositories
{
    public class BaseRepository 
    {
        private EmarketContext _context;


        public BaseRepository(EmarketContext context)
        {
            _context = context; 
        }

        public void Save<T>(T entity) where T : Entity
        {
            _context.Set<T>().Add(entity); 
        }
    }
}
