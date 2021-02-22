using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Added..." + "  " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted..." + "  " + campaign.CampaignName);
        }

       
        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Updated..." + "  " +campaign.CampaignName);
        }
    }
}
