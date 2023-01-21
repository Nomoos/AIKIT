using System.Xml.Linq;

namespace Moravia.Homework
{
    class FileSystemDocument : IDocument
    {
        private string _source;
        public FileSystemDocument(string source)
        {
            _source = source;
        }
        public Document Read()
        {
            var input = File.ReadAllText(_source);
            var xdoc = XDocument.Parse(input);
            return new Document
            {
                Title = xdoc.Root.Element("title").Value,
                Text = xdoc.Root.Element("text").Value
            };
        }

        public void Write(Document doc)
        {
            throw new NotImplementedException();
        }
    }
}