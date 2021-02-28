using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "Görkem";
            gamer.LastName = "Aran";
            gamer.NationalityId = "01234567890";
            gamer.BirthDate = "1999";

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "İlk sipariş";
            campaign.CampaignDetail = "İlk siparişte %35 indirim ";
            
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            Order order = new Order();
            order.Id = 1;
            order.OrderName = "A oyunu satın alımı";

            OrderManager orderManager = new OrderManager();
            orderManager.Add(gamer, order, campaign);
            orderManager.Update(gamer, order);
            orderManager.Cancel(gamer, order);
        }
    }
}
