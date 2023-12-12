namespace Decisions;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Jaisrith is giving away gifts!");
        Console.Write("Choose from 1,2 or 3: ");
        string choice = Console.ReadLine();

        string message = (choice == "1") ? "boat" : "Sorry";
        Console.WriteLine("You won a {0}",message);

        if(choice == "1")
        {
            Console.WriteLine("You won a car");
        }
        else if (choice == "2")
        {
            Console.WriteLine("You won a motorbike");
        }
        else if (choice == "3")
        {
            Console.WriteLine("You won a bicycle");
        }
        else
        {
            Console.WriteLine("Sorry wrong input");
        }
        Console.ReadLine();
    }
}

