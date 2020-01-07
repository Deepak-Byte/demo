// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WildChill.cs" company="Bridgelabz">
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
    /// WildChill class is use convert temperature fahrenheit
    /// </summary>
public class WildChill
    {
        /// <summary>
        /// The utility have the all logical part
        /// </summary>
       private readonly Utility utility = new Utility();

        /// <summary>
        /// Converts the temporary.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        public void ConvertTemp(string first, string second)
        {
         int temperature = Convert.ToInt32(first);
         int speed = Convert.ToInt32(second);
           //// Here call the Tempreture function that  is written in utility classs
            double result = this.utility.Tepreture(temperature, speed);
            //// Then print the reulst that is send by Utility class
            Console.WriteLine(result);  
        }
    }
}
