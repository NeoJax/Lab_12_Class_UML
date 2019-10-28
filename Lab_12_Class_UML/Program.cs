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

            // Displays each person in the format given
            foreach (Person person in Person.GetPeople())
            {
                Console.WriteLine(person.ToString());
            }
        }

        // Determines whether a user wants the first or second comparisons
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

        // Determines if the user wants to add a new person, then if they want a student or staff member
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

        // This adds a new student
        public static void AddNewStudent()
        {
            Console.Write("Please enter a name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter an address: ");
            string address = Console.ReadLine();
            Console.Write("Please enter a program: ");
            string program = Console.ReadLine();

            // Try catch for format exceptions
            try
            {
                Console.Write("Please enter a year: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Please enter a fee the student must pay: ");
                double fee = double.Parse(Console.ReadLine());
                Student newStudent = new Student(name, address, program, year, fee);
                Person.AddPeople(newStudent);
                AddNewPerson();
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid number.");
                AddNewStudent();
            }
        }

        // This adds a new staff member
        public static void AddNewStaff()
        {
            Console.Write("Please enter a name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter an address: ");
            string address = Console.ReadLine();
            Console.Write("Please enter a school: ");
            string school = Console.ReadLine();

            // Try catch for format exceptions
            try
            {
                Console.Write("Please enter the amount the staff member is paid: ");
                double pay = double.Parse(Console.ReadLine());
                Staff newStaff = new Staff(name, address, school, pay);
                Person.AddPeople(newStaff);
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
