using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Sisteme "+ "'" + campaign.CampaignName + "'" + " kampanyası eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Sistemden " + "'" + campaign.CampaignName + "'" + " kampanyası silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Sistemdeki " + "'" + campaign.CampaignName + "'" + " kampanyası güncellendi.");
        }
    }
}
