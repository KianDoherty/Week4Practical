using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

public class Student
{
    // Private backing fields
    private int id;
    private string name;
    private int age;

    // Public properties
    public int Id
    {
        get { return id; }
        private set
        {
            if (value > 0)
            {
                id = value;
            }
            else
            {
                Console.WriteLine("Error: ID must be greater than zero.");
            }
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            // Ensure name does not contain any numbers
            if (!value.Any(char.IsDigit) && value != "")
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Error: Student name cannot be blank or contain numbers.");
            }
        }
    }


    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Constructor using standard C# casing conventions
    public Student(int studentId, string studentName, int studentAge)
    {
        this.Id = studentId;
        this.Name = studentName;
        this.Age = studentAge;
    }

    // Method to display information about a student
    public void DisplayInfo()
    {
        Console.WriteLine($"Student ID: {Id}");
        Console.WriteLine($"Student name: {Name}");
        Console.WriteLine($"Student age: {Age}");
        Console.WriteLine();
    }
}