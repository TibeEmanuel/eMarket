using eMarket.BusinessLayer.ViewModels;
using eMarket.Datalayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.BusinessLayer.Queries
{
    public class GetAllAnnouncementsQuery : Query
    {
           
        public override ViewModel Execute()
        {
            var container = new ListOfAnnouncementViewModel();
            var announcements = RepositoryFactory.AnnouncementRepsitory.GetAllAnnouncements();
            
            foreach (var ancmt in announcements)
            {
                container.ListOfannctViewModel.Add(new AnnouncementViewModel 
                                                { AnnouncementId = ancmt.Id, PublishDate = ancmt.PublishDate, 
                                                   ProductId = ancmt.ProductId });
            }

            return container;
        }

    }
}
