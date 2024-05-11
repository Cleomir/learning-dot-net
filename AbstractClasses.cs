abstract class Pet
{
    public abstract void MakeSound();

    public void Sleep()
    {
        Console.WriteLine("Zzz");
    }
}

class Cat : Pet
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}
