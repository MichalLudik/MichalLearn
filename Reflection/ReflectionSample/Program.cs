using System.Reflection;

//https://app.pluralsight.com/course-player?clipId=efac8473-0d05-4cdc-b39e-0593f0f0cb2d

Console.Title = "Learning Reflection";

//string name = "Michal";
////var stringType = name.GetType();
//var stringType = typeof(string);
//Console.WriteLine(stringType);

var currentAssembly = Assembly.GetExecutingAssembly();
var types = currentAssembly.GetTypes();
foreach (var type in types)
{
    Console.WriteLine(type.Name);
}

var oneTypeFromCurrentAssembly = currentAssembly.GetType("ReflectionSample.Person");

Console.ReadLine();