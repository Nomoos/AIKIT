namespace Moravia.Homework
{
    class HttpDocumentTarget : IDocumentTarget
    {
        private string _target;
        public HttpDocumentTarget(string target)
        {
            _target = target;
        }

        public void Write(Document doc)
        {
            // Code to write a document to a website via HTTP
        }
    }
}