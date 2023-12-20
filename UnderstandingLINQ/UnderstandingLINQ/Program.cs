namespace UnderstandingLINQ;
class Program
{
    static void Main(string[] args)
    {
        List<Car> myCars = new List<Car>()
        {
new Car() { Make = "BMW", Model = "550i", StickerPrice = 55000, VIN = "C1", Year = 2009},
new Car() { Make = "Toyota", Model = "4Runner", StickerPrice = 35000, VIN = "C2", Year = 2010},
new Car() { Make = "BMW", Model = "745li", StickerPrice = 75000, VIN = "C3", Year = 2008},
new Car() { Make = "Ford", Model = "Escape", StickerPrice = 25000, VIN = "C4", Year = 2008 },
new Car() { Make = "BMW", Model = "55i", StickerPrice = 57000, VIN = "C5", Year = 2010},
        };
        //LINQ Query
        /*var bmws = from car in myCars
                   where car.Make == "BMW"
                   && car.Year == 2010
                   select car;
        */
        /*
        var orderedCars = from car in myCars
                          orderby car.Year descending
                          select car;
        */
        //LINQ Method
        var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
        /*foreach (var car in bmws)
        {
            Console.WriteLine("{0} {1}", car.VIN, car.Model);
        }
        */
        var orderedCars = myCars.OrderByDescending(p => p.Year);
        //var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
        //Console.WriteLine("{0} {1}", firstBMW.Make, firstBMW.VIN);

        //Console.WriteLine(myCars.TrueForAll(p => p.Year >= 2008));
        //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));
        //myCars.ForEach(p => p.StickerPrice -= 3000);
        //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

        //Console.WriteLine(myCars.Exists(p => p.Model == "745lie"));

        //Console.WriteLine("{0:C}",myCars.Sum(p => p.StickerPrice));

        Console.WriteLine(myCars.GetType());
        Console.WriteLine(orderedCars.GetType());
        Console.WriteLine(bmws.GetType());

        var newCars = from car in myCars
                      where car.Make == "BMW"
                      select new { car.Make, car.Model };
        Console.WriteLine(newCars.GetType());

           /*foreach (var car in orderedCars)
           {
               Console.WriteLine("{0} {1} {2}", car.VIN, car.Model,car.Year);
           }
           */
           Console.ReadLine();
    }
}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string VIN { get; set; }
    public int Year { get; set; }
    public double StickerPrice { get; set; }
}

