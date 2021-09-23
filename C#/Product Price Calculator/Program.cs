using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductPriceCalculator
{
    class Programs
    {
        static void Main(string[] args)
        {
            // Question 1 //

            // Program must add up the price of products(accept user input)
            // if summed up prices exceeds R400, program must give 10% discount
            // Program should then output value back to user


            List<float> product_price = new List<float> { };
            float userInp;
            string userQuery;
            float totalPrice;
            float priceAtDiscount;
            float discountAmount;

            while (true)
            {
                Console.WriteLine("enter the price of your products: ");
                userInp = float.Parse(Console.ReadLine());
                product_price.Add(userInp);
                Console.Clear();

                if (product_price.Count == 6)
                {
                    Console.WriteLine("would you like to continue?(yes or no)");
                    userQuery = Console.ReadLine();

                    if (userQuery == "yes")
                    {
                        continue;
                    }
                    else if (userQuery == "no")
                    {
                        Console.WriteLine("total price of products(excluding Discount) is: ");
                        Console.WriteLine();
                        totalPrice = product_price.Sum();
                        Console.WriteLine(totalPrice);
                        Environment.Exit(0);

                        if (totalPrice > 400)
                        {
                            Console.WriteLine("total price of products(including discount) is: ");
                            Console.WriteLine();
                            priceAtDiscount = totalPrice * 10 / 100;
                            discountAmount = totalPrice - priceAtDiscount;
                            Console.WriteLine(discountAmount);
                            Environment.Exit(0);
                        }

                    }
                }
                if (product_price.Count == 10)
                {
                    break;
                }


            }
            totalPrice = product_price.Sum();
            if (totalPrice > 400)
            {
                priceAtDiscount = totalPrice * 10 / 100;
                discountAmount = totalPrice - priceAtDiscount;
                Console.WriteLine("total price of products(including discount is: ");
                Console.WriteLine(discountAmount);
            }
            Console.WriteLine("total price of products is: ");
            Console.WriteLine(totalPrice);


        }
    }
}
