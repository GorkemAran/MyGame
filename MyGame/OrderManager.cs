using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class OrderManager : IOrderService
    {
        public void Add(Gamer gamer, Order order, Campaign campaign)
        {
            Console.WriteLine("Sayın " + gamer.FirstName + ", " + order.OrderName + " adlı " + order.Id + " numaralı satın alımınız gerçekleşmiştir.İlk siparişiniz olduğu için " + campaign.CampaignDetail + "kazandınız !");
        }

        public void Cancel(Gamer gamer, Order order)
        {
            Console.WriteLine("Sayın " + gamer.FirstName + ", " + order.Id + " numaralı siparişiniz iptal edilmiştir.");
        }

        public void Update(Gamer gamer, Order order)
        {
            Console.WriteLine("Sayın " + gamer.FirstName + ", " + order.Id + " numaralı siparişiniz güncellenmiştir.");
        }
    }
}
