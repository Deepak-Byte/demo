// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockReport.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOPS
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
  
    public class StockReport
    {
        
        int choice;
        bool flag = true;
      readonly  Utility utility = new Utility();
    public void StockDetails()
        {
            try
            {
                
                Console.WriteLine(" 1. Add Stock \n 2. Remove Stock \n 3. Delete Stock \n 4.Display \n 5. Exit ");
                Console.WriteLine("***************************************************************");
                Console.WriteLine("Enter your choice ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Utility.AddData();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Utility.DisplyReport();
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Input please try again");
                        break;

                }
            }
            catch (FormatException format)
            {
                Console.WriteLine(format.Message);
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
        }
    

    }
}
