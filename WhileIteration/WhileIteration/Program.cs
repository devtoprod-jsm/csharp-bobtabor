 namespace WhileIteration;
class Program
{
    static void Main(string[] args)
    {
        bool displayMenu = true;
        
        while(displayMenu)
        {
            displayMenu = displayMainMenu();
        }

    }

    private static bool displayMainMenu()
    {
        Console.Clear();
        Console.WriteLine("Choose from one of the following:");
        Console.WriteLine("1 If you want to play Guessing Game");
        Console.WriteLine("2 If you want to PrintNumbers");
        Console.WriteLine("3 To exit the Menu");
        Console.WriteLine("Any other number to refresh the menu");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            guessingGame();
            return true;
        }
        else if (choice == "2")
        {
            printNumbers();
            return true;
        }
        else if (choice == "3")
        {
            return false;
        }
        else
        {
            return true;
        }
    }

        private static void guessingGame()
        {
        Console.Clear();
        Random myRandom = new Random();
        int randomNumber = myRandom.Next(1, 11);
        int guesses = 0;
        bool incorrect = true;
        do
        {
            Console.Write("Guess a number between 1 and 10: ");
            int choice = int.Parse(Console.ReadLine());
            guesses++;
            if (choice == randomNumber)
            {
                Console.WriteLine("Great that is correct");
                incorrect = false;
            }
            else
            {
                Console.WriteLine("Sorry");
            }

        } while (incorrect);

        Console.Write("You took {0} guesses", guesses);
        Console.ReadLine();
        }
        private static void printNumbers()
        {
        Console.Clear();
        Console.WriteLine("Give a number you want to print upto beginning from 1");
        int numberChose = int.Parse(Console.ReadLine());
        int counter = 1;
        while(counter < numberChose+1)
        {
            Console.Write(counter);
            Console.Write("-");
            counter++;
        }
        Console.ReadLine();
        }
}

