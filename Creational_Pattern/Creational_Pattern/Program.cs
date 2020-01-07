// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Creational_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    ///  Main class to perform the operation
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            //// Threading task it is divide the work  like loop
            Parallel.Invoke(
                () => PrintStudent(),
                () => PrintEmployee());
            Console.ReadLine();
        }

        /// <summary>
        /// Prints the student.
        /// </summary>
        private static void PrintStudent()
        {
            /*
            * Assuming Singleton is created from the student class
            * we refer to GetInstance property from the singleton class 
            */
            Singleton fromstudent = Singleton.GetInstance;
            fromstudent.PrintDetails("From Student");
        }

        /// <summary>
        /// Prints the employee.
        /// </summary>
        private static void PrintEmployee()
        {
            /*
             * Assuming Singleton is created from the employee class
             * we refer to GetInstance property from the singleton class 
             */
            Singleton fromemployee = Singleton.GetInstance;
            fromemployee.PrintDetails("From Employee");
        }
    }
}
