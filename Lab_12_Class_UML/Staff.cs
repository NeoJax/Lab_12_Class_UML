using System;
namespace Lab_12_Class_UML
{
    public class Staff : Person
    {
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff(string name, string address) : base(name, address){ }

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.School = school;
            this.Pay = pay;
        }

        public override string ToString()
        {
            return $"Staff[Person[name={this.Name},address={this.Address}],school={this.School},pay={this.Pay}]";
        }
    }
}
