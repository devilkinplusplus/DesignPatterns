using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class JsonReader : ITextReader
    {
        public void ReadText() => Console.WriteLine("Reading text from json file..");
    }
}
