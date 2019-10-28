using System;
using System.Collections.Generic;
namespace Lab_12_Class_UML
{
    // Defining a new class called Person
    public class Person
    {
        // Making an internal list
        private static List<Person> _people = new List<Person>
        {
                new Student("John", "1234 Roadplace", "That one program", 1923, 1.52),
                new Student("Natasha", "That one place", "101 Things", 1930, 5.23),
                new Student("Brosef", "Fantasy land", "program", 1959, 3.21),
                new Staff("Mr. Professorson", "Education Town", "That one school", 10),
                new Staff("Mrs. Professorson", "Education Town", "That one school", 15)
        };

        #region fields
        public string Name { get; set; }
        public string Address { get; set; }
        #endregion

        #region methods
        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        // Allows Person class to display its current attributes
        public override string ToString()
        {
            return "Person[name={this.Name},address={this.Address}]";
        }

        // Returns our private List
        public static List<Person> GetPeople()
        {
            return _people;
        }

        // Adds to our List
        public static void AddPeople(Person input)
        {
            _people.Add(input);
        }
        #endregion
    }
}
