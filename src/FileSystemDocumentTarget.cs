using Newtonsoft.Json;

namespace Moravia.Homework
{
    class FileSystemDocumentTarget : IDocumentTarget
    {
        private string _target;
        public FileSystemDocumentTarget(string target)
        {
            _target = target;
        }
        public void Write(Document doc)
        {
            var serializedDoc = JsonConvert.SerializeObject(doc);
            File.WriteAllText(_target, serializedDoc);
        }
    }
}