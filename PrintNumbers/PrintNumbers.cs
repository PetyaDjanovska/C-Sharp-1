using System;

namespace PrintNumbers
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 101, 1001 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
