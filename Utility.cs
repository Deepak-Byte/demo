// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

/*
 * @author Ajay J Lodale
 * 
 * @Since 18-10-2019
 *
 * @Purpose : Bridgelabz Assignments
 */
/*****************************************************************************************************************************************************/
namespace BasicPrograms
{
    using System;

    /// <summary>
    /// utility class here have all logical parts
    /// </summary>
    public class Utility
 {
        /// <summary>
        /// The random class used to Generate the random number
        /// </summary>
       private readonly Random random = new Random();

        /********************************************  Returning the User Input  ********************************************************************************/
  
        /// <summary>
        /// Reads the integer
        /// </summary>
        /// <returns>return integer</returns>
        public int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// this method return the Double value
        /// </summary>
        /// <returns>return double</returns>
        public double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Reads the string.
        /// </summary>
        /// <returns>return string</returns>
        public string ReadString()
        {
            return Console.ReadLine();
        }

        /**********************************************  Basic Programs   **************************************************************************************/

        /*******************************************   FlipToss Program *******************************************************************************/

        /// <summary>
        /// this method is use to flip coin to toss and find the percentage of head and tail 
        /// </summary>
        /// <param name="flip">The flip .</param>
        public void FlipToss(int flip)
        {
            //// ead and tail are use to store the two sides of coin 
            float head = 0, tail = 0;

            //// this for loop iterating upto Enterd toss 
            //// this is use to Genrate Toss Random number 

            for (int count = 0; count < flip; count++)
            {
                //// double   result = random.NextDouble(0, 9);
                double result = (this.random.NextDouble() * 2.0) - 1.0;
                //// Console.WriteLine(result);-
                if (result < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }
//// HeadPercentage and TailPercentage is use to find the percentage of head and tail

            double headPercentage = (head / flip) * 100;
            double tailPercentage = (tail / flip) * 100;

//// here print the Percentage of Head and Tail
            Console.WriteLine(" Head Percentage is : {0} ", headPercentage);
            Console.WriteLine(" Tail Percentage is : {0} ", tailPercentage);
        }

        /******************************************** Leap Year ***********************************************************************************************/
 
        /// <summary>
        /// Leaps the year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        /// True Or False
        /// </returns>
        //// year%4==0 it will check the year is divible by 4 or not  if divisible then it is prime number
        //// year%400==0 if year is divible by 400 or not  if divisible then it is prime number
        //// year%100!=0 in this condition we are checking the suppose 1400 this not leap year but op is true so we are using this condition
        //// year>999 && year<9999 year should be 4 digit only                
        public bool LeapYear(int year)
        {
            if (((year % 4 == 0) || (year % 400 == 0)) && (year % 100 != 0) && (year > 1000 && year < 9999))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*************************************     Find the Power of 2    *****************************************************************************************/

        /// <summary>
        /// Finds the power two.
        /// </summary>
        /// <param name="number">The Power Of Number.</param>
        public void FindPowerTwo(int number)
        {
            Console.WriteLine("Print the number Till the " + number);

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(2 * i);
            }
        }

        /******************************************* Find the Harmonic Number ****************************************************************************************/
      
         /// <summary>
        /// Harmonics the number.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <returns>return the double type harmonic number</returns>
        public double HarmonicNumber(int result)
        {
            double sum = 0;
            for (int i = 1; i <= result; i++)
            {
                sum = sum + ((float)1 / i);
            }

            return sum;
        }

/********************************************* 2-D Matrix *********************************************************************************************/

        /// <summary>
        /// Display  the Array  elements.
        /// </summary>
        /// <param name="array">The array.</param>
        //// r is use  as a rows and c is use as column
        public void DisplayArray(object[,] array)
        {
            for (int r = 0; r < array.Length; r++)
            {
                for (int c = 0; c < array.Length; c++)
                {
                    Console.Write(array[r, c] + " ");
                }

                Console.WriteLine();
            }
        } //// End insertElements

        /************************************** Quadratic Equation Root ***************************************************************************************/

        /// <summary>
        /// Finds the root.
        /// </summary>
        /// <param name="a">The a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        public void FindRoot(int a, int b, int c)
        {
            int delta = (b * b) - (4 * a * c);
            int sqrt = (int)Math.Pow(delta, 0.5);
            int rootOne = (-b + sqrt) / (2 * a);
            int root2 = (-b - sqrt) / (2 * a);

            Console.WriteLine("Root 1 ", rootOne);
            Console.WriteLine("Root 2 ", root2);
        }

        /************************************** Gambler win or loss percentage *******************************************************************************************************/
        /*********************************** Convert Temprature ****************************************************************************************/

        /// <summary>
        /// temperature the specified temperature.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <param name="speed">The speed.</param>
        /// <returns>return the double type value</returns>
        public double Tepreture(int temperature, int speed)
        {
            //// first find the power of v means speed that is speed * 0.16
            int power = (int)Math.Pow(speed, 0.160);
            //// using the formula solve equation
            double w = 35.74 + (0.6215 * temperature) + (0.4275 * temperature) - (35.75 * power); 
            ////return the output as double
            return w;
        }
    }
} 