// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlipToss.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace BasicPrograms
{
using System;

    /// <summary>
    /// this class is use for counting number of toss happen and what is head percentage and tails percentage
    /// </summary>
    public class FlipToss
    {
        /// <summary>
        /// The utility class
        /// </summary>
        private readonly Utility utility = new Utility();

        /// <summary>
        /// This variable to use toss the coin
        /// </summary>
        private int toss;

        /// <summary>
        /// Tosses the coin.
        /// </summary>
        public void TossCoin()
        {
            Console.WriteLine(" Enter the How much Toss Do You want To Do ");
            this.toss = this.utility.ReadInt();
            this.utility.FlipToss(this.toss);
        }
    }
}