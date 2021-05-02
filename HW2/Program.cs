//Brighton Hill

using System;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your lucky number?");
            string input = Console.ReadLine();
            //int inputasint = Convert.ToInt32(Console.ReadLine());
            bool isnumber = Int32.TryParse(input, out int inputasint);

            Console.WriteLine($"is it an integer? {isnumber}");
            if (isnumber)
            {
                Console.WriteLine("Input is an integer!");
            }
            else
            {
                Console.WriteLine("Sorry fizzbuss proecess cannot be contnued because input is not a valid number");
            }
            Console.ReadLine();
            if (inputasint % 3 == 0 && inputasint % 5 == 0)

            {
                Console.WriteLine("divisible by 3 and 5");

            }
            else if (inputasint % 3 == 0)
            {
                Console.WriteLine("divisible by 3");

            }
            else if (inputasint % 5 == 0)
            {
                Console.WriteLine("divisible by 5");
            }
            else
            { Console.WriteLine(inputasint); }





        }
    }
}