interface IFirstInterface
{
    void FirstInterfaceMethod();
}

interface ISecondInterface
{
    void SecondInterfaceMethod();
}

class InterfaceImplementer : IFirstInterface, ISecondInterface
{
    public void FirstInterfaceMethod()
    {
        Console.WriteLine("First Interface Method");
    }

    public void SecondInterfaceMethod()
    {
        Console.WriteLine("Second Interface Method");
    }
}
