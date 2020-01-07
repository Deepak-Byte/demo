// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagram.cs" company="Bridgelabz">
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
    /// Prime funnction is use to find the prime number
    /// 
    /// </summary>
    class PrimeAnagrams
    {
       
        public void isPrimeAnagram()
        { 
            Utility utility = new Utility();
            int[] arr = utility.CheckPrimeNumbers();
            string[,] arr1 = utility.isPrimeAnagram(arr);

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[i,j] != null)
                    {
                        Console.WriteLine(arr1[i,j]+" ");
                    }
                }

            }


        }
    }
}
        

