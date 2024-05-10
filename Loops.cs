namespace Loops
{
    class Loops
    {
        public void ForLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(i);
            }
        }

        public void WhileLoop()
        {
            int i = 0;
            while (i < 5)
            {
                System.Console.WriteLine(i);
                i++;
            }
        }

        public void DoWhileLoop()
        {
            int i = 0;
            do
            {
                System.Console.WriteLine(i);
                i++;
            } while (i < 5);
        }

        public void ForEachLoop()
        {
            // older syntax
            // string[] names = { "John", "Jane", "Jack" };
            // foreach (string name in names)
            // {
            //     System.Console.WriteLine(name);
            // }

            // newer syntax
            string[] cars = ["Volvo", "BMW", "Ford", "Mazda"];
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
