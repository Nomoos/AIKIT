namespace Moravia.Homework
{
    class DocumentConverter
    {
        public void Convert(string source, string target)
        {
            IDocumentSource documentSource = GetDocumentSource(source);
            var doc = documentSource.Read();
            IDocumentTarget documentTarget = GetDocumentTarget(target);
            documentTarget.Write(doc);
        }

        private IDocumentSource GetDocumentSource(string source)
        {
            if (source.StartsWith("http"))
                return new HttpDocumentSource(source);
            else if (source.StartsWith("cloud"))
                return new CloudDocumentSource(source);
            else
                return new FileSystemDocumentSource(source);
        }

        private IDocumentTarget GetDocumentTarget(string target)
        {
            if (target.EndsWith(".json"))
                return new FileSystemDocumentTarget(target);
            else if (target.EndsWith(".xml"))
                return new CloudDocumentTarget(target);
            else
                return new HttpDocumentTarget(target);
        }
    }
}