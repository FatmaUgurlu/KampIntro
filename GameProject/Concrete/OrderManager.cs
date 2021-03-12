using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
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