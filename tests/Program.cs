using AIKIT.DocumentTypes;
using Moravia.Homework;

//test data
var jsonInput = "{\"Title\":\"Test 1\",\"Text\":\"Random text for the test.\"}";
var xmlInput = "<Document><Title>Test 1</Title><Text>Random text for the test.</Text></Document>";


//Test 1 Load json variable into document and check if the title is correct and text is correct

Document document = new JsonDocument().Deserialize(jsonInput);
if (document.Title == "Test 1" && document.Text == "Random text for the test.")
{
    Console.WriteLine("Test 1 passed");
}
else
{
    Console.WriteLine("Test 1 failed");
}

//Test 2 Load xml variable into document and check if the title is correct and text is correct

document = new XmlDocument().Deserialize(xmlInput);
if (document.Title == "Test 1" && document.Text == "Random text for the test.")
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
//Test 6 Load xml file into document and save it as xml file and check if the file is correct
//Test 7 Load json file from http and check if the title is correct and text is correct
//Test 8 Load xml file from http and check if the title is correct and text is correct


//Test 9 Load json file from http and save it as xml file and check if the file is correct
//Test 10 Load xml file from http and save it as json file and check if the file is correct
//Test 11 Load json file from http and save it as json file and check if the file is correct
//Test 12 Load xml file from http and save it as xml file and check if the file is correct
//Test 13 Load json file from file system and check if the title is correct and text is correct
//Test 14 Load xml file from file system and check if the title is correct and text is correct
//Test 15 Load json file from file system and save it as xml file and check if the file is correct