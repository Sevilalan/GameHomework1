using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework1
{
  public class Gammer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string LastName { get; internal set; }
        public int BirthYear { get; set; }
        public long IdentityNumber { get; set; }
    }
}
