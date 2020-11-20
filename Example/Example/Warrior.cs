using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public class Warrior : Person
    {
        public int Damage { get; set; }

        public Warrior(string name, int id, int damage) : base(name, id)
        {
            Damage = damage;
        }

        public void Attack()
        {
            Console.WriteLine("Doing {0} damage", Damage);
        }
    }
}
