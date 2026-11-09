
using System;

// Create an interface named IQuittable.
// An interface defines methods that implementing classes must provide.
public interface IQuittable
{
    // Declare a void method named Quit().
    // This method does not return any value.
    void Quit();
}

// Create the Employee class and implement the IQuittable interface.
public class Employee : IQuittable
{
    // Declare a property to store the employee's first name.
    public string FirstName { get; set; }

    // Declare a property to store the employee's last name.
    public string LastName { get; set; }

    // Implement the Quit() method required by the IQuittable interface.
    public void Quit()
    {
        // Display a message when the employee quits.
        Console.WriteLine(FirstName + " " + LastName + " has quit the company.");
    }
}

// Create the main program class.
class Program
{
    // Main method is the starting point of the console application.
    static void Main(string[] args)
    {
        // Create an Employee object and assign employee details.
        Employee employee = new Employee();

        // Set the employee's first name.
        employee.FirstName = "John";

        // Set the employee's last name.
        employee.LastName = "Smith";

        // Use polymorphism to store the Employee object
        // in a variable of interface type IQuittable.
        IQuittable quittableEmployee = employee;

        // Call the Quit() method using the interface reference.
        quittableEmployee.Quit();

        // Keep the console window open until the user presses a key.
        Console.ReadLine();
    }
}
