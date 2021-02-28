using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthDate == "1999" && gamer.FirstName == "Görkem" && gamer.LastName == "Aran" && gamer.NationalityId == "01234567890")
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
