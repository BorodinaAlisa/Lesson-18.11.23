using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_2
{
    internal class Person
    {
        public string Name { get; set; }
        public string Hobby { get; set; }

        public Person(string name, string hobby)
        {
            Name = name;
            Hobby = hobby;
        }
    }
}
