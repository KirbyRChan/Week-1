using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //count from 0 to 100, and print each number per line
            //allow user to give us upper bound and lower bound, validate
            //allow user to set conditions for multiples
            //if number is multiple of 3, print fizz
            //if number is multiple of 5, print buzz
            //if number is multiple of both, print fizzbuzz

            RunFizzBuzz(0, 100);
        }

        private void RunFizzBuzz(int a, int b)
        {
            do
            {
                Console.WriteLine("Please enter lower bound.");
                a = GetNumber();

                Console.WriteLine("Please enter upper bound.");
                b = GetNumber();

                if (a > b)
                {
                    Console.WriteLine("Please make sure upper bound is greater than lower bound.")
                }
            } while (a > b);

            Console.WriteLine("Choose multiple for fizz.");
            int fizzdiv = GetNumber();

            Console.WriteLine("Choose multiple for buzz.");
            int buzzdiv = GetNumber();

            for (var x = a; x <= b; x += 1)
            {
                PrintNumber(x);
            }
        }

        private int GetNumber()
        {
            var x = "";
            int value = 0;
            do
            {
                x = Console.ReadLine();
                if (int.TryParse(x, out value))
                {
                    Console.WriteLine("Please input a number.");
                }
            } while (!int.TryParse(x, out value));

            return value;
        }
        private void PrintNumber(int a)
        {
            if (a == 0)
            {
                WriteToConsole(a);
            }
            if (a % 3 == 0)
            {
                WriteToConsole(a);
            }
        }

        private void WriteToConsole()
        {

        }
    }
}
