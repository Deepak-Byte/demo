//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  Utility class have the all logical parts
    /// </summary>
   public class Utility
    {
        /// <summary>
        /// Reads the int method.
        /// </summary>
        /// <returns>return the integer to the user</returns>
        public int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Reads the double method.
        /// </summary>
        /// <returns>return the double to the user</returns>
        public double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Reads the string method.
        /// </summary>
        /// <returns>return the string to the user</returns>
        public string ReadString()
        {
            return Console.ReadLine();
        }

        /*********************************** String Permutation ********************************************************************************/
        /// <summary>
        /// Factorials the specified n.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public int Factorial(int n)
        {
           int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            return fact;
        }

    }
}
