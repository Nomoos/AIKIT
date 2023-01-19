using System.Xml.Linq;

namespace Moravia.Homework
{
    class FileSystemDocumentSource : IDocumentSource
    {
        private string _source;
        public FileSystemDocumentSource(string source)
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
    }
}