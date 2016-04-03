using eMarket.BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eMarket.BusinessLayer.Queries
{
    public interface IQueryRepository
    {
     
         ViewModel Execute();
    }
}
