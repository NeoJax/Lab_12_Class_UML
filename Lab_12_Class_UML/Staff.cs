using System;
namespace Lab_12_Class_UML
{
    // Defining a child of Person class, the Staff class 
    public class Staff : Person
    {
        #region fields
        public string School { get; set; }
        public double Pay { get; set; }
        #endregion

        #region methods
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
        #endregion
    }
}
