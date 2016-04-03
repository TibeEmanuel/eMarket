using eMarket.Datalayer.Entities;
using eMarket.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eMarket.API.Controllers
{
    public class ProductsDataController : ApiController
    {
        private BaseRepository _repository ;

        public ProductsDataController()
        {
            _repository = new BaseRepository();
        }

        public Product Get(int id)
        {
            return _repository.GetById<Product>(id);
        }
    }
}
