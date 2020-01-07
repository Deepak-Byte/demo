// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------


namespace AlgorithmPrograms
{
    using System;
   public class Program
    {
        /// <summary>
        /// Main method of the all program list here we are creates the objects and call the methods
        /// </summary>
        /// <param name="args">args</param>
       public static void Main(string[] args)
        {
        Label:
            try
            {
                int choice;
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("\n1. Anagram");
                    Console.WriteLine("2. String Permutation");
                    Console.WriteLine("3. Bubble Sort ");
                    Console.WriteLine("4. Prime Numbers ");
                    Console.WriteLine("5. Insertion Sort ");
                    Console.WriteLine("6. Find Your Number ");
                    Console.WriteLine("7. String Permutations");
                    Console.WriteLine("8. exit");
                    
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Anagram anagram = new Anagram();
                            anagram.IsAnagram();
                            break;
                        case 2:
                            PermutationString ps = new PermutationString();
                            ps.Permutaions();
                            break;
                        case 3:
                            BubbleSort bs = new BubbleSort();
                            bs.BubbleSorted();
                            break;
                        case 4:
                            PrimeNumbers pn = new PrimeNumbers();
                            pn.IsPrime();
                            break;
                        case 5:
                            InsertionSort obj = new InsertionSort();
                            obj.sort();
                            obj.printArraystring();
                            break;
                        case 6:
                            FindYourNum fyn = new FindYourNum();
                            fyn.GetValues();
                            break;
                        case 7:
                            PermutationString perstr = new PermutationString();
                            perstr.Permutaions();
                            break;
                        case 8:
                            flag = false;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine(" Invalid choice please try again");
                goto Label;
            }
        }
    }
}