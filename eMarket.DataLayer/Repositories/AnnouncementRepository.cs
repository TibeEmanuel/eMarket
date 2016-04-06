using eMarket.Datalayer.Entities;
using eMarket.DataLayer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.DataLayer.Repositories
{
    public class AnnouncementRepository : BaseRepository, IAnnouncementRepository
    {
        public List<Announcement> GetAllAnnouncements()
        {
            return Get<Announcement>().ToList();

        }

    }
}
