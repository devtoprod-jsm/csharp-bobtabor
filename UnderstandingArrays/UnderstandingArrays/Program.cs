namespace UnderstandingArrays;
class Program
{
    static void Main(string[] args)
    {
        // int[] numbers = new int[5];
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        string[] names = new string[] { "Mohan", "Sindhu", "Jaisrith" };
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        Array.Reverse(names);
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        char[] chararray = names[1].ToCharArray();
        Array.Reverse(chararray);
        foreach (char charname in chararray)
        {
            Console.Write(charname);
        }
        Console.ReadLine();
        
    }

   
}

