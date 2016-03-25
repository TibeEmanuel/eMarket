using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Datalayer
{
    public class Announcement 
    {
        [Key]
        public int AnnouncementId { get; set; }
        public DateTime PublishDate { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
