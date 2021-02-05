using System;

namespace GameHomework1
{
    class Program
    {
        static void Main(string[] args)
        {
            GammerManager gammerManager = new GammerManager(new NewEStateUserValidationManager());
            gammerManager.Update(new Gammer
            {
                
                BirthYear = 1997,
                FirstName = "SEVİL",
                LastName = "ALAN",
                IdentityNumber = 12345
            }
            );
            Console.WriteLine("****************************************************");

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(new Campaing
            {
                CampaingId = 1,
                CampaingName = "Bu ürünü alana İkincisi %50 indirimli",
                CampaingDetail = "Bu Kampanya 2021 EYLÜL sonuna kadar devam edecektir."
            });
            Console.WriteLine("****************************************************");

            OrderManager orderManager = new OrderManager();
            orderManager.SatısYap(new Product
            {
                ProductId = 1,
                ProductName = "OYUN5",
                UnitPrice = 1000,
                Stock = 300
            });
        }
    }
}
