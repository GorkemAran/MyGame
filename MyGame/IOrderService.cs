using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    interface IOrderService
    {
        void Add(Gamer gamer, Order order,Campaign campaign);
        void Cancel(Gamer gamer, Order order);
        void Update(Gamer gamer, Order order);
    }
}
