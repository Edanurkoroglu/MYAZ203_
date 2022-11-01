using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    public abstract class Character
    {
        public abstract string Name { get; set; }
        public abstract int Healt { get; set; }

        public abstract int Stamina { get; set; }
        public abstract int Damage { get; set; }

        public abstract void Attack(ref int healt);
        public abstract void Wait();
    }
}
