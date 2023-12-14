using System.Text;
namespace WorkingWithStrings;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("I want \"quotes\"");
        Console.WriteLine("I want \nnew line");
        Console.WriteLine("Please use C:\\ drive");
        Console.WriteLine(@"Please use C:\ drive");
        Console.WriteLine(String.Format("{0} != {1}", "first", "second"));
        Console.WriteLine(String.Format("{0:C}", 123.45));
        Console.WriteLine(String.Format("{0:N}", 123456789));
        Console.WriteLine(String.Format("{0:P}",.123));
        Console.WriteLine(String.Format("{0:(###) ###-####}", 0123456789));

        string myString = " Jaisrith Tella ";
        Console.WriteLine(myString.Substring(6, 8));
        Console.WriteLine(myString.ToUpper());
        Console.WriteLine(myString.Replace(" ", "--"));
        Console.WriteLine(myString.Remove(6, 8));
        Console.WriteLine(String.Format("Before Length : {0} , After Length {1}", myString.Length, myString.Trim().Length));

        for (int i=1;i<100;i++)
        {
            myString += String.Format("--{0}", i);
        }
        Console.WriteLine(myString);

        StringBuilder myStringBuilder = new StringBuilder();
        for (int i = 1; i < 100; i++)
        {
            myStringBuilder.Append("--");
            myStringBuilder.Append(i);
        }
        Console.WriteLine(myStringBuilder);

        Console.ReadLine();
    }
}

