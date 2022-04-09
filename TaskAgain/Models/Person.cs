using System;
using System.Collections.Generic;
using System.Text;

namespace TaskAgain.Models
{
    class Person
    {
        public string name;
        public string surName;
        public int age;
        public Person(string name, string surName, int age)
        {
            this.name = name;
            this.surName = surName;
            this.age = age;
        }
        public virtual string ShowInfo()
        {
            return $"Name: {name}\nSurname: {surName}\nAge: {age}";
        }
    }
}
