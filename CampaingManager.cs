using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework1
{
    public class CampaingManager : ICampaingService
    {
       
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Kampanya eklendi"); ;
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Kampanya silindi"); ;
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
