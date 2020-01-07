// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeFactors.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace BasicPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// finds the prime Factors and display
    /// </summary>
    public class PrimeFactores
    {
        /// <summary>
        /// This is utility class in that have the all logical part
        /// </summary>
    private readonly Utility utility = new Utility();

        /// <summary>
        /// The number is user input to find that number factors
        /// </summary>
       private int number;

        /// <summary>
        /// Find the Number Is prime or Not
        /// </summary>
        public void IsPrime()
        { 
        Console.WriteLine("Enter the Number : ");
            this.number = this.utility.ReadInt();
            ////for loop for iteratit till the number
            for (int i = 2; i * i <= this.number; i++)
            {
                //// divisor of number 
                while (this.number % i == 0)
                {
                    Console.WriteLine("{0}", i);
                    this.number = this.number / i;
                }
            }

            if (this.number > 1)
            {
                Console.WriteLine("{0}", this.number);
            }
          }
    }
}
