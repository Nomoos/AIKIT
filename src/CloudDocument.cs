namespace Moravia.Homework
{
    class CloudDocument : IDocument
    {
        private string _source;
        public CloudDocument(string source)
        {
            _source = source;
        }
        public Document Load()
        {
            // Code to read a document from a cloud storage service
            return new Document
            {
                Title = "Title",
                Text = "Text"
            };
        }

        public void Save(Document doc)
        {
            throw new NotImplementedException();
        }
    }
}