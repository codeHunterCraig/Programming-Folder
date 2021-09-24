using System;
namespace Methods
{
    class Program
    {
        static void Main()
        {
            // Question 4 //

            // program uses a switch case to run any of 4 programs
            // the 4 programs are private accesible methods


            string header = "SWITCH-CASE EXPERIMENT";
            string program_1 = "1. Fahrenheit to Celsius Converter";
            string program_2 = "2. Calculate Absolute of a Number";
            string program_3 = "3. Kg to Pounds Converter";
            string program_4 = "4. USD to ZAR Converter";
            int userInp;

            Console.WriteLine(header + "\n");
            Console.WriteLine("programs to choose from: " + "\n");
            Console.WriteLine(program_1);
            Console.WriteLine(program_2);
            Console.WriteLine(program_3);
            Console.WriteLine(program_4 + "\n");
            Console.WriteLine("enter number to choose program: ");
            userInp = int.Parse(Console.ReadLine());
            switch (userInp)
            {
                case 1:
                    Console.Clear();
                    double fahr;
                    Console.WriteLine("Fahrenheit to Celsius Converter" + "\n");
                    Console.WriteLine("enter temperature(Fahrenheit):");
                    fahr = double.Parse(Console.ReadLine());
                    Console.WriteLine("temperature in celsius: ");
                    Console.WriteLine(FahrToCels(fahr));
                    break;

                case 2:
                    Console.Clear();
                    int integer;
                    int absolute_val;
                    Console.WriteLine("Absolute number Calculator" + "\n");
                    Console.WriteLine("enter integer: ");
                    integer = int.Parse(Console.ReadLine());
                    absolute_val = AbsoluteNum(integer);
                    Console.WriteLine("absolute number of input is: {0}", absolute_val);
                    break;

                case 3:
                    Console.Clear();
                    double kg;
                    double pounds;
                    Console.WriteLine("Kg to Pounds Converter" + "\n");
                    Console.WriteLine("enter mass value(kg): ");
                    kg = double.Parse(Console.ReadLine());
                    pounds = KgToPounds(kg);
                    Console.WriteLine("mass in pounds is: {0}", pounds);
                    break;

                case 4:
                    Console.Clear();
                    double usd;
                    double zar;
                    Console.WriteLine("USD to ZAR Converter" + "\n");
                    Console.WriteLine("enter amount(USD currency): ");
                    usd = double.Parse(Console.ReadLine());
                    zar = UsdToZar(usd);
                    Console.WriteLine("amount in ZAR currency is: {0}", zar);
                    break;
                default:
                    Console.WriteLine("Choice out of range!!, choose again");
                    break;


            }

        }
        private static double FahrToCels(double temp) // converts from fahrenheit to celsius 
        {
            double temp_cels = (temp - 32) * 5 / 9;
            return (temp_cels);
        }
        private static int AbsoluteNum(int value) // calculates absolute value of number
        {
            int absolute_num = value - 0;
            int negative_exception = 0;
            if (absolute_num < 0)
            {
                negative_exception = absolute_num * -1;
                return negative_exception;
            }
            return absolute_num;

        }
        private static double KgToPounds(double kg_value) // converts from Kg to pounds
        {
            double pounds = kg_value * 2.205;
            return pounds;
        }
        private static double UsdToZar(double usd) // converts from USD to ZAR
        {
            double current_exchangeRate = 14.80;
            double zar = usd * current_exchangeRate;
            return zar;
        }
    }
}