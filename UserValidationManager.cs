using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework1
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Dogrula(Gammer gammer)
        {
            if (gammer.BirthYear==1997 && gammer.FirstName=="SEVİL" && gammer.IdentityNumber==12345)
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
