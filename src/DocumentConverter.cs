namespace Moravia.Homework
{
    class DocumentConverter
    {
        public void Convert(string source, string target)
        {
            IDocument documentSource = GetDocument(source);
            IDocumentType documentSourceType = GetDocumentType(source);
            var doc = documentSource.Read();
            IDocument documentTarget = GetDocument(target);
            IDocumentType documentTargetType = GetDocumentType(target);
            documentTarget.Write(doc);
        }

        private IDocument GetDocument(string path)
        {
            if (path.StartsWith("http"))
                return new HttpDocument(path);
            else if (path.StartsWith("cloud"))
                return new CloudDocument(path);
            else
                return new FileSystemDocument(path);
        }

        private IDocumentType GetDocumentType(string path)
        {
            if (path.EndsWith(".json"))
                return new FileSystemDocumentTarget(path);
            else if (path.EndsWith(".xml"))
                return new CloudDocumentTarget(path);
            else
                return new HttpDocumentTarget(path);
        }
    }
}