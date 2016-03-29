using eMarket.Datalayer.Entities;
using eMarket.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.BusinessLayer
{
    public class OrderByName : IOrderByName
    {
        IRepository _repo;

        public OrderByName(IRepository repo)
        {
            _repo = repo;
        }

        public List<Product> ProductByAscendingOrder()
        {
            var products = _repo.GetProducts()
                     .OrderByDescending(t => t.Name)
                     .Take(3).ToList();
            return products;
        }
    }
}

