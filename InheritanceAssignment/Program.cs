using System;

namespace AbstractClassDemo
{
    // Abstract class 'Person' serves as a base class
    public abstract class Person
    {
        // Define two properties for the first and last names
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        // Abstract method SayName() must be implemented by derived classes
        public abstract void SayName();
    }

    // Employee class inherits from the abstract class Person
    public class Employee : Person, IQuittable
    {
        // Override the abstract SayName() method from Person
        public override void SayName()
        {
            // Display the full name of the employee
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        // Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            // Display a message indicating the employee is quitting
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }

    // Define the IQuittable interface
    public interface IQuittable
    {
        // Define a void method called Quit()
        void Quit();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with sample first and last names
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the SayName() method on the Employee object
            employee.SayName();

            // Use polymorphism to create an IQuittable object
            IQuittable quittableEmployee = employee;

            // Call the Quit() method using the IQuittable object
            quittableEmployee.Quit();

            // Keep the console window open until the user presses a key
            Console.ReadLine();
        }
    }
}
