﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Datalayer
{
    public class Announcement : Entity
    {
        public DateTime PublishDate { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
