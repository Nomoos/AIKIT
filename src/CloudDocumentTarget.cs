namespace Moravia.Homework
{
    class CloudDocumentTarget : IDocumentTarget
    {
        private string _target;
        public CloudDocumentTarget(string target)
        {
            _target = target;
        }

        public void Write(Document doc)
        {
            // Code to write a document to a cloud storage service
        }
    }
}