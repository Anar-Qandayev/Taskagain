using System;
using System.Collections.Generic;
using System.Text;

namespace TaskAgain.Models
{
    class Student : Person
    {
        public bool excellent;
        public double overallAveragePoints;
        public Student(string name, string surName, int age, double overallAveragePoints,bool excellent) : base(name, surName, age)
        {
            this.overallAveragePoints = overallAveragePoints;
            this.excellent = excellent;
        }
        public override string ShowInfo()
        {
            if (age < 6 || age > 18) { return "Student cannot be  at this age!"; }
            if (overallAveragePoints < 90) { return "These points are not enough for Excellence"; }
            return base.ShowInfo() + $"\nOverall average points: {overallAveragePoints}\nIs it excellent?:{excellent}";
        }
    }
}
