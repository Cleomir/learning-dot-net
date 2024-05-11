class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The pig says: oink oink");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog says: woof woof");
    }
}
