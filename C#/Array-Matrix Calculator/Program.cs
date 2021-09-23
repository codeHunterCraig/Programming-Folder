using System;
using System.Collections.Generic;
using System.Linq;
namespace ArrayMatrixCalculator
{
    class Program
    {
        static void Main()
        {
            /* QUESTION 2 */

            // Program must have a 4 x 3 array
            // The program must then display array as a matrix
            // Program must find difference between columns and rows in the matrix
            // Include optional user input 

            string minusSign = "             -";

            string header = "...MATRIX DIFFERENCE CALCULATOR...";
            Console.WriteLine(header + "\n");
            Console.WriteLine("Default Array for Program is: \n");
            // intial default array display
            int[] line1 = { 12, 23, 47 };
            int[] line2 = { 10, 34, 36 };
            int[] line3 = { 88, 52, 40 };
            int[] line4 = { 44, 32, 65 };
            // initial default matrix display
            int[] matrix1_line1 = { 12, 23, 47 };
            int[] matrix1_line2 = { 10, 34, 36 };
            int[] matrix2_line1 = { 88, 52, 40 };
            int[] matrix2_line2 = { 44, 32, 65 };

            foreach (int value in line1)
            {
                Console.Write(value + "  ");
            }
            Console.WriteLine();
            foreach (int value in line2)
            {
                Console.Write(value + "  ");
            }
            Console.WriteLine();
            foreach (int value in line3)
            {
                Console.Write(value + "  ");
            }
            Console.WriteLine();
            foreach (int value in line4)
            {
                Console.Write(value + "  ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Matrix Represention of Default Array: \n");

            foreach (int iterator in matrix1_line1)
            {
                Console.Write(iterator + "  ");
            }
            Console.Write("\t");
            foreach (int iterator in matrix2_line1)
            {
                Console.Write(iterator + "  ");
            }
            Console.WriteLine("\n" + minusSign);
            foreach (int iterator in matrix1_line2)
            {
                Console.Write(iterator + "  ");
            }
            Console.Write("\t");
            foreach (int iterator in matrix2_line2)
            {
                Console.Write(iterator + "  ");
            }
            Console.WriteLine("\n");

            // Default Matrix - Differance Calculation
            int ab_1, ab_2, ab_3, ab_4, ab_5, ab_6;
            ab_1 = matrix1_line1[0] - matrix2_line1[0];
            ab_2 = matrix1_line1[1] - matrix2_line1[1];
            ab_3 = matrix1_line1[2] - matrix2_line1[2];

            ab_4 = matrix1_line2[0] - matrix2_line2[0];
            ab_5 = matrix1_line2[1] - matrix2_line2[1];
            ab_6 = matrix1_line2[2] - matrix2_line2[2];
            Console.WriteLine("Difference of Default Matrix: \n");
            Console.Write(ab_1 + "\t");
            Console.Write(ab_2 + "\t");
            Console.Write(ab_3);
            Console.WriteLine("\n");
            Console.Write(ab_4 + "\t");
            Console.Write(ab_5 + "\t");
            Console.Write(ab_6);
            Console.WriteLine("\n");

            // Optional user Input 

            while (true)
            {
                Console.WriteLine("Do you want to calculate difference of another matrix(yes or no): \n");
                string userQuery = Console.ReadLine();
                if (userQuery == "no")
                {
                    Console.Clear();
                    Console.WriteLine("...Thank you for using the program...");
                    break;
                }
                if (userQuery == "yes")
                {
                    Console.Clear();
                    List<int> user_line1 = new List<int> { };
                    List<int> user_line2 = new List<int> { };
                    List<int> user_line3 = new List<int> { };
                    List<int> user_line4 = new List<int> { };
                    for (int input = 0; input < 3; input++)
                    {
                        Console.WriteLine("enter values for line 1 of array( 3 Values Max): ");
                        Console.WriteLine("(Input value and press Enter) \n");
                        int lineInp = int.Parse(Console.ReadLine());
                        user_line1.Add(lineInp);

                        Console.Clear();
                        Console.WriteLine("Inputed Values: " + string.Join(",", user_line1));
                    }
                    for (int input = 0; input < 3; input++)
                    {
                        Console.WriteLine("enter values for line 2 of array(3 Values Max): ");
                        Console.WriteLine("(Input value and press Enter) \n");
                        int lineInp = int.Parse(Console.ReadLine());
                        user_line2.Add(lineInp);

                        Console.Clear();
                        Console.WriteLine("Inputed Values: " + string.Join(",", user_line2));
                    }
                    for (int input = 0; input < 3; input++)
                    {
                        Console.WriteLine("enter values for line 3 of array(3 Values Max): ");
                        Console.WriteLine("(Input value and press Enter) \n");
                        int lineInp = int.Parse(Console.ReadLine());
                        user_line3.Add(lineInp);

                        Console.Clear();
                        Console.WriteLine("Inputed Values: " + string.Join(",", user_line3));
                    }
                    for (int input = 0; input < 3; input++)
                    {
                        Console.WriteLine("enter values for line 4 of array(3 Values Max: ");
                        Console.WriteLine("(Input value and press Enter) \n");
                        int lineInp = int.Parse(Console.ReadLine());
                        user_line4.Add(lineInp);

                        Console.Clear();
                        Console.WriteLine("Inputed Values: " + string.Join(",", user_line4));
                    }
                    Console.Clear();
                    Console.WriteLine("You entered the following Array: \n");
                    Console.WriteLine(string.Join(",", user_line1));
                    Console.WriteLine(string.Join(",", user_line2));
                    Console.WriteLine(string.Join(",", user_line3));
                    Console.WriteLine(string.Join(",", user_line4));
                    Console.WriteLine("\n");

                    // Type List to Type Array Conversion

                    user_line1.ToArray();
                    user_line2.ToArray();
                    user_line3.ToArray();
                    user_line4.ToArray();

                    // inputed Matrix display
                    string matrixInp_minus_sign = "            -";
                    Console.WriteLine("Array in Matrix (Diffferance Format): \n");

                    foreach (int value in user_line1)
                    {
                        Console.Write(value + "  ");
                    }
                    Console.Write("\t");
                    foreach (int value in user_line3)
                    {
                        Console.Write(value + "  ");
                    }
                    Console.WriteLine("\n" + matrixInp_minus_sign);

                    foreach (int value in user_line2)
                    {
                        Console.Write(value + "  ");
                    }
                    Console.Write("\t");
                    foreach (int value in user_line4)
                    {
                        Console.Write(value + "  ");
                    }
                    Console.WriteLine("\n");

                    // inputed Matrix Calculation
                    int diff_1, diff_2, diff_3, diff_4, diff_5, diff_6;

                    diff_1 = user_line1[0] - user_line3[0];
                    diff_2 = user_line1[1] - user_line3[1];
                    diff_3 = user_line1[2] - user_line3[2];

                    diff_4 = user_line2[0] - user_line4[0];
                    diff_5 = user_line2[1] - user_line4[1];
                    diff_6 = user_line2[2] - user_line4[2];

                    // calculated input matrix output

                    Console.WriteLine("Differance of Inputed Matrix is: \n");

                    Console.Write(diff_1 + "\t");
                    Console.Write(diff_2 + "\t");
                    Console.Write(diff_3);
                    Console.WriteLine("\n");
                    Console.Write(diff_4 + "\t");
                    Console.Write(diff_5 + "\t");
                    Console.Write(diff_6);
                    Console.WriteLine("\n");


                }



            }





        }
    }
}
