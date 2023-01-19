namespace Moravia.Homework
{
    class CloudDocumentSource : IDocumentSource
    {
        private string _source;
        public CloudDocumentSource(string source)
        {
            _source = source;
        }
        public Document Read()
        {
            // Code to read a document from a cloud storage service
            return new Document
            {
                Title = "Title",
                Text = "Text"
            };
        }
    }
}