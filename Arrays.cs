using System;
using System.Linq;

namespace Arrays
{
    class Arrays
    {
        public string[] GetOldArray()
        {
            string[] cars = ["Volvo", "BMW", "Ford", "Mazda"];

            return cars;
        }

        public string[] GetModernArray()
        {
            return ["Volvo", "BMW", "Ford", "Mazda"];
        }

        public string[] GetSortedStringArray(string[] array)
        {
            Array.Sort(array);
            return array;
        }

        public int GetMaxValue(int[] numbers)
        {
            return numbers.Max();
        }

        public int GetNumbersSum(int[] numbers)
        {
            return numbers.Sum();
        }

        public int[,] GetMultidimensionalArray()
        {
            int[,] numbers =
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            return numbers;
        }
    }
}
