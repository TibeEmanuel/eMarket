using eMarket.Datalayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.DataLayer.Contract
{
    public interface IAnnouncementRepository
    {
        List<Announcement> GetAllAnnouncements();

    }
}
