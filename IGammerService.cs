using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework1
{
   public interface IGammerService
    {
        void Add(Gammer gammer);
        void Update(Gammer gammer);
        void Delete(Gammer gammer);
    }
}
