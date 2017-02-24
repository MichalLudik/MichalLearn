using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Regex_example
{
    class Program
    {
        private const string Message = "--- Event 1 of 1:\r\n\r\nLog Name: Application\r\nSource: a8a0e681-aba5-458e-93a1-e54af2181f9c\r\nLogged: 10/11/2016 09:53:01\r\nEvent ID: 4281\r\nLevel: Error\r\nUser: \r\nComputer: DVB-MLUD-DEV\r\n\r\nAPM4281";

        static void Main()
        {
            var regex = new Regex(@"Log Name: ([\w\d]+)\r\nSource: ([\d\w-]+)\r\nLogged: .*\r\nEvent ID: (\d+)\r\nLevel: (\w+)\r\nUser:.*\r\nComputer: [\w\d-]+\s?\r\n\r\n(.*)", RegexOptions.Multiline);
            var messageGroups = regex.Match(Message);
            //var messageGroups = match.Groups;
            Assert.AreEqual("Application", messageGroups.Groups[1].ToString(), "Macro does not contain correct log name.");
            Assert.AreEqual("guid", messageGroups.Groups[2], "Macro does not contain correct log source.");
            Assert.AreEqual("4281", messageGroups.Groups[3], "Macro does not contain correct Event ID.");
            Assert.AreEqual("Error", messageGroups.Groups[4], "Macro does not contain correct Entry type.");
            Assert.AreEqual("APM4281", messageGroups.Groups[5], "Macro does not contain correct Message.");
            Console.ReadLine();
        }
    }
}
