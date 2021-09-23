using System;
using System.Collections.Generic;

namespace MatrixComparer
{
    class Program
    {
        static void Main()
        {
            // QUESTION 3 //

            // program must accept two matrices
            // program must then tell user whether they are equal

            List<int> matrix_1 = new List<int> { };
            List<int> matrix_2 = new List<int> { };
            int userInp;

            Console.WriteLine("enter first value for first matrix");
            userInp = int.Parse(Console.ReadLine());
            matrix_1.Add(userInp);
            Console.Clear();
            Console.WriteLine("enter second value for first matrix");
            userInp = int.Parse(Console.ReadLine());
            matrix_1.Add(userInp);
            Console.Clear();

            Console.WriteLine("enter first value for second matrix");
            userInp = int.Parse(Console.ReadLine());
            matrix_2.Add(userInp);
            Console.Clear();
            Console.WriteLine("enter second value for second matrix");
            userInp = int.Parse(Console.ReadLine());
            matrix_2.Add(userInp);
            Console.Clear();

            matrix_1.ToArray();
            matrix_2.ToArray();

            Console.WriteLine("the first matrix is: ");
            Console.WriteLine();

            Console.WriteLine(matrix_1[0]);
            Console.WriteLine();
            Console.WriteLine(matrix_1[1]);
            Console.WriteLine();

            Console.WriteLine("the second matrix is: ");
            Console.WriteLine();

            Console.WriteLine(matrix_2[0]);
            Console.WriteLine();
            Console.WriteLine(matrix_2[1]);
            Console.WriteLine();

            if (matrix_1[0] > -1 && matrix_2[1] > -1)
            {
                Console.WriteLine("the inputed matrices can be compared");
            }

            else if (matrix_1[0] < -1 && matrix_2[1] < -1)
            {
                Console.WriteLine("the inputed matrices cannot be compared");
            }
            Console.WriteLine();

            if (matrix_1[0] == matrix_2[0] && matrix_1[1] == matrix_2[1])
            {
                Console.WriteLine("the matrices are equal");
            }
            else
            {
                Console.WriteLine("the matrices are not equal");
            }
        }
    }
}
