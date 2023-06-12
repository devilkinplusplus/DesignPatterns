using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //Bu class içerisindeki metodla interfeysdeki metod ferqlidir
    public class XmlReader
    {
        public void ReadXml() => Console.WriteLine("Reading text from xml file");
    }
}
