using LibraryReference;

namespace CallLibraryReference;
class Program
{
    static void Main(string[] args)
    {
        LibRef refLib = new LibRef();
        string reply = refLib.scrapeWebpage("http://msdn.microsoft.com");
        Console.WriteLine(reply);
        Console.ReadLine();
    }
}

