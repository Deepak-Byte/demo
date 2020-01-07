//-----------------------------------------------------------------------
// <copyright file="AddressBookManager.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creater name="Ajay Lodale"/>
//-----------------------------------------------------------------------
namespace StockMarket
{
    using System;

    /// <summary>
    /// Address Book manager class
    /// </summary>
    public class AddressBookManager
    {
        /// <summary>
        /// Address book manager.
        /// </summary>
        public static void AddressBookManag()
        {
            try
            {
                bool flag = true;
                ////this loop continues upto flag is true
                while (flag)
                {
                    ////user have the choices
                    Console.WriteLine("*************************Address Book***********************");
                    Console.WriteLine("What do you want to do");
                    Console.WriteLine(" 1: Add a person deateils \n 2: Edit person Information \n 3: Display Address detaile\n 4: Delete Details \n 5: Sort by last name \n 6: Exit");
                    ////take choice from user
                    Console.WriteLine("Enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AddressBookOperations.AddPerson();
                            break;
                        case 2:
                            AddressBookOperations.UpdatePerson();
                            break;
                        case 3:
                            AddressBookOperations.GetDetailOfAddressBook();
                            break;
                        case 4:
                            AddressBookOperations.DeletePerson();
                            break;
                        case 5:
                            AddressBookOperations.SortByLastName();
                            break;
                        case 6:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid case");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Address Book" + e.Message);
            }
        }
    }
}