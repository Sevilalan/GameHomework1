using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework1
{
  public  interface ICampaingService
    {
        void Add(Campaing campaing);
        void Update(Campaing campaing);
        void Delete(Campaing campaing);
    }
}
