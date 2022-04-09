using System;
using TaskAgain.Models;

namespace TaskAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========PERSON==========");
            Person person = new Person("Anar","Qandayev",21);
            Console.WriteLine(person.ShowInfo());
            Console.WriteLine("===========EMPLOYEE==========");
            Employee employee = new Employee("Anar", "Qandayev", 21,1000);
            Console.WriteLine(employee.ShowInfo());
            Console.WriteLine("===========STUDENT==========");
            Student student = new Student("Anar","Qandayev",12,88.9,true);
            Console.WriteLine(student.ShowInfo());
        }
    }
}
