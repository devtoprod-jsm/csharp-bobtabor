namespace Methods;
class Program
{
    static void Main(string[] args)
    {
        //helloworld();
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.Write("What is your city? ");
        string city = Console.ReadLine();

        displayResult(reverseString(firstName), reverseString(lastName), reverseString(city));
        Console.WriteLine("");
        displayResult((reverseString(firstName) + " " + reverseString(lastName ) + " " + reverseString(city)));

        Console.ReadLine();
        
    }
    private static string reverseString(string message)
    {
        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);
        return String.Concat(messageArray);
    }

    private static void displayResult(
        string firstName,
        string lastName,
        string city)
    {
        Console.Write(String.Format("{0} {1} {2}",
            firstName,
            lastName,
            city));
    }

    private static void displayResult(string message)
    {
        Console.Write(message);
    }
/*
    private static void helloworld()
    {
        Console.WriteLine("Hello World");
    }
*/
}

