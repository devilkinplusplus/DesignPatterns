using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Creater
    {
        public Creater(KargoStrategy strategy)
        {
            strategy.Delivery();
        }
    }
}
