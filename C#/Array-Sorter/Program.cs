using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraySorter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Question 1*/

            // Program prompts user to enter 20 city names
            // program then stores city names in an array/ list
            // The program should then display inputed names in descending order

            List<string> city_names = new();
            string userInp;
            string user_query;
            // for statement & user input 
            for (int list_counter = 0; list_counter <= 20; list_counter++)
            {
                Console.WriteLine("Enter a city name(20 City names max): ");
                userInp = Console.ReadLine();
                city_names.Add(userInp);
                Console.Clear();

                // user-friendly condition statements
                if (list_counter == 4)
                {
                    Console.WriteLine("Do you want to continue?(yes or no): ");
                    user_query = Console.ReadLine();
                    if (user_query == "yes")
                    {
                        Console.Clear();
                        continue;

                    }
                    else if (user_query == "no")
                    {
                        Console.WriteLine("...THANK YOU FOR USING THE PROGRAM...\n");
                        break;
                    }
                }
                if (list_counter == 8)
                {
                    Console.WriteLine("Do you want to continue?(yes or no): ");
                    user_query = Console.ReadLine();
                    if (user_query == "yes")
                    {
                        Console.Clear();
                        continue;

                    }
                    else if (user_query == "no")
                    {
                        Console.WriteLine("...THANK YOU FOR USING THE PROGRAM...\n");
                        break;
                    }

                }
                if (list_counter == 12)
                {
                    Console.WriteLine("Do you want to continue?(yes or no): ");
                    user_query = Console.ReadLine();
                    if (user_query == "yes")
                    {
                        Console.Clear();
                        continue;

                    }
                    else if (user_query == "no")
                    {
                        Console.WriteLine("...THANK YOU FOR USING THE PROGRAM... \n");
                        break;
                    }
                }
            }
            //list-to-array conversion
            string[] convertedToArray = city_names.ToArray();
            Array.Sort(convertedToArray);
            Array.Reverse(convertedToArray);
            Console.WriteLine("You entered the following city names: \n");

            // array output
            foreach (string value in convertedToArray)
            {
                Console.WriteLine(value + " ");
            }


        }
    }
}

