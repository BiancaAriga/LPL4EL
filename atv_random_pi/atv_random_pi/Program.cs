using System;

namespace random_pi
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int acertos = 0;
            int n = 5000000;

            for (int i = 0; i < n; i++)
            {
                double x = random.NextDouble();
                double y = random.NextDouble();

                if (x * x + y * y < 1)
                {
                    acertos++;
                }
            }

            double pi = (4.0 * acertos / n);
            Console.WriteLine("O valor de pi é: " + pi);

        }
    }
}
