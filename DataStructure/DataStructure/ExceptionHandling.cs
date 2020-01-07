using System;
using System.Collections.Generic;
using System.Text;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExceptionHandling.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructure
{
    class ExceptionHandling
    {
        public void Show()
        {
            try
            {
                Console.WriteLine("Enter the first number");
                int numone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int numtwo = Convert.ToInt32(Console.ReadLine());

                int result = numone / numtwo;
                Console.WriteLine("Result is :" + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch (Exception m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
}
