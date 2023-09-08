using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Person
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }
    public decimal Salary { get; private set; }

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.LastName = lastName;
        this.FirstName = firstName;
        this.Age = age;
        this.Salary = salary;
    }


    public void IncreaseSalary(decimal percentage)
    {
        if (this.Age > 30)
        {
            this.Salary *= 1 + (percentage / 100.0M);
        }
        else
        {
            this.Salary += this.Salary * percentage / 200.0M;

        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} receives {this.Salary} leva.";
    }
}