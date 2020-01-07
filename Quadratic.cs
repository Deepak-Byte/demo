// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="Bridgelabz">
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
    /// it will find the quadratic equations
    /// </summary>
    public class Quadratic
    {
        /// <summary>
        /// The utility class is have the all logic part 
        /// </summary>
      private readonly Utility utility = new Utility();

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
     public static void Main(string[] args)
        {
            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);
            int c = Convert.ToInt32(args[2]);

            /*
             * this  function print calculate the qyadratic equations which having the two roots 
             */
         
                ////delta function find denominator
                int delta = (b * b) - (4 * a * c);
                ////sqrt varaible find the power of delta
                int sqrt = (int)Math.Pow(delta, 0.5);
                ////root1 formulaand it values
                int root1 = (-b + sqrt) / (2 * a);
                ////root2 formulaand it values
                int root2 = (-b - sqrt) / (2 * a);

                ////print the values
                Console.WriteLine("Root 1 ", root1);
                Console.WriteLine("Root 2 ", root2);
           }
     }
}
