using eMarket.BusinessLayer.ViewModels;
using eMarket.DataLayer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.BusinessLayer.Queries
{
    public abstract class Query
    {
        public IRepositoryFactory RepositoryFactory { get; set; }
        public abstract ViewModel Execute();
      
    }
}
