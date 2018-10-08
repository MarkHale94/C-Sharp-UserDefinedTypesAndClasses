using System;
using System.Collections.Generic;

public class Company {

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public List<Employee> CurrentEmployees = new List<Employee> ();
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public Company (string name, DateTime date) {
        Name = name;
        CreatedOn = date;
    }

    public void ListEmployees(){
        int employeeNumber = 1;
        Console.WriteLine("These are the Employees of this Company");
        foreach(Employee employee in CurrentEmployees){
            Console.WriteLine($"{employeeNumber}. {employee.FirstName} {employee.LastName}");
            employeeNumber=employeeNumber+1;
        }
    }
    /*
    The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.
    */
}
public class Employee {
    /*
    Create a custom type for Employee. An employee has the following properties.
    First name (string)
    Last name (string)
    Title (string)
    Start date (DateTime)
    */
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public DateTime StartDate { get; }
    public Employee(string firstname, string lastname, string title, DateTime startdate ){
        FirstName = firstname;
        LastName = lastname;
        Title = title;
        StartDate = startdate;
    }
}

class Program {
    static void Main (string[] args) {
        // Create an instance of a company. Name it whatever you like.
        Company GreatCoffeeCo = new Company("GreatCoffeeCo",DateTime.Now);

        List<Employee> GreatCoffeeCoEmployees = new List <Employee>();

        // Create three employees

        Employee Rubber = new Employee("Rubber", "Duck", "Guidance Counselor", DateTime.Now);
        Employee Sam = new Employee("Sam", "Fisher", "Black Ops Bean Collector", DateTime.Now);
        Employee Big = new Employee("Big", "Roast", "Master Coffee Artisan", DateTime.Now);
        
        // Assign the employees to the company
        
        GreatCoffeeCoEmployees.Add(Rubber);
        GreatCoffeeCoEmployees.Add(Sam);
        GreatCoffeeCoEmployees.Add(Big);

        GreatCoffeeCo.CurrentEmployees = GreatCoffeeCoEmployees;
        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */

        GreatCoffeeCo.ListEmployees ();

    }
}