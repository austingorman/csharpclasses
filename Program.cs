using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        public List<Employee> Employees = new List<Employee>();

        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Title} {employee.StartTime}");
            }
        }
        // Create a public property for holding a list of current employees

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime dateCreated)
        {
            Name = name;
            CreatedOn = dateCreated;
        }
    }
    public class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public DateTime StartTime { get; }
        public Employee(string firstName, string lastName, string title, DateTime startTime)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartTime = startTime;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Company Dogger = new Company("Dogger", DateTime.Now);

            Employee Harvey = new Employee("Harvey", "Winchester", "Top Dog", DateTime.Now);
            Employee Hugo = new Employee("Hugo", "McDugo", "Number 2 Dog", DateTime.Now);
            Employee Gypsy = new Employee("Gypsy", "Wipsy", "Long Dog", DateTime.Now);

            Dogger.Employees.Add(Harvey);
            Dogger.Employees.Add(Hugo);
            Dogger.Employees.Add(Gypsy);

            Dogger.ListEmployees();


            // Create an instance of a company. Name it whatever you like.

            // Create three employees

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
