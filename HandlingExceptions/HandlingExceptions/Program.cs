namespace HandlingExceptions;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            String content = File.ReadAllText(@"/Users/mohantella/Documents/github-recovery-codes.tx");
            Console.WriteLine(content);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Path is wrong. Please verify the path");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            //Code to Finalize
            //Setting objects to null
            //Closing database connections
            Console.WriteLine("Finally...!!!");
        }
        Console.ReadLine();
    }
   
}

