using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //Metodları bir birine qoşaq
    public class XmlReaderAdapter : ITextReader
    {
        private readonly XmlReader reader;
        public XmlReaderAdapter(XmlReader reader)
        {
            this.reader = reader;
        }

        public void ReadText() => reader.ReadXml();

    }
}
