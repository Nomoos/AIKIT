using AIKIT.Documents;
using AIKIT.DocumentTypes;
using Moravia.Homework;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        //test data
        var jsonInput = "{\"Title\":\"Test Title\",\"Text\":\"Random text for the test.\"}";
        var xmlInput = "<Document><Title>Test Title</Title><Text>Random text for the test.</Text></Document>";
        var httpJsonInput = "https://raw.githubusercontent.com/Nomoos/AIKIT/main/tests/TestData/Test.json";
        var httpXmlInput = "https://raw.githubusercontent.com/Nomoos/AIKIT/main/tests/TestData/Test.xml";
        var fileJsonInput = "../../../TestData/Test.json";
        var fileXmlInput = "../../../TestData/Test.xml";
        var fileJsonOutput = "../../../TestData/TestOutput.json";
        var fileXmlOutput = "../../../TestData/TestOutput.xml";


        //Test 1 Load json variable into document and check if the title is correct and text is correct

        Document document = new JsonDocument().Deserialize(jsonInput);
        if (document.Title == "Test Title" && document.Text == "Random text for the test.")
        {
            Console.WriteLine("Test 1 passed");
        }
        else
        {
            Console.WriteLine("Test 1 failed");
        }

        //Test 2 Load xml variable into document and check if the title is correct and text is correct

        document = new XmlDocument().Deserialize(xmlInput);
        if (document.Title == "Test Title" && document.Text == "Random text for the test.")
        {
            Console.WriteLine("Test 2 passed");
        }
        else
        {
            Console.WriteLine("Test 2 failed");
        }
        //Test 3 Load json variable into document and serialize it as xml variable and check if the variable is correct

        document = new JsonDocument().Deserialize(jsonInput);
        var xmlOutput = new XmlDocument().Serialize(document);
        if (xmlOutput == xmlInput)
        {
            Console.WriteLine("Test 3 passed");
        }
        else
        {
            Console.WriteLine("Test 3 failed");
        }

        //Test 4 Load xml variable into document and save it as json variable and check if the file is correct
        document = new XmlDocument().Deserialize(xmlInput);
        var jsonOutput = new JsonDocument().Serialize(document);
        if (jsonOutput == jsonInput)
        {
            Console.WriteLine("Test 4 passed");
        }
        else
        {
            Console.WriteLine("Test 4 failed");
        }
        //Test 5 Load json file into document and save it as json file and check if the file is correct
        document = new FileSystemDocument(fileJsonInput, new JsonDocument()).Load();
        new FileSystemDocument(fileJsonOutput, new JsonDocument()).Save(document);
        var document2 = new FileSystemDocument(fileJsonOutput, new JsonDocument()).Load();
        if (document.Title == document2.Title && document.Text == document2.Text)
        {
            Console.WriteLine("Test 5 passed");
        }
        else
        {
            Console.WriteLine("Test 5 failed");
        }
        //Test 6 Load xml file into document and save it as xml file and check if the file is correct
        document = new FileSystemDocument(fileXmlInput, new XmlDocument()).Load();
        new FileSystemDocument(fileXmlOutput, new XmlDocument()).Save(document);
        document2 = new FileSystemDocument(fileXmlOutput, new XmlDocument()).Load();
        if (document.Title == document2.Title && document.Text == document2.Text)
        {
            Console.WriteLine("Test 6 passed");
        }
        else
        {
            Console.WriteLine("Test 6 failed");
        }
        //Test 7 Load json file from http json input and check if the title is correct and text is correct
        document = new HttpDocument(httpJsonInput, new JsonDocument()).Load();
        if (document.Title == "Test 1" && document.Text == "Random text for the test.")
        {
            Console.WriteLine("Test 7 passed");
        }
        else
        {
            Console.WriteLine("Test 7 failed");
        }
        //Test 8 Load json file into document and save it as xml file and check if the file is correct
        document = new FileSystemDocument(fileJsonInput,new JsonDocument()).Load();
        if (document.Title == "Test 1" && document.Text == "Random text for the test.")
        {
            Console.WriteLine("Test 8 passed");
        }
        else
        {
            Console.WriteLine("Test 8 failed");
        }

        //Test 9 Load xml file into document and save it as json file and check if the file is correct
        document = new FileSystemDocument(fileXmlOutput, new XmlDocument()).Load();
        new FileSystemDocument(fileJsonOutput, new JsonDocument()).Save(document);
        document2 = new FileSystemDocument(fileJsonOutput, new JsonDocument()).Load();
        if (document.Title == document2.Title && document.Text == document2.Text)
        {
            Console.WriteLine("Test 9 passed");
        }
        else
        {
            Console.WriteLine("Test 9 failed");
        }
        //Test 10 Load json file into document and save it as xml file and check if the file is correct
        document = new FileSystemDocument(fileXmlOutput, new JsonDocument()).Load();
        new FileSystemDocument(fileJsonOutput, new XmlDocument()).Save(document);
        document2 = new FileSystemDocument(fileJsonOutput, new XmlDocument()).Load();
        if (document.Title == document2.Title && document.Text == document2.Text)
        {
            Console.WriteLine("Test 10 passed");
        }
        else
        {
            Console.WriteLine("Test 10 failed");
        }
        //Test 11 Load xml from http input xml and check if the title is correct and text is correct
        document = new HttpDocument(httpXmlInput, new XmlDocument()).Load();
        if (document.Title == "Test 1" && document.Text == "Random text for the test.")
        {
            Console.WriteLine("Test 11 passed");
        }
        else
        {
            Console.WriteLine("Test 11 failed");
        }
    }
}
