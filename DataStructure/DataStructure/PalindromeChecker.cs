// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PalindromChecker.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PalindromeChecker
    {
        public void IsPalindrome()
       {
            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();

            ///char[] arr = str.ToCharArray();
            DQueue q = new DQueue();
            q.InsertFirst(str);

           
        }
    }
}
