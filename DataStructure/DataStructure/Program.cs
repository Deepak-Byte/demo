// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructure
{
    using System;

    /// <summary>
    /// Program class have the all class object
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {

            try
            {
                //// flag is use for while loop  to execute till user want
                bool flag = true;
                //// while loop execute till user wants
                //// whhen user press the 5 it will stop 
                while (flag)
                {
                    //// Console.Clear();
                    try
                    {
                        int choice;
                        Console.WriteLine("---------- Prime Numbers --------------");
                        Console.WriteLine(" 1.Prime Numbers \n 2.Prime Anagram \n 3.Calendar \n 4.queue Operation \n 5. Palindrome Checker\n 6.Exception Hnadling\n 7. Exit");
                        Console.WriteLine("Enter your choice : ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                //// PrimeNumbers is class it have the all prime number 0 to 1000
                                PrimeNumbers pn = new PrimeNumbers();
                                pn.StorePrimeNumbers();
                                //// singlylinkedlist.PrintLinkedList();
                                break;
                            case 2:
                                //// PrimeAnagram have the all prime but Anagram numbers
                                PrimeAnagrams pa = new PrimeAnagrams();
                                pa.isPrimeAnagram();
                                break;
                            case 3:
                                //// Calendar class have the Month calendar with Days
                                Calendar c = new Calendar();
                                c.GetCalendar();
                                break;
                            case 4:
                                //// CashCounter class have the operation like a bank
                                CashCounter qp = new CashCounter();
                                qp.Insert();
                                break;
                            case 5:
                                PalindromeChecker pc = new PalindromeChecker();
                                pc.IsPalindrome();
                                break;
                            case 6:
                                ExceptionHandling handle = new ExceptionHandling();
                                handle.Show();
                                break;
                            case 7:
                                //// it will stop the execution of the program
                                flag = false;
                                break;
                            default:
                                Console.WriteLine("You enterd wrong input ");
                                break;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            
            catch (Exception)
            {
                Console.WriteLine(" you entered Wrong input please enterd correct input");
                // throw new Exception(" you entered Wrong input please enterd correct input");

            }
        }
    }
}