using Adapter;

JsonReader jsonReader = new();
jsonReader.ReadText();

XmlReader xmlReader = new();
ITextReader adapter = new XmlReaderAdapter(xmlReader);
adapter.ReadText();