class Dog
{
    public string Name { get; set; }
    public string Breed { get; set; }

    public string Bark()
    {
        return Name + " says Woof!";
    }

    public string Eat()
    {
        return Name + " is eating.";
    }
}