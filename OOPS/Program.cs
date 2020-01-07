// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOPS
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    /// <summary>
    ///  Program class have the all Class object
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Main(string[] args)
        {
           Label:
            try
            {
                int choice;
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine(" 1. Desk Of Cards\n 2. Inventry \n 3. Inventry Managment \n 4. StockReport \n 5. Exit ");
                    Console.WriteLine("Enter your choice");
                    
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            //// DeskOfCards class have the Program of playing card
                            DeskOfCards dc = new DeskOfCards();
                            dc.PlayGame();
                            break;
                        case 2:
                            //// InventryManagment class have the Inventry Details 
                            //// This class have all details about the items
                            Utility.InventoryManagement();
                            break;
                        case 3:
                            //// InventryManager class have the details of item and 
                            //// we can change that and also we can delete and add also
                            InventryManager.Inventory();
                            break;

                        case 4:
                            ////Stock class have the store report
                            StockReport stock = new StockReport();
                            stock.StockDetails();
                            break;
                        case 5:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("You Entered wrong input please try again");
                            break;
                    }   
                }
            }
            catch (FormatException e1)
            {
                Console.WriteLine(e1.Message);
                goto Label;
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
                goto Label;
            }

            Console.ReadKey();
        }       
    }
}