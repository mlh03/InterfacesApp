using System;

namespace testPro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Truck truck1 = new Truck();
            truck1.HasBackTrunk = true;
            truck1.Height = 8;
            truck1.Make = "Ford";
            truck1.Model = "F150";
            truck1.Logo = "Ram";
            truck1.Motto = "Built ford proud.";
            truck1.Year = 2021;

            Suv suv1 = new Suv();

            suv1.SevenSeater = true;
            suv1.MiddleSeat = true;
            suv1.Make = "honda";
            suv1.Model = "oddyse";
            suv1.Logo = "H";
            suv1.Motto = "Honda on the road";
            suv1.Year = 2021;


            Car car1 = new Car();
            Console.WriteLine("What is the make of your car?");
            car1.Make = Console.ReadLine();
            Console.WriteLine("What is the model of your car?");
            car1.Model = Console.ReadLine();
            Console.WriteLine("What year is your car?");
            car1.Year = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your car logo?");
            car1.Logo = Console.ReadLine();
            Console.WriteLine("What is your car motto?");
            car1.Motto = Console.ReadLine();

            Console.WriteLine($"The {car1.Year} {car1.Make} {car1.Model} the logo is a(n) {car1.Logo}, and the motto is {car1.Motto}");
        }
    }
}
