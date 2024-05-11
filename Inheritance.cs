class Vehicle
{
    public string brand = "Ford";

    public void Honk()
    {
        Console.WriteLine("Tuut, tuut");
    }
}

class Car : Vehicle
{
    public string modelName = "Mustang";
}
