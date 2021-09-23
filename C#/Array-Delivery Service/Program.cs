using System;
using System.Linq;
namespace ArrayDeliveryService
{
    class Program
    {
        static void Main(string[] args)
        {
            // program should store 10 zip codes in an array
            // program shoould then prompt user to enter a zip code to see if their area is within the delivery radius

            int[] zip_codes = { 0221, 1400, 1465, 1619, 1490, 1500, 1559, 1682, 2001, 2052 };
            // Pretoria, Germiston, Boksburg, Kempton Park, Nigel, Benoni, Springs, Midrand, Johannesburg, Sandton

            string program_header = "                                            **** Bantu Delivery Service **** ";
            int userInp;


            Console.WriteLine(program_header.ToUpper());
            Console.WriteLine("\n");
            Console.WriteLine("Please enter the Postal code of the area you want us to deliver to: ");
            Console.WriteLine();
            Console.WriteLine("Postal Code: ");
            userInp = int.Parse(Console.ReadLine());


            if (zip_codes.Contains(userInp) == true)
            {
                Console.WriteLine("Good News!! your area is within the range of our delivery services");
            }
            if (zip_codes.Contains(userInp) == false)
            {
                Console.WriteLine(" Unfortunately your area is not within the range of our delivery services");
            }














        }


    }
}

