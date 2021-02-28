using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    //MicroService
    //Eğer manager sınıfları içerisinde başka bir manager sınıfını kullanacaksan ASLA newleme
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Sayın " + gamer.FirstName + ", başarıyla kayıt oldunuz");
            }
            else
            {
                Console.WriteLine("Yanlış bilgi girildi ! Lütfen bilgilerinizi kontrol ediniz.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Sayın " + gamer.FirstName + ", üyeliğiniz silinmiştir :(");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Sayın " + gamer.FirstName + ", bilgileriniz başarıyla güncellendi.");
        }
    }
}
