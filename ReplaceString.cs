// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReplaceString.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------


namespace BasicPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class replace the string
    /// </summary>
  public class ReplaceString
    {
        /// <summary>
        /// The utility is utility class there all logic part
        /// </summary>
     private readonly Utility utility = new Utility();

        /// <summary>
        /// This variable is use to take Username
        /// </summary>
        private string userName;

        /// <summary>
        /// Replaces this instance.
        /// </summary>
        public void Replace()
          {
            Console.WriteLine("Enter your UserName : ");
            ////Read method will returnthe String
            this.userName = this.utility.ReadString();
            string template = "Hello <<username>>, How are you".Replace("<<username>>", this.userName);
            ////Print the replaced string here
            Console.WriteLine(template);
            ////console.ReadKey() function is used to hold the screen
            Console.ReadKey();
        }
    }
}