using System;
using week4;
class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle();
        vehicle.Engine = "V6";
        vehicle.Model = "Ford";
        vehicle.NumberOfWheel = 5;
        vehicle.Price = 250000;
        vehicle.Transmission = "auto";

        Console.WriteLine(vehicle.ToString());

        Car car = new Car(2.4, "volvo", 6, 750000, "auto");


    }
}