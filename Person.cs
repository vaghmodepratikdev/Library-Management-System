using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public enum Gender { Female,Male};
    class Person
    {
        public string Name { get; private set; }
        public string Age { get; private set; }
        public Gender Sex { get; private set; }
        public bool IsHappy { get; set; }

        public Person(string name,string age, Gender gender, bool isHappy)
        {
            Name = name;
            Age = age;
            Sex = gender;
            IsHappy = isHappy;
        }
    }
}
