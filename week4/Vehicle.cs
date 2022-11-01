using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class Vehicle
    {
        public string Engine { get; set; }
        public string Model { get; set; }
        public virtual int NumberOfWheel { get; set; }
        public int Price { get; set; }
        public string Transmission { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Engine Start...");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Engine Stop...");
        }

        public override string? ToString()
        {
            return $"Engine: {Engine}\n" +
                $"Model: {Model}\n" +
                $"Number ofnwheels: {NumberOfWheel}\n" +
                $"Price: {Price}\n" +
                $"Transmission: {Transmission}\n";
        }
    }
}
