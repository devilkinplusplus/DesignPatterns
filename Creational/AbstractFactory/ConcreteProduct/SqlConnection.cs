using AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteProduct
{
    public class SqlConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("Connecting to the Sql Server..");
            return true;
        }

        public override bool DisConnect()
        {
            Console.WriteLine("Disconnecting from the Sql Server..");
            return false;
        }
    }
}
