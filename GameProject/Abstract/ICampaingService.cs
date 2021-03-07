using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICampaingService
    {
        void Add(Campaing campaing);
        void Delete(Campaing campaing);
        void Uptade(Campaing campaing);
    }
}
