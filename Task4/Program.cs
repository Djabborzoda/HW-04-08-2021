using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = Convert.ToInt32(Console.ReadLine());
            if(Number >= 0 && Number <= 14) // 0-14
            {
                Console.WriteLine("[0-14]");
            } else if (Number >= 15 && Number <= 35)
            {
                Console.WriteLine("[15-35]");
            } else if (Number >= 36 && Number <= 50)
            {
                Console.WriteLine("[36-50]");
            } else if (Number >= 50 && Number <= 100)
            {
                Console.WriteLine("[50-100]");
            }
            else
            {
                Console.WriteLine("Uncorrect range");
            }
        }
    }
}
