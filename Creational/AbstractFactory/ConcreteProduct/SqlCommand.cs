using AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteProduct
{
    public class SqlCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("Executing Sql command..");
        }
    }
}
