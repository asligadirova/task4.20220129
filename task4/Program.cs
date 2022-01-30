using System;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.brand = "Hyundai";
            car1.model = "i30";
            car1.color = "gray";
            car1.price = 20900;

            //Console.WriteLine(car1.GetInfo());
           // Console.WriteLine("---------");
            Car car2 = new Car();
            car2.brand = "Fiat";
            car2.model = "500C";
            car2.color = "black";
            car2.price = 16000;
            //Console.WriteLine(car2.GetInfo());
            //Console.WriteLine("-------");

            Car[] cars = new Car[2];
            cars[0] = car1; 
            cars[1] = car2;

            foreach (var car in cars)
            {
                Console.WriteLine(car.GetInfo());
                
            }
            Console.WriteLine("--------");
            Car c1 = cars[0];
            Console.WriteLine(c1.GetInfo());

        }
    }
}
