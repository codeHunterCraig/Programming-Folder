using System;
using System.Linq;

namespace VowelCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 2 //

            // Program must recieve input(phrase) from user
            // Program must count amount of vowels in the phrase(both uppercase and lowercase)
            // Program should not count non-vowel letters

            string user_input;
            Console.WriteLine("enter your phrase: ");
            user_input = Console.ReadLine();


            int count = 0;
            foreach (char value in user_input)
            {
                if (value == 'a' || value == 'A')
                {
                    count++;
                }
                if (value == 'e' || value == 'E')
                {
                    count++;
                }
                if (value == 'i' || value == 'I')
                {
                    count++;
                }
                if (value == 'o' || value == 'O')
                {
                    count++;
                }
                if (value == 'u' || value == 'U')
                {
                    count++;
                }


            }
            Console.WriteLine("inputed phrase had {0} vowels", count);

        }
    }
}
