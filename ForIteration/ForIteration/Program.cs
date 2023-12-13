namespace ForIteration;
class Program
{
    static void Main(string[] args)
    {
        for(int i=1; i<=10; i++)
            {
            if (i%2 == 0)
            {
                continue;
                //Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine(i);
            }
            }
        Console.ReadLine();
    }
}

