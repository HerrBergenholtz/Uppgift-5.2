using System;

namespace Uppgift_5._2
{
    class Program
    {
        static void Main()
        {
            try
            {
                int[] tal = new int[3];
                tal[0] = 5; 
                tal[1] = 6;
                Console.WriteLine("Skriv in ett heltal");
                tal[2] = int.Parse(Console.ReadLine());

                foreach (int i in tal)
                {
                    Console.Write($"{i} ");
                }
            }
            catch
            {
                Console.WriteLine("Du gav fel input, pröva igen");
                Main();
            }
        }
    }
}