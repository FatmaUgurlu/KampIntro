using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
   
    }
}
