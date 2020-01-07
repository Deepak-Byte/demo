// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventryManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOPS
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// InventryManager have the all managment about the InventryManager
    /// </summary>
    public class InventryManager
    {
        /// <summary>
        /// Inventories this instance.
        /// </summary>
        public static void Inventory()
        {
            bool flag = true;
            try
            {
                while (flag)
                {
                    Console.WriteLine("\n 1 : Add Inventory \n 2 : Update Inventory \n 3 : Delete Inventory \n 4 : Exit");
                    Console.WriteLine("Enter Your Choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            //// To Add Inventry we are using AddInventry Method
                            Utility.AddInventory();
                            break;
                        case 2:
                            //// To Update Inventry we are using UpdateInventory Method
                            Utility.UpdateInventory();
                            break;
                        case 3:
                            //// To Delete Inventry we are using DeleteInventory Method
                            Utility.DeleteInventory();
                            break;
                        case 4:
                            //// flag will false when user press 4
                            //// and program will stop
                            flag = false;
                            break;
                        case 5:
                            Console.WriteLine("Choice Not Found");
                            break;
                    }
                }
            }
            catch (FormatException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}