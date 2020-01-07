// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HarmonicNumber.cs" company="Bridgelabz">
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
    /// This class is use To  the Harmonic Number
    /// 1/1+1/2+1/3+1/4+1/5=2.2833333
    /// </summary>
 public class HarmonicNumber
    {
        /// <summary>
        /// The utility class
        /// </summary>
     private readonly Utility utility = new Utility();

        /// <summary>
        /// This variable use to Take Number From User
        /// </summary>
    private int number;

        /// <summary>
        /// Harmonics the number.
        /// </summary>
        public void HarmonicNum()
        {
            Console.WriteLine("Enter The Number : ");
            this.number = this.utility.ReadInt();

            double result = this.utility.HarmonicNumber(this.number);
            Console.WriteLine(result);
        }
    }
}
