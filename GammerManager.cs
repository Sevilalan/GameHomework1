using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework1
{
    public class GammerManager : IGammerService
    {
        IUserValidationService _userValidationService;
        public GammerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
       

        public void Add(Gammer gammer)
        {
            if (_userValidationService.Dogrula(gammer) == true)
            {
                Console.WriteLine("Kayıt başarılı !");

            }
            else
            {
                Console.WriteLine("Kayıt başarısız !");
            }
        }

        public void Delete(Gammer gammer)
        {
            Console.WriteLine("Kayıt silindi!");
        }

       

        public void Update(Gammer gammer)
        {
            Console.WriteLine("Kayıt güncellendi!");
        }
    }
}
