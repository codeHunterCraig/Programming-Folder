using System;
namespace fractionCalculator
{
    class Program
    {
        static void Main()
        {
            // Program prompts user to enter first fraction
            // Program prompts user to enter second fraction
            // Program calculates sum of two fractions
            // If applicable, program simplifies larger fractions

            int numerator1, numerator2, denominator1, denominator2, added_numerator = 0, added_denominator = 0;
            Console.WriteLine("FRACTION 1");
            Console.WriteLine("enter numerator(x): ");
            numerator1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter denominator(y): ");
            denominator1 = int.Parse(Console.ReadLine());

            Console.WriteLine("FRACTION 2");
            Console.WriteLine("enter numerator(x): ");
            numerator2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter denominator(y): ");
            denominator2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Fraction 1: {0}/{1}", numerator1, denominator1);
            Console.WriteLine("Fraction 2: {0}/{1}", numerator2, denominator2);
            if (denominator1 != denominator2)
            {
                added_numerator = (numerator1 * denominator2) + (numerator2 * denominator1);
                added_denominator = denominator1 * denominator2;
            }
            else if (denominator1 == denominator2)
            {
                added_numerator = numerator1 + numerator2;
                added_denominator = denominator1;
            }
            if (added_numerator % 2 == 0 && added_denominator % 2 == 0)
            {
                added_numerator = added_numerator / 2;
                added_denominator = added_denominator / 2;
            }

            Console.WriteLine("Sum of fractions is: {0}/{1}", added_numerator, added_denominator);
        }
    }
}


