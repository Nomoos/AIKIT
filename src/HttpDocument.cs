using System.ComponentModel;

namespace Moravia.Homework
{
    class HttpDocument : IDocument
    {
        private string _source;
        private IDocumentType _sourceType;

        public HttpDocument(string source, IDocumentType sourceType )
        {
            _source = source;
            _sourceType = sourceType;
        }
        public Document Read()
        {
            // Read a xml document from a website via HTTP
            HttpClient client = new();
            _sourceType.Deserialize(client.GetAsync(_source).Result.ToString());


            return new Document
            {
                Title = "Title",
                Text = "Text"
            };
        }

        public void Write(Document doc)
        {
        }
    }
}