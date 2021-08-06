using System;

namespace ConsoleApp3
{
    static class Program
    {
        static void Main(string[] args)
        {
            int A = 91;
            int B = 999;

            if (A != B)
            {
                if (A > B)
                    B = A;
                else if (B > A)
                    A = B;
            }
            else if (A == B)
            {
                A = 0;
                B = 0;
            }

            string numA = $"A = {A}";
            string numB = $"B = {B}";
            Console.WriteLine(numA);
            Console.WriteLine(numB);
            string FullName;
            string FirstName = "Dilnoza";
            string LastName = "Jaborzoda";
            FullName = FirstName + " " + LastName;
            Console.WriteLine($"{FirstName} {LastName}");
            
            //Task 3
            
            
            
        }
    }
}



