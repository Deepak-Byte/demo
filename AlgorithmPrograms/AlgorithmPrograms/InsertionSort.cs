// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InsertionSort.cs" company="Bridgelabz">
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
    /// InsertonSort class is use to sort array with insertion manner
    /// </summary>
   public class InsertionSort
    {
       static string[] stringArray = { "pavan", "vishal", "ajay" };
        int n = stringArray.Length;

        /// <summary>
        /// Sorts the specified s.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="n">The n.</param>
        public void sort()
        {
            //// for loop to iterate the till the n
            for (int i = 1; i < n; i++)
            {
                //// temp store the array value 
                //// j will chekc the previous all the values
                string temp = stringArray[i];
                int j = i - 1;
                while (j >= 0 && temp.Length < stringArray[j].Length)
                {

                    stringArray[j + 1] = stringArray[j];
                    j--;
                }
                //// store the temp value in stringArray
                stringArray[j + 1] = temp;
            }
        }
        /// <summary>
        /// Prints the arraystring.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="n">The n.</param>
        public void printArraystring()
        {
            for (int i = 0; i < n; i++)
                Console.Write(stringArray[i] + " ");
        }
      }
    }
