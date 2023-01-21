using Moravia.Homework;
using Newtonsoft.Json;

namespace AIKIT.DocumentTypes
{
    public class JsonDocument : IDocumentType
    {
        public Document Deserialize(string input)
        {
            return JsonConvert.DeserializeObject<Document>(input);
        }

        public string Serialize(Document doc)
        {
            return JsonConvert.SerializeObject(doc);
        }
    }
}
