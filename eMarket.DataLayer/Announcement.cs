﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.DataLayer
{
    public class Announcement
    {
        public DateTime PublishDate { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
