using AIKIT.Documents;
using AIKIT.DocumentTypes;
namespace Moravia.Homework
{
    class DocumentConverter
    {
        private IDocumentType _inputDocType;
        private IDocumentType _outputDocType;
        private IDocument _inputDoc;
        private IDocument _outputDoc;

        public DocumentConverter(string source, string target)
        {
            _inputDocType = GetDocumentType(source);
            _outputDocType = GetDocumentType(target);
            _inputDoc = GetDocument(source, _inputDocType);
            _outputDoc = GetDocument(source, _outputDocType);
        }
        public void Convert()
        {
            _outputDoc.Save(_inputDoc.Load());
        }

        private IDocument GetDocument(string path, IDocumentType _docType)
        {
            if (path.StartsWith("http"))
                return new HttpDocument(path, _docType);
            else
                return new FileSystemDocument(path, _docType);
        }

        private IDocumentType GetDocumentType(string path)
        {
            if (path.EndsWith(".json"))
                return new JsonDocument();
            else if (path.EndsWith(".xml"))
                return new XMLDocument();
            else
                throw new NotImplementedException();
        }
    }
}