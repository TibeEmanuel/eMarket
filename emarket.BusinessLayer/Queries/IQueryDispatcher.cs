using eMarket.BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.BusinessLayer.Queries
{
   public  interface IQueryDispatcher
    {
        TViewModel Execute<TViewModel>(Query query) where TViewModel : ViewModel; 
    }
}
