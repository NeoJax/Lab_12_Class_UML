using System;
using System.Collections.Generic;
namespace Lab_12_Class_UML
{
    public class Person
    {
        private static List<Person> _people = new List<Person>
        {
                new Student("John", "1234 Roadplace", "That one program", 1923, 1.52),
                new Student("Natasha", "That one place", "101 Things", 1930, 5.23),
                new Student("Brosef", "Fantasy land", "program", 1959, 3.21),
                new Staff("Mr. Professorson", "Education Town", "That one school", 10),
                new Staff("Mrs. Professorson", "Education Town", "That one school", 15)
        };

        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public override string ToString()
        {
            return "Person[name={this.Name},address={this.Address}]";
        }

        public static List<Person> GetPeople()
        {
            return _people;
        }
    }
}
