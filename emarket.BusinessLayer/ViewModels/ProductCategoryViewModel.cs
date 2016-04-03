using eMarket.Datalayer;
using eMarket.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace eMarket.BusinessLayer.ViewModels
{
    public class ProductCategoryViewModel : ViewModel
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
