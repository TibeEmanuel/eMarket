using eMarket.Datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.DataLayer.Repositories
{
    public class Repository : IRepository
    {
        public void Add<T>(T Entity) where T : Entity
        {
            throw new NotImplementedException();
        }
    }
}
