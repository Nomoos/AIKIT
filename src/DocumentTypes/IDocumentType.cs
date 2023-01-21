using Moravia.Homework;

namespace AIKIT.DocumentTypes
{
    public interface IDocumentType
    {
        Document Deserialize(string input);
        string Serialize(Document doc);
    }
}