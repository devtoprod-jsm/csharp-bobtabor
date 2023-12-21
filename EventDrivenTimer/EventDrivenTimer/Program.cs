namespace EventDrivenTimer;
class Program
{
    static void Main(string[] args)
    {
        System.Timers.Timer myTimer = new System.Timers.Timer(2000);
        myTimer.Elapsed += MyTimer_Elapsed;
        myTimer.Elapsed += MyTimer_Elapsed1;
        Console.WriteLine("Press enter to remove blue display");
        myTimer.Start();
        Console.ReadLine();
        myTimer.Elapsed -= MyTimer_Elapsed1;
        Console.ReadLine();
    }

    private static void MyTimer_Elapsed1(object? sender, System.Timers.ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Elapsed1: {0:hh:mm:ss.fff}", e.SignalTime);
    }

    private static void MyTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Elapsed: {0:hh:mm:ss.fff}",e.SignalTime);
    }
}