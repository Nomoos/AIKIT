using Moravia.Homework;

namespace AIKIT.Documents
{
    class FileSystemDocument : IDocument
    {
        private string _path;
        private DocumentTypes.IDocumentType _type;

        public FileSystemDocument(string path, DocumentTypes.IDocumentType type)
        {
            _path = path;
            _type = type;
        }
        public Document Load()
        {
            string input = File.ReadAllText(_path);
            Document doc = _type.Deserialize(input);
            return doc;
            //var xdoc = XDocument.Parse(input);
            //return new Document
            //{
            //    Title = xdoc.Root.Element("title").Value,
            //    Text = xdoc.Root.Element("text").Value
            //};
        }

        public void Save(Document doc)
        {
            string res = _type.Serialize(doc);
            File.WriteAllText(_path, res);
        }
    }
}