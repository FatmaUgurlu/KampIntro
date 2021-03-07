using GameProject1.Abstract;
using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Concrete
{
    class OrderManager : IOrderService
    {
        IOrderService _orderService;

        public OrderManager(IOrderService orderService)
        {
            _orderService = orderService;
        }

        private CampaingManager campaingManager;

        public OrderManager(CampaingManager campaingManager)
        {
            this.campaingManager = campaingManager;
        }

        public void CampaignOrder(Order order)
        {
            Console.WriteLine("Kampanya satışı tamamlandı.");
        }
    }
}
