using Moravia.Homework;

namespace AIKIT.Documents
{
    class HttpDocument : IDocument
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
            //_sourceType.Deserialize(client.GetAsync(_source).Result.ToString());


            return new Document
            {
                Title = "Title",
                Text = "Text"
            };
        }

        public void Save(Document doc)
        {
        }
    }
}