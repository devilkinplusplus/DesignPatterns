using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class KargoEx : KargoStrategy
    {
        public override void Delivery() => Console.WriteLine("KargoEx üzrə daşınma xərciniz 1kq üçün 2.99$ hesablanır");
    }
}
