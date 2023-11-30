using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_2
{
    internal class Student
    {
        string name;
        int group;
        int counter = 0;
        public Student(string name, int group)
        {
            this.name = name;
            this.group = group;
        }
        public string Name
        {
            get { return name; }
        }
        public int Group
        {
            get { return group; }
        }
        public int Counter
        {
            get { return counter; }
            set { counter = value; }
        }
        public void TakePlace(Event e)
        {
            if (e.Stud.Count < e.NumbOfStudent - 1 && (e.Group == 0 || e.Group == group))
            {
                e.Stud.Add(this);
            }
        }
    }
}
