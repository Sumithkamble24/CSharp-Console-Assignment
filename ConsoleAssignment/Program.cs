using System;
class Student
{
    public string Name;       
    public int Age;
    public double Marks;

    public string GradeCalculation()
    {
        if (Marks >= 90)
        {
            return "A";
        }
        else if (Marks >= 75)
        {
            return "B";
        }
        else if (Marks >= 50)
        {
            return "C";
        }
        else
        {
            return "Fail";
        }
    }

    public void Result()
    {
        Console.WriteLine($"Student Name: {Name}");   
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Marks: {Marks}");
        Console.WriteLine($"Grade: {GradeCalculation()}");
    }
}

partial class Program
{
    static void Main(String[] args)
    {
        Student s = new Student();

        Console.Write("Enter Student Name: ");
        s.Name = Console.ReadLine();              

        Console.Write("Enter Student Age: ");
        s.Age = int.Parse(Console.ReadLine());

        Console.Write("Enter Student Marks: ");
        s.Marks = double.Parse(Console.ReadLine());  

        Console.WriteLine("");
        s.Result();
    }
}