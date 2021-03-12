using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1989 && gamer.FirstName == "FATMA" && gamer.LastName == "UĞURLU" && gamer.IdentityNumber == 28873139696)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}