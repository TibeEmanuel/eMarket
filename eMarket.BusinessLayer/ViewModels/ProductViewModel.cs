using eMarket.Datalayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.BusinessLayer.ViewModels
{
    public class ProductViewModel : ViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public int ProductCategoryId { get; set; }
        public IEnumerable<ProductCategoryViewModel> ProductCategories { get; set; }
        public string SellerId { get; set; }
        public List<int> ImageIds { get; set; }



        //// mapping productviewmodel to model
        //public static implicit operator ProductViewModel(Product product)
        //{
        //    var pvm = new ProductViewModel
        //    {
        //        ProductId = product.Id,
        //        Name = product.Name,
        //        Description = product.Description,
        //        ProductCategoryId = product.ProductCategoryId,
        //        SellerId = product.SellerId
        //    };

        //    return pvm;
        //}

        //// mapping product model to  productViewModel
        //public static implicit operator Product(ProductViewModel vm)
        //{
        //    var pm = new Product
        //    {
        //        Id = vm.ProductId,
        //        Name = vm.Name,
        //        Description = vm.Description,
        //        ProductCategoryId = vm.ProductCategoryId,
        //        SellerId = vm.SellerId
        //    };

        //    return pm;
        //}

    }


}
