class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }

    public string Work()
    {
        return Name + " is working.";
    }

    public string GetSalary()
    {
        return Name + " received salary.";
    }
}