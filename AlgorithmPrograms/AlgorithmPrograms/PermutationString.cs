// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PermutationString.cs" company="Bridgelabz">
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
    /// Permutation String class have the string permutation by iterative
    /// </summary>
   public class PermutationString
    {
        
        Utility utility = new Utility();
        public void Permutaions()
        {
            int i;
            Console.WriteLine("Enter the String to Generate the permutaion string");
            string name = utility.ReadString();
            char[] arr = name.ToCharArray();
            int no = arr.Length;

            int fact = utility.Factorial(no);
            Console.WriteLine(fact);
            AllPermutaions(arr);
          }
        public static void AllPermutaions(char[] arr)
        {
            int j;
            int count = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                 j = i + 1;
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                for (i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                count++;
            }
            /*if (fact != count)
            {
                AllPermutaions(char[] arr);
            }
            else {
                break;
            }*/
        }
    }
}
