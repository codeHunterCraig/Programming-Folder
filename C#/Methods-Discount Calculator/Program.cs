using System;
using System.Collections.Generic;
using System.Linq;

namespace DiscountCalculator
{
    class Program
    {
        static void Main()
        {
            // method name should be called DiscountMethod()
            // method should give a discount based on the following:
            // price is less than R300 = No Discount
            // price is between R300 and R500 = 10% Discount
            // price is between R500 and R1000 = 15% Discount
            // price is above R1000 = 35% Discount

            List<double> price_list = new List<double> { };
            string header = "                                                    Price Calculator \n";
            char randSymbol = 'R';
            string userQuery;
            double userPrice;
            double priceTotal;
            Console.WriteLine(header.ToUpper());
            while (true)
            {
                Console.WriteLine("enter price of product: \n");
                userPrice = double.Parse(Console.ReadLine());
                price_list.Add(userPrice);
                priceTotal = price_list.Sum();
                Console.Clear();
                Console.WriteLine("price total: {0} {1}", randSymbol, priceTotal);
                Console.WriteLine();
                if(price_list.Count == 8)
                {
                    Console.WriteLine("would you like to continue?(yes or no)");
                    userQuery = Console.ReadLine();
                    if(userQuery == "yes")
                    {
                        continue;
                    }
                    if(userQuery == "no")
                    {
                        if (price_list.Sum() > 300)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" product total exceeds 300, you apply for a discount \n");
                        }
                        Console.WriteLine("your total price is: {0} {1} ", randSymbol, DiscountMethod(priceTotal));
                        Console.WriteLine();
                        Environment.Exit(0);

                    }
                }
                if(price_list.Count == 16)
                {
                    if (price_list.Sum() > 300)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" product total exceeds 300, you apply for a discount \n");
                    }
                    Console.WriteLine("your total price is: {0} {1} ", randSymbol, DiscountMethod(priceTotal));
                    Console.WriteLine();
                    break;

                }
                

            }
        }

        private static double DiscountMethod(double price)
        {
            double discounted_price = 0;
            double discount_amount = 0;
            if(price < 300)
            {
                discounted_price = 0;
            }
            if(price >= 300 && price <= 500)
            {
                discount_amount = price * 10 / 100;
                discounted_price = price - discount_amount;
            }
            if(price >= 500 && price <= 1000)
            {
                discount_amount = price * 15 / 100;
                discounted_price = price - discount_amount;
            }
            if(price > 1000)
            {
                discount_amount = price * 35 / 100;
                discounted_price = price - discount_amount;
            }
            return discounted_price;

        }

    }
}