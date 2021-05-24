using System;

namespace random_pi
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pi = 3.1415926535897932384626433m;
            Console.WriteLine("Valor de pi: " + pi);
            Random randomName = new Random();
            int random = randomName.Next(1, 25);
            Console.WriteLine("Número aleatório para as casas decimais: " + random);
            decimal pi_random = Math.Round(pi, random);
            Console.WriteLine("Estimativa do pi: " + pi_random);
        }
    }
}
