namespace SimpleClasses;
class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Make = "Suzuki";
        myCar.Model = "Swift";
        myCar.Year = 2018;
        myCar.Colour = "Blue";

        Console.WriteLine("{0} {1} {2} {3}",
            myCar.Make,
            myCar.Model,
            myCar.Year,
            myCar.Colour);
        Console.WriteLine("{0:C}", carValue(myCar));
        Console.WriteLine("{0:C}", myCar.determineMarketValue(myCar));
        Console.ReadLine();
    }

    private static decimal carValue(Car car)
    {
        decimal value = 100.0M;
        return value;
    }
}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Colour { get; set; }

    public decimal determineMarketValue(Car car)
    {
        decimal value;
        if (Year > 2010)
        {
            value = 2000;
        }
        else
        {
            value = 1000;
        }
        return value;
    }

}

