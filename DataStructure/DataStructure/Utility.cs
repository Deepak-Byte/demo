// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// utility class have the all logical parts
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Checks the prime numbers.
        /// </summary>
        /// <returns>Return the all prime Numbers</returns>
        public int[] CheckPrimeNumbers()
        {
            int i = 0;
            int num = 0;
            int primeCounter = 0;
            string primeNumber = string.Empty;
            int[] array = new int[168];
            int size = 0;
            ////For loop is use to iterate loop till 1000
            for (i = 0; i <= 1000; i++)
            {
                ////counter is use to check the number prime or not 
                int counter = 0;

                //// in this for loop we arereverse the for loop i value
                for (num = i; num >= 1; num--)
                {
                    //// here check the modulo 
                    //// if yes then counter value will + 1
                    if (i % num == 0)
                    {
                        counter = counter + 1;
                    }
                }

                //// if counter value is ==2 then we can say that is prime number
                if (counter == 2)
                {
                    //// primeNumber = primeNumber + i + " ";
                    ////int primeNumber2 = Int32.Parse(primeNumber);
                    //// Console.Write(i+" ");
                    array[size] = i;
                    primeCounter++;
                    size++;
                }
            }
            //// print the prime number
            //// Console.WriteLine("Prime 1 to 1000");

            //// Console.Write("How Much Prime Numbers "+ primeCounter + "\n");
            return array;
        }

        public  string[,] isPrimeAnagram(int[] arr)
        {
            string[,] arr1 = new string[arr.Length, arr.Length];

		for(int i=0;i<arr.Length;i++)
		     {
		      for(int j=i+1;j<arr.Length;j++)
		      {
		      string str1 = Convert.ToString(arr[i]);
              string str2 = Convert.ToString(arr[j]);

               char[] c1 = str1.ToCharArray();
               char[] c2 = str2.ToCharArray();

               Array.Sort(c1);
		       Array.Sort(c2);
		      
		      if(Array.Equals(c1, c2))    
		      {
		    	  arr1[i,j]=str1+" "+str2;
		      }
             }
		}
            return arr1;
	}

        /// <summary>
        /// Sets the end date.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="year">The year.</param>
        /// <returns>Set the end date of month</returns>
        public int SetEndDate(int month, int year)
        {
            int[] month_days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int end_date;
            if (month == 2 && year % 4 == 0)
            {
                month_days[month - 1] = 29;
            }

            end_date = month_days[month - 1];
            return end_date;
        }

        /// <summary>
        /// Gets the calendar.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="end_date">The end date.</param>
        /// <returns>return the Calender with dates </returns>
        public int[,] GetCalender(int day, int end_date)
        {
            int[,] date = new int[6, 7];
            int x = 1;
            int j = day;
            for (int i = 0; i < 6; i++)
            {
                for (; j < 7; j++)
                {
                    if (x <= end_date)
                    {
                        date[i, j] = x;
                        x++;
                    }
                }

                j = 0;
            }

            return date;
        }

        /// <summary>
        /// Days the of week.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="date">The date.</param>
        /// <param name="year">The year.</param>
        /// <returns>return the day of the week</returns>
        public int DayOfWeek(int month, int date, int year)
        {
            ////calculate the year in y variable
            int y = (year - (14 - month)) / 12;
            ////calculate the day
            int x = y + (y / 4) - (y / 100) + (y / 400);
            ////calculatre the month using this formula
            int m = ((month + 12) * (14 - month) / 12) - 2;
            ////calculate the day 
            int d = (date + x + ((31 * m) / 12)) % 7;
            ////retrun the day
            return d;
        }

        /******************* Queue Implementations *******************************************************************/

        /// <summary>
        /// Determines whether [is alpha number] [the specified string].
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>
        ///   <c>true</c> if [is alpha number] [the specified string]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAlphaNum(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]) && (!char.IsNumber(str[i])))
                {
                    return false;
                }
            }

            return true;
        }
    }
}