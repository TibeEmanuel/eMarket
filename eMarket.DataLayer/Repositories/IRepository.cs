using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace eMarket.DataLayer.Repositories
{
    public interface IRepository
    {

        void Add<TModel>(TModel instance) where TModel : class;
       
    }
}
