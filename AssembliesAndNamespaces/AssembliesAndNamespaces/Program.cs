using System.Net;

namespace AssembliesAndNamespaces;
class Program
{
    static void Main(string[] args)
    {
        WebClient client = new WebClient();
        string reply = client.DownloadString("https://msdn.microsoft.com");
        //File.WriteAllText("/tmp",reply);
        Console.WriteLine(reply);
        Console.ReadLine();

    }
}

