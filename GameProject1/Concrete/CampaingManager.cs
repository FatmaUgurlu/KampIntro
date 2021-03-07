using GameProject1.Abstract;
using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Concrete
{
    class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Kampanya eklendi.");
        }


        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Uptade(Campaing campaing)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }

    }
}
