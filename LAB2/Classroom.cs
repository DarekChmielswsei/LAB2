using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
     class Classroom
    {
        private string name;
        private Person[] persons;
        public string Name
        {
            get => name;
            set { name = value; }  
        }

        public Classroom(string name, Person[] persons)
        {
            Name = name;
            this.persons = persons;
        }

        public override string ToString()
        {
            string personLists = "";
            foreach (Person p in persons)
            {
                personLists += p.ToString();
            }
            return "Classroom's name: " + Name + "\nPersons:\n\n" + personLists;
        }

    }
}
