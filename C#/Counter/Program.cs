using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {


            // Program should display multiples of inputted number between  1 and 200
            // if user inputs number out of range, program must display error message and terminate
            // loops must be used

            Console.WriteLine("Please enter a number between 1 and 200( to display its multiples)");
            int userInp = int.Parse(Console.ReadLine());
            int count = 0;
            while (count < 200)
            {
                count++;
                if (count % userInp == 0)
                {
                    Console.WriteLine("Multiple of {0}: " + count, userInp);
                }
                if (userInp > 200)
                {
                    Console.WriteLine("Error, Input is out of range...Exiting");
                    System.Environment.Exit(1);
                }
            }
            Console.ReadKey();



        }



    }
}
