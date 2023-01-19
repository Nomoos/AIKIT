using System;
using System.IO;

namespace Moravia.Homework
{

    class Program
    {
        static void Main(string[] args)
        {
            var source = "../../../Source Files/Document1.xml";
            var target = "../../../Target Files/Document1.json";
            var documentConverter = new DocumentConverter();
            documentConverter.Convert(source, target);
        }
    }
}