using System;

namespace ConsoleApplication1 
{
    class Program
    {
        delegate int Average(int x, int y, int z);

        static void Main(string[] args)
        {
            Average avg = delegate (int x, int y, int z)
            {
                return (x + y + z) / 3;
            };

            int result = avg(2, 4, 6);
            Console.WriteLine("Average: {0}", result);
        }
    }
}