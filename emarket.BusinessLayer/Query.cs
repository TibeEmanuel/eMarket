using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMarket.DataLayer.Repositories;
using eMarket.Datalayer; 

namespace emarket.BusinessLayer
{
    public class Query
    {

        public Query(IRepository _repo)
        {
            repository = _repo; 
        }
        public IRepository repository;

        public void AddElement()
        {
           
            var order = new Order()
            {
                Ordername = "New Order"
            }; 
            repository.Add(order); 
        }
    }
}
