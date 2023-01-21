using Moravia.Homework;

namespace AIKIT.Documents
{
    public class HttpDocument : IDocument
    {
        private string _path;
        private DocumentTypes.IDocumentType _type;

        public HttpDocument(string path, DocumentTypes.IDocumentType type)
        {
            _path = path;
            _type = type;
        }
        public Document Load()
        {
            // Read a xml document from a website via HTTP
            HttpClient client = new();
            Document doc = _type.Deserialize(client.GetStringAsync(_path).Result);
            return doc;
        }

        public void Save(Document doc)
        {
        }
    }
}