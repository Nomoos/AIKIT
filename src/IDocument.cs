namespace Moravia.Homework
{
    interface IDocument
    {
        Document Load();
        void Save(Document doc);
    }
}