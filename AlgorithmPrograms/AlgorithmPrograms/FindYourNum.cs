// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindYourNum.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmPrograms
{ 
using System;
using System.Collections.Generic;
using System.Text;
    class FindYourNum
    {
        Utility utility = new Utility();

        static string input;
        static int range, lower, upper, middle,count;
        public void GetValues()
        {
            Console.WriteLine(" Enter the your number ");
            int n = utility.ReadInt();
            range = (int) Math.Pow(2, n - 1);
           //// Console.WriteLine("Take the number 0 to "+range);
            count = 0;
            lower = 0;
            upper = range;
            input = null;
            middle = (lower + upper) / 2;
            FindAnswer(lower,upper,middle,count, input,n);
        }
        public static void FindAnswer(int lower, int upper, int middle, int count, string input, int n)
        {
            Utility utility = new Utility();
            Console.WriteLine("Is your number : " + middle);
            Console.WriteLine("Enter your Answer in 'yes' or 'high', and 'low' ");
            input = utility.ReadString();

            do
            {
                if (input.Equals("high"))
                {
                    lower = middle;
                    count++;
                }
                else if (input.Equals("yes"))
                {
                    Console.WriteLine("The Number Though was : " + middle);
                    int no = count + 1;
                    Console.WriteLine("It takes " + no + " Times to find Exact Number");
                    break;

                }
                else if (input.Equals("low"))
                {
                    upper = middle;
                    count++;
                }
                if (count < n)
                {
                    middle = (lower + upper + 1) / 2;
                    Console.WriteLine("Is this your number " + middle + " : ");

                    input = utility.ReadString();
                }

            } while (lower <= upper);
            {

                if (count > n)
                {
                    Console.WriteLine("Not Found");
                }
               
            }

        }
    }
}
