// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace StockMarket
{
    using System;

    /// <summary>
    /// this class have the all details about the shares market
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
           Again:
            try
            {
                int choice;
                Utility utility = new Utility();
                Console.WriteLine("\n");
                Console.WriteLine(" ***** Welcome To Share Market ***** ");
                Console.WriteLine("   1. Buy Shares \n   2. Sell Shares \n  3. Address Book Operations");
                Console.WriteLine("  Enter Your Input ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        utility.BuyShares();
                        break;
                    case 2:
                        // utility.SellShares();
                        break;
                    case 3:
                        AddressBookManager addressmanager = new AddressBookManager();
                        AddressBookManager.AddressBookManag();
                        break;
                    default:
                        Console.WriteLine("You Entered Wrong Input Please Enter Again");
                        break;
                }
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                goto Again;
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
                goto Again;
            }


       }
    }
}
