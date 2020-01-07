// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TripletOfZero.cs" company="Bridgelabz">
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
    /// TripleOfZero class is use for find the sum of three number is zero
    /// </summary>
   public class TripletOfZero
    {
        /// <summary>
        /// The array with some values 
        /// </summary>
        private readonly int[] array = { 1, 2, 0, -1, 1 };

        /// <summary>
        /// Determines whether is sum zero.
        /// </summary>
        public void IsSumZero()
        {
            ////first for loop is start from 0 index position to array.length
            for (int first = 0; first < this.array.Length; first++)
            {
                ////second for loop start from i+1 to ignore first one

                for (int second = first + 1; second < this.array.Length; second++)
                  {
                    ////second for loop start from j+1 to ignore first and second
                    for (int third = second + 1; third < this.array.Length; third++)
                    {
                        ////this condition we are checking all array position values are zero or not
                        if (this.array[first] + this.array[second] + this.array[third] == 0)
                        {
                            ////Print the all situation which  are zero
                            Console.WriteLine(this.array[first] + "  " + this.array[second] + "  " + this.array[third] + "  ");
                        }
                    }
                }
            }
        }
    }
}
