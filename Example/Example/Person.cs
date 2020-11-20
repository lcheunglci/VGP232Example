﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public class Person
    {
        public string JobTitle { get; set; }
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

        public Person(string name, int id, string jobTitle)
        {
            Name = name;
            ID = id;
            JobTitle = jobTitle;
        }
    }
}
