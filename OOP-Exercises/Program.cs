using System;

class Customer
{
    public string Name { get; set; }
    public string Phone { get; set; }

    public void Buy()
    {
        Console.WriteLine(Name + " is buying.");
    }

    public void Return()
    {
        Console.WriteLine(Name + " returned the product.");
    }
}

class Student
{
    public string Name { get; set; }
    public int StudentNumber { get; set; }
    public string Major { get; set; }

    public void Study()
    {
        Console.WriteLine(Name + " is studying.");
    }

    public void AttendClass()
    {
        Console.WriteLine(Name + " is attending class.");
    }
}
class Teacher
{
    public string Name { get; set; }
    public string Subject { get; set; }
    public int Experience { get; set; }

    public void Teach()
    {
        Console.WriteLine(Name + " is teaching.");
    }

    public void GradeStudents()
    {
        Console.WriteLine(Name + " is grading students.");
    }
}
class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }

    public void Work()
    {
        Console.WriteLine(Name + " is working.");
    }

    public void GetSalary()
    {
        Console.WriteLine(Name + " received salary.");
    }
}
class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}
class Square
{
    public double Side { get; set; }

    public double CalculateArea()
    {
        return Side * Side;
    }

    public double CalculatePerimeter()
    {
        return 4 * Side;
    }
}

class Dog
{
    public string Name { get; set; }
    public string Breed { get; set; }

    public void Bark()
    {
        Console.WriteLine(Name + " says Woof!");
    }

    public void Eat()
    {
        Console.WriteLine(Name + " is eating.");
    }
}
class Program
{
    static void Main()
    {
        Customer customer = new Customer();

        customer.Name = "Roya";
        customer.Phone = "09123456789";

        customer.Buy();
        customer.Return();

        Student student = new Student();

        student.Name = "Roya";
        student.StudentNumber = 1404;
        student.Major = "Multimedia";

        student.Study();
        student.AttendClass();
        Teacher teacher = new Teacher();

teacher.Name = "Ali";
teacher.Subject = "Programming";
teacher.Experience = 5;

teacher.Teach();
teacher.GradeStudents();
  
  Employee employee = new Employee();

employee.Name = "Sara";
employee.Position = "Designer";
employee.Salary = 25000;

employee.Work();
employee.GetSalary();

Rectangle rectangle = new Rectangle();

rectangle.Width = 10;
rectangle.Height = 5;

Console.WriteLine("Rectangle area: " + rectangle.CalculateArea());
Console.WriteLine("Rectangle perimeter: " + rectangle.CalculatePerimeter());
   
   Square square = new Square();

square.Side = 5;

Console.WriteLine("Square area: " + square.CalculateArea());
Console.WriteLine("Square perimeter: " + square.CalculatePerimeter());
   
   Dog dog = new Dog();

dog.Name = "bitaaa";
dog.Breed = "pitbull";

dog.Bark();
dog.Eat();
   }
}