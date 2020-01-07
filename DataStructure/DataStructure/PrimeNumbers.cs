// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeNumbers.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// PrimeNumber class give the prime numbers
    /// and print that number into  the  2S Array
    /// </summary>
    public class PrimeNumbers
    {
        /// <summary>
        /// The utility have the logical part of the program
        /// </summary>
        private readonly Utility utility = new Utility();

        /// <summary>
        /// Stores the prime numbers.
        /// </summary>
        public void StorePrimeNumbers()
        {
            //// array is use tp store the values in array
            //// 10 is the rows and 167  is the total prime number
            int[,] array = new int[10, 167];
            ////prime_numbers array is use to get the all prime number within 0 to 1000 
            //// that are the return by the ChechPrimeNumbers
            int[] prime_numbers = this.utility.CheckPrimeNumbers();
            //// range array have the all ranges of  prime nunber
            int[] range = { 0, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

            //// for loop is use to print the all prime number into the 2d Array
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 167; j++)
                {
                    //// here we are checking the number less the next of number
                    //// 0-100 100-200 200-300 so on
                    if (range[i] <= prime_numbers[j] && prime_numbers[j] <= range[i + 1])
                    {
                        ////take the prime number and print 
                        array[i, j] = prime_numbers[j];
                        Console.Write(array[i, j] + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}