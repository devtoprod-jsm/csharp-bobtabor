namespace DateAndTime;
class Program
{
    static void Main(string[] args)
    {
        DateTime myDateTime = DateTime.Now;
        Console.WriteLine(myDateTime);
        Console.WriteLine(myDateTime.ToShortDateString());
        Console.WriteLine(myDateTime.ToShortTimeString());
        Console.WriteLine(myDateTime.ToLongDateString());
        Console.WriteLine(myDateTime.ToLongTimeString());
        Console.WriteLine(myDateTime.AddDays(3).ToLongDateString());
        Console.WriteLine(myDateTime.AddHours(3).ToLongTimeString());
        Console.WriteLine(myDateTime.AddDays(-3).ToLongDateString());
        Console.WriteLine(myDateTime.AddHours(-3).ToLongTimeString());
        Console.WriteLine(myDateTime.Month);

        DateTime myBirthDay = new DateTime(1987, 7, 28);
        Console.WriteLine(myBirthDay.ToLongDateString());

        DateTime myNewBirthDay = DateTime.Parse("12/08/1989");
        Console.WriteLine(myNewBirthDay.ToLongDateString());
        TimeSpan myAge = DateTime.Now.Subtract(myBirthDay);
        TimeSpan myNewAge = DateTime.Now.Subtract(myNewBirthDay);
        Console.WriteLine(myAge.TotalDays);
        Console.WriteLine(myNewAge.TotalDays);
        Console.ReadLine();
    }
}

