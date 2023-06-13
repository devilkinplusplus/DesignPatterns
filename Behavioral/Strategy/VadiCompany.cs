﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class VadiCompany : KargoStrategy
    {
        public override void Delivery() => Console.WriteLine("Vadi üzrə daşınma xərciniz 1kq üçün 3.99$ hesablanır");
    }
}
