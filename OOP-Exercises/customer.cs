class Customer
{
    public string Name { get; set; }
    public string Phone { get; set; }

    public string Buy()
    {
        return Name + " is buying.";
    }

    public string Return()
    {
        return Name + " returned the product.";
    }
}