using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.DataLayer.Repositories
{
   public class TestRepostiory : IRepository
    {

        public void Add<T>(T Entity) where T : Datalayer.Entity
        {
            throw new NotImplementedException();
        }
    }
}
