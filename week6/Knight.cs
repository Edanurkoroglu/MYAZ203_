using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    public class Knight : Character
    {
        private string _name;
        private int _healt;
        private int _stamina;
        private int _damage;

        public override string Name
        {
            get => _name;
            set => _name = value;
        }
        public override int Healt
        {
            get => _healt;
            set => _healt = value;
        }
        public override int Stamina
        {
            get => _stamina;
            set => _stamina = value;
        }
        public override int Damage
        {
            get => _damage;
            set => _damage = value;
        }


        public Knight(string name)
        {
            Name = name;
            Healt = 100;
            Stamina = 100;
            Damage = 10;
        }
        public override void Attack(ref int health)
        {
            if (Stamina > 0)
            {
                health = health - Damage;
                Stamina = Stamina - 20;
            }
            else
            {
                Console.WriteLine("you are tired...");
                Wait();
            }
        }

        public override void Wait()
        {
            if (Stamina <= 100)
                Stamina += 15;
        }
    }
}
