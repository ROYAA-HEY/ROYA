class Teacher
{
    public string Name { get; set; }
    public string Subject { get; set; }
    public int Experience { get; set; }

    public string Teach()
    {
        return Name + " is teaching.";
    }

    public string GradeStudents()
    {
        return Name + " is grading students.";
    }
}