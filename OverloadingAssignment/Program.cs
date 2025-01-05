using System;

namespace EmployeeComparison
{
    // Define the Employee class
    public class Employee
    {
        // Define properties for the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the "==" operator to compare Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check for null values to avoid runtime errors
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return false;
            }
            // Compare the Id properties of the two Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator as the opposite of "=="
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the negation of the "==" operator
            return !(emp1 == emp2);
        }

        // Override Equals() to satisfy compiler requirements when overloading "=="
        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
            {
                return this.Id == emp.Id;
            }
            return false;
        }

        // Override GetHashCode() as it is recommended when Equals() is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    // Define the Program class to test the Employee class
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values to its properties
            Employee emp1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Instantiate the second Employee object and assign values to its properties
            Employee emp2 = new Employee
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Compare the two Employee objects using the overloaded "==" operator
            bool areEqual = emp1 == emp2;

            // Display the result of the comparison
            Console.WriteLine($"Are the two employees equal? {areEqual}");

            // Change the Id of the second employee to match the first
            emp2.Id = 1;

            // Compare the two Employee objects again
            areEqual = emp1 == emp2;

            // Display the updated result of the comparison
            Console.WriteLine($"Are the two employees equal after updating the Id? {areEqual}");
        }
    }
}
