class Student
{
    public string Name { get; set; }
    public int StudentNumber { get; set; }
    public string Major { get; set; }

    public string Study()
    {
        return Name + " is studying.";
    }

    public string AttendClass()
    {
        return Name + " is attending class.";
    }
}