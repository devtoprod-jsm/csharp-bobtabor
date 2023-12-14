namespace ObjectsConstructorsStatic;
class Program
{
    static void Main(string[] args)
    {
        //object variable is a reference to memory address

        Car myCar = new Car("Maruti","Swift","Blue",2018);
        Console.WriteLine(myCar);
        Car myCarRef = myCar;
        Console.WriteLine("{0} {1} {2} {3}", myCarRef.Make, myCarRef.Model, myCarRef.Colour, myCarRef.Year);
        Car.staticmethod();
        Console.ReadLine();
       
    }
}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Colour { get; set; }
    public int Year { get; set; }

    public Car(string make,string model, string colour,int year)
    {
        Make = make;
        Model = model;
        Colour = colour;
        Year = year;
    }

    public static void staticmethod()
    {
        Console.WriteLine("You called a static method");
    }
}
