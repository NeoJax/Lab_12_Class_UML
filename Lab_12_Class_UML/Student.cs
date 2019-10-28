using System;
namespace Lab_12_Class_UML
{
    // Defining a child of Person class, the Student class 
    public class Student : Person
    {
        #region fields
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }
        #endregion

        #region methods
        public Student(string name, string address) : base(name, address){ }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }

        public override string ToString()
        {
            return $"Student[Person[name={this.Name},address={this.Address}],program={this.Program},year={this.Year},fee={this.Fee}]";
        }
        #endregion
    }
}
