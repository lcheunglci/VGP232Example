using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Person()
        {

        }

        public Person(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}
