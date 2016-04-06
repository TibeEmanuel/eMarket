using eMarket.Datalayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.BusinessLayer.ViewModels
{
    public class AnnouncementViewModel :ViewModel
    {

        public int AnnouncementId { get; set; }
        public DateTime PublishDate { get; set; }
        public int ProductId { get; set; }
               
    }


}
