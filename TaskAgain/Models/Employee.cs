using System;
using System.Collections.Generic;
using System.Text;

namespace TaskAgain.Models
{
    class Employee : Person
    {
        public int salary;
        public Employee(string name, string surName, int age, int salary) : base(name, surName, age)
        {
            this.salary = salary;
        }
        public override string ShowInfo()
        {
            if (salary < 250) { return "The salary cannot be less than 250 azn"; }
            else return base.ShowInfo() + $"\nSalary: {salary}";
        }
    }
}
