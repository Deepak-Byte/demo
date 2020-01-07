// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeNumbers.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  PrimeNumbers class is use to find the 1 to 1000 prime numbers
    /// </summary>
    class PrimeNumbers
    {
      
        /// <summary>
        /// Determines whether this instance is prime.
        /// </summary>
        public void IsPrime()
        {
            int i = 0;
            int num = 0;
            
            string primeNumber=string.Empty;
            ////For loop is use to iterate loop till 1000
            for(i=0;i<=1000;i++)
            {
                ////counter is use to check the number prime or not 
                int counter = 0;
                
                //// in this for loop we arereverse the for loop i value
                for (num = i; num >= 1; num--)
                {
                    //// here check the modulo 
                    //// if yes then counter value will + 1
                    if (i % num == 0)
                    {
                        counter = counter + 1;
                  
                    }
                }
                //// if counter value is ==2 then we can say that is prime number
                if (counter == 2)
                {
                    primeNumber = primeNumber + i + " ";
                }
               
            }
            //// print the prime number
            Console.WriteLine("Prime 1 to 1000");
            Console.Write(primeNumber);
        

        }
    }
}
