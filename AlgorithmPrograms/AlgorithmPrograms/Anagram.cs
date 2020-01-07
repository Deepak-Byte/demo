// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Anagram.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Text;

/// <summary>
/// Anagram class to find the String Anagram or not
/// </summary>
   public class Anagram
    {
        /// <summary>
        /// Determines whether this instance is anagram.
        /// </summary>
        public void IsAnagram()
        {
            Utility utility = new Utility();
            ////step 1
            ////Receive Words from User  
            Console.Write("Enter first word:");
            string word1 = utility.ReadString();
            Console.Write("Enter second word:");
            string word2 = utility.ReadString();

            ////Add optional validation of input words if needed.  
   
            //// Step 2 
            //// validating the white Spaces
            string normalized1 = Regex.Replace(word1, @"\s", string.Empty);
            string normalized2 = Regex.Replace(word2, @"\s", string.Empty);

            ////step 3
            //// conver the string into the lower case
            char[] char1 = normalized1.ToLowerInvariant().ToCharArray();
            char[] char2 = normalized2.ToLowerInvariant().ToCharArray();
   
            //// char[] char1 = normalized1.ToCharArray();
            //// char[] char2 = normalized2.ToCharArray();
            ////strp 4
            //// Sort the  character array
            Array.Sort(char1);
            Array.Sort(char2);

            //// Step 5 
            //// Convert Into String object  
           string newWord1 = new string(char1);
            string newWord2 = new string(char2);
            ////strp 6
            //// check Both Are Equals or not
            bool stringEquals = string.Equals(newWord1, newWord2);
            //// step 7
            //// print the Sting Anagram or Not
            if (stringEquals)
            {
                Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", normalized1, normalized2);
            }
            else
            {
                Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", normalized1, normalized2);
            }

            ////Hold Console screen alive to view the results.  
            Console.ReadLine();
        }
    }
}
