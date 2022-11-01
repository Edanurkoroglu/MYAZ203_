using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class Truck : Vehicle
    {
        private int _numberOfWheel;

        public override int NumberOfWheel
        {
            get { return _numberOfWheel; }
            set
            {
                if (value <= 12)
                    _numberOfWheel = 12;
                else
                    throw new Exception("invalid value");
            }
        }

        public Truck() { }

        public Truck(string engine, string model, int numberOfWheel, int price, string transmission)
        {
            Engine = engine;
            Model = model;
            NumberOfWheel = numberOfWheel;
            Price = price;
            Transmission = transmission;

        }
    }
}
