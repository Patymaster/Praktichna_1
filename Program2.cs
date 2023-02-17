using System;

namespace ConsoleApplication1 
{
    class Program
    {
        delegate int RandomNumberDelegate();

        static void Main()
        {
            RandomNumberDelegate[] delegates = new RandomNumberDelegate[5];

            // Заповнюємо масив з методами, які повертають випадкові значення типу int
            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = delegate { return new Random().Next(1, 101); };
            }

            // Створюємо анонімний метод, який приймає масив делегатів і повертає середнє арифметичне їх результатів
            Func<RandomNumberDelegate[], double> averageMethod = delegate (RandomNumberDelegate[] dels)
            {
                double sum = 0;
                foreach (RandomNumberDelegate del in dels)
                {
                    sum += del();
                }
                return sum / dels.Length;
            };

            // Викликаємо анонімний метод, передаючи йому масив делегатів
            double average = averageMethod(delegates);

            Console.WriteLine("Середнє арифметичне значення методів: " + average);
        }
    }
}