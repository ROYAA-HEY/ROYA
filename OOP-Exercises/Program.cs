using System;

class Program
{
    static void Main()
    {
        Customer customer = new Customer();

        customer.Name = "Roya";
        customer.Phone = "0919";

        Console.WriteLine(customer.Buy());
        Console.WriteLine(customer.Return());


        Student student = new Student();

        student.Name = "Roya";
        student.StudentNumber = 1404;
        student.Major = "Multimedia";

        Console.WriteLine(student.Study());
        Console.WriteLine(student.AttendClass());


        Teacher teacher = new Teacher();

        teacher.Name = "amir";
        teacher.Subject = "Programming";
        teacher.Experience = 5;

        Console.WriteLine(teacher.Teach());
        Console.WriteLine(teacher.GradeStudents());


        Employee employee = new Employee();

        employee.Name = "hani";
        employee.Position = "Designer";
        employee.Salary = 25000;

        Console.WriteLine(employee.Work());
        Console.WriteLine(employee.GetSalary());


        Rectangle rectangle = new Rectangle();

        rectangle.Width = 10;
        rectangle.Height = 5;

        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(rectangle.CalculatePerimeter());


        Square square = new Square();

        square.Side = 5;

        Console.WriteLine(square.CalculateArea());
        Console.WriteLine(square.CalculatePerimeter());


        Dog dog = new Dog();

        dog.Name = "bitaaa";
        dog.Breed = "pitbull";

        Console.WriteLine(dog.Bark());
        Console.WriteLine(dog.Eat());


        Cat cat = new Cat();

        cat.Name = "pastil";
        cat.Color = "gray";

        Console.WriteLine(cat.Meow());
        Console.WriteLine(cat.Sleep());
    }
}