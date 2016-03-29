using eMarket.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Datalayer.Entities
{
    public class Image : Entity 
    {
       
       public string ImageUrl { get; set; }

        
       public int ProductId { get; set; }

       [ForeignKey("ProductId")]
       public Product Product { get; set; }

       public ImageType ImageType { get; set; }

       
    }
   public enum ImageType
   {
       Large = 0,
       Small = 1,
   }
}
