// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PowerOfTwo.cs" company="Bridgelabz">
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
    /// Find the power of two
    /// </summary>
  public class PowerOfTwo
    {
        /// <summary>
        /// The utility
        /// </summary>
    private readonly Utility utility = new Utility();

        /// <summary>
        /// The number use for find the power of user input number
        /// </summary>
        private int num;

        /// <summary>
        /// Powers the of.
        /// </summary>
        public void PowerOf()
        {
           Console.WriteLine("Enter the Number ");
            this.num = this.utility.ReadInt();
            this.utility.FindPowerTwo(this.num);
        }
    }
}