using System;

namespace Properties_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars();
            car.Make = "Ford";
            car.Model = "Mustang";

            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            Cars car2 = new Cars();
            car2.Make = "Chevy";
            car2.Model = "Camero";

            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            Cars car3 = new Cars();
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");
           
        }
    }
}
