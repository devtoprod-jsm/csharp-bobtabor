using System.Net;

namespace LibraryReference;
public class LibRef
{
    public string scrapeWebpage(string url)
    {
        return getWebpage(url);
    }

    public string scrapeWebpage(string filepath,string url)
    {
        string reply = getWebpage(url);
        File.WriteAllText(filepath, reply);
        return reply;
    }

    private string getWebpage(string url)
    {
        WebClient client = new WebClient();
        return client.DownloadString(url);
    }
}

