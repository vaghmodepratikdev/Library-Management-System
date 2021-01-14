using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    static class PersonManager
    {
        public static List<Person> allPeople = new List<Person>()
                                                {new Person("Shipra","28",Gender.Female,true), 
                                                new Person("Gupta","22",Gender.Male,true) };
    }
}
