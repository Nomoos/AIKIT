namespace Moravia.Homework
{
    class HttpDocumentSource : IDocumentSource
    {
        private string _source;
        public HttpDocumentSource(string source)
        {
            _source = source;
        }
        public Document Read()
        {
            // Code to read a document from a website via HTTP
            return new Document
            {
                Title = "Title",
                Text = "Text"
            };
        }
    }
}