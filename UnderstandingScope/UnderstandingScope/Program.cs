namespace UnderstandingScope;
class Program
{
    private static string k = "";
    static void Main(string[] args)
    {
        string j = "";
        for (int i=1; i<11; i++)
        {
            Console.WriteLine(i);
            j = i.ToString();
            k = i.ToString();

        }
        Console.WriteLine("j outside the loop {0}", j);
        HelperMethod();
        Console.ReadLine();
        
    }

    private static void HelperMethod()
    {
        Console.WriteLine("k in helpermethod {0}", k);
    }
}

