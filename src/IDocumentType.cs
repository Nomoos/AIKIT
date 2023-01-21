namespace Moravia.Homework
{
    public interface IDocumentType
    {
        Document Deserialize();
        void Serialize(Document doc);
    }
}