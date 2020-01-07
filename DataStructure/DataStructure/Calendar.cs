// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Calendar.cs" company="Bridgelabz">
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
    /// Calendar class is use to show the calendar
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// Gets the calendar.
        /// </summary>
        public void GetCalendar()
        {
            Utility utility = new Utility();

            //// take a user input year anad month
            int month, year;
            Console.WriteLine("Enter the  Month");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());

            //// end_date variable take a value  that return by setEndDate that is end date of month
            int end_date = utility.SetEndDate(month, year);
            //// day variable take a value that return by dayOfWeek it will return the dayy within the month 
            int day = utility.DayOfWeek(1, month, year);
            
            //// date[] 2D array get the calendar
            int[,] date = utility.GetCalender(day, end_date);
            //Console.Write(" Mon Tue Wend Thu Fri Sat Sun");
            ////for loop print the Whole calendar
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < 7; k++)
                {
                    if (date[i, k] != 0)
                    {
                        Console.Write(date[i, k] + " ");
                    }
                }
            }
        }
    }
}