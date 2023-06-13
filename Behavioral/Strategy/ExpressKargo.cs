using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ExpressKargo : KargoStrategy
    {
        public override void Delivery() => Console.WriteLine("Express Kargo üzrə daşınma xərciniz 1kq üçün 3.49$ hesablanır");
    }
}
