using System;

namespace MultipleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {


            // program accepts an integer input
            // program counts integer input
            // program displays multiples of 9 alongside displayed count
            // program must use for-loop 

            Console.WriteLine("enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + n);
            for (int count = 1; count <= n; count++)
            {
                int muliplier = 9;
                int multipleCalculator = muliplier * count;
                char minusSign = '-';
                char commaSign = ',';
                Console.WriteLine(count + "{0}" + " " + "{1}" + multipleCalculator, commaSign, minusSign);
            }


            Console.ReadKey();

        }



    }
}

