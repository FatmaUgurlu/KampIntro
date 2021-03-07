using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Abstract
{
    interface ICampaingService
    {
        void Add(Campaing campaing);
        void Delete(Campaing campaing);
        void Uptade(Campaing campaing);
    }
}
