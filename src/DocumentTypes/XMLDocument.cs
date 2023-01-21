using Moravia.Homework;
using System.Xml.Linq;

namespace AIKIT.DocumentTypes
{
    public class XmlDocument : IDocumentType
    {
        public Document Deserialize(string input)
        {
            var xDoc = XDocument.Parse(input);
            return new Document
            {
                Title = xDoc.Root.Element("Title").Value,
                Text = xDoc.Root.Element("Text").Value
            };
        }

        public string Serialize(Document doc)
        {
            return new XDocument(
                new XElement("Document",
                    new XElement("Title", doc.Title),
                    new XElement("Text", doc.Text)
                )
            ).ToString(SaveOptions.DisableFormatting);
        }
    }
}