using eMarket.Datalayer;
using eMarket.DataLayer.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.DataLayer.Entities
{
    public class Subscription : Entity
    {
        public SubscriptionType SubscriptionType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
