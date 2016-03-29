using System;
using System.Collections.Generic;
using eMarket.Datalayer.Entities;

namespace eMarket.BusinessLayer
{
    public interface IOrderByName
    {
        List<Product> ProductByAscendingOrder();
    }
}
