namespace ExclusiveOpenFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = args[0];
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
            fs.ReadByte();
            Console.WriteLine("File \"{0}\" locked", path);
            Console.ReadKey();
            fs.Close();
        }
    }
}