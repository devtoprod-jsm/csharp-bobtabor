using System.Collections;

namespace WorkingWithColections;
class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.Make = "Toyota";
        car1.Model = "Corolla";
        car1.VIN = "C1";

        Car car2 = new Car();
        car2.Make = "Suzuki";
        car2.Model = "Swift";
        car2.VIN = "C2";

        Book book1 = new Book();
        book1.Title = "Harry Potter";
        book1.Author = "JKRowling";
        book1.Publisher = "Bloomsbury";

        /*
        // ArrayLists are dynamically sized
        //old type of collection, there is no way to limit datatypes to the arraylist.
        ArrayList myArrayList = new ArrayList();
        myArrayList.Add(car1);
        myArrayList.Add(car2);
        myArrayList.Add(book1);
        myArrayList.Remove(book1);
        foreach (Car car in myArrayList)
        {
            Console.WriteLine("{0}",car.Make);
        }
        */

        /*
        //Generic Collections allows us to add a specific datatype to a collection, generic list, List<T>.. ex: List<Car>
        List<Car> myCarList = new List<Car>();
        myCarList.Add(car1);
        myCarList.Add(car2);
        //myCarList.Add(book1);
        foreach (Car car in myCarList)
        {
            Console.WriteLine("{0}", car.Make);
        }
        */

        //Generic Dictionary , Dictionary<Tkey,TValue>

        //Object Initializer
        //Car car3 = new Car { Make = "BMW", Model = "X5", VIN = "c3" };
        //Console.WriteLine("{0}", car3.Make);

        //Collection with Object Initializer
        List<Car> myList = new List<Car>
        {
    new Car {Make = "BMW", Model = "X5", VIN = "c3" }
        };
        Console.WriteLine("{0}", myList[0].Make);
        Console.ReadLine();
    }
}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string VIN { get; set; }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }

}
