class Cat
{
    public string Name { get; set; }
    public string Color { get; set; }

    public string Meow()
    {
        return Name + " says Meow!";
    }

    public string Sleep()
    {
        return Name + " is sleeping.";
    }
}