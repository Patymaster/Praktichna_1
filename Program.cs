using System;

namespace ConsoleApplication1 
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> Add = (x, y) => x + y;
            Func<double, double, double> Sub = (x, y) => x - y;
            Func<double, double, double> Mul = (x, y) => x * y;
            Func<double, double, double> Div = (x, y) => y != 0 ? x / y : throw new DivideByZeroException();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Виберіть операцію:");
                Console.WriteLine("1. Додавання");
                Console.WriteLine("2. Віднімання");
                Console.WriteLine("3. Множення");
                Console.WriteLine("4. Ділення");
                Console.WriteLine("5. Вихід");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                {
                    // Вихід з програми
                    break;
                }

                // Введення чисел
                Console.Write("Введіть перше число: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введіть друге число: ");
                double y = double.Parse(Console.ReadLine());

                // Виконання операції
                Func<double, double, double> op;
                switch (choice)
                {
                    case 1:
                        op = Add;
                        break;
                    case 2:
                        op = Sub;
                        break;
                    case 3:
                        op = Mul;
                        break;
                    case 4:
                        op = Div;
                        break;
                    default:
                        Console.WriteLine("Неправильний вибір операції");
                        continue;
                }
                double result = op(x, y);

                // Виведення результату
                Console.WriteLine("Результат: {0}", result);
            }
        }
    }
}