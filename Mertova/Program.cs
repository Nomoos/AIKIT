using System;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace Moravia.Homework
{
    public class Document
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sourceFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\Source Files\\Document1.xml");
            var targetFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\Target Files\\Document1.json");

            try
            {
                var input = File.ReadAllText(sourceFileName);
                var xdoc = XDocument.Parse(input);
                var doc = new Document
                {
                    Title = xdoc.Root.Element("title").Value,
                    Text = xdoc.Root.Element("text").Value
                };

                var serializedDoc = JsonConvert.SerializeObject(doc);
                File.WriteAllText(targetFileName, serializedDoc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}