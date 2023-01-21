using Moravia.Homework;

namespace AIKIT.Documents
{
    interface IDocument
    {
        Document Load();
        void Save(Document doc);
    }
}