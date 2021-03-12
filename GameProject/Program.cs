using GameProject.Concrete;
using GameProject.Entities;
using System;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1989,
                FirstName = "FATMA",
                LastName = "UĞURLU",
                IdentityNumber = 28873139696
            });

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(new Campaing
            {
                Id = 1,
                CampaingName = "Süper Teklif",
                CampaignDiscount = 20,
                CampaingDuration = "2gün",

            });

            OrderManager orderManager = new OrderManager(new CampaingManager());
            orderManager.CampaignOrder(new Order
            {
                Id = 1,
                Sale = "Nakit"
            });
            Console.WriteLine("Hello World!");
        }
    }
}