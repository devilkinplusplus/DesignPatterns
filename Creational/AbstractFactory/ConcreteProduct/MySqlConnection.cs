using AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteProduct
{
    public class MySqlConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("Connecting to the MySql..");
            return true;
        }

        public override bool DisConnect()
        {
            Console.WriteLine("Disconnecting from the MySql..");
            return false;
        }
    }
}
