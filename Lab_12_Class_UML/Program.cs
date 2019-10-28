// ===============================
// AUTHOR     : Jonathan Lubaway
// CREATE DATE: October 28th, 2019
// PURPOSE    : Design the following classes based on the provided UML diagram.
// ===============================
using System;
using System.Collections.Generic;

namespace Lab_12_Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNewPerson();

            foreach (Person person in Person.GetPeople())
            {
                Console.WriteLine(person.ToString());
            }
        }

        public static bool GetInput(string message, string comparison1, string comparison2)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (input == comparison1)
            {
                return true;
            }
            else if (input == comparison2)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please provide a valid input.");
                return GetInput(message, comparison1, comparison2);
            }
        }

        public static void AddNewPerson()
        {
            if (GetInput("Would you like to add another person? (\"y\" or \"n\")", "y", "n"))
            {
                if (GetInput("Would you like to add another \"student\" or \"staff\" member?", "student", "staff"))
                {
                    AddNewStudent();
                }
                else
                {
                    AddNewStaff();
                }
            }
        }

        public static void AddNewStudent()
        {
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string program = Console.ReadLine();
            try
            {
                int year = int.Parse(Console.ReadLine());
                double fee = double.Parse(Console.ReadLine());
                Student newStudent = new Student(name, address, program, year, fee);
                Person.GetPeople().Add(newStudent);
                AddNewPerson();
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid number.");
                AddNewStudent();
            }
        }

        public static void AddNewStaff()
        {
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string school = Console.ReadLine();
            try
            {
                double pay = double.Parse(Console.ReadLine());
                Staff newStaff = new Staff(name, address, school, pay);
                Person.GetPeople().Add(newStaff);
                AddNewPerson();
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid number.");
                AddNewStudent();
            }
        }
    }
}
