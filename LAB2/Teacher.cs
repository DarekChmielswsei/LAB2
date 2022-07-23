using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string ToString()
        {
            return "Teacher's name: " + Name + "\nTeacher's age: " + Age + "\n";
        }
    }
}
