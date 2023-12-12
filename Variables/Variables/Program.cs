namespace Variables;
class Program
{
    static void Main(string[] args)
    {
        /*
        int x;
        int y;
        x = 3;
        y = x + 9;
        Console.WriteLine(x + y);
        Console.ReadLine();
        */

        Console.WriteLine("What is your name?");

        string myFirstName;
        Console.Write("Your first name: ");
        myFirstName = Console.ReadLine();

        string myLastName;
        Console.Write("Your last name: ");
        myLastName = Console.ReadLine();

        Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
        Console.ReadLine();
    }
}

