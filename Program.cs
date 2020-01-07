// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace BasicPrograms
{
    using System;

    /// <summary>
    /// This is main class ,it is entry point of code
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Main(string[] args)
        {
        Lable:
            try
            {
                ////this is utility class there all logic part
                Utility utility = new Utility();

            ////Choice is use to take  user Input
            int choice;

            ////flag is use to to continue the loop while it true
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\n\n 1. Replace Srtring ");
                Console.WriteLine(" 2. Flip Toss ");
                Console.WriteLine(" 3. Leap Year ");
                Console.WriteLine(" 4. Power Of Two ");
                Console.WriteLine(" 5. Harmonic Number ");
                Console.WriteLine(" 6. Prime Factor ");
                Console.WriteLine(" 7. Triplet sum Zero ");
                Console.WriteLine(" 8. WildChill");
                Console.WriteLine(" 9. Exit ");

                    choice = utility.ReadInt();

                ////switch case for user Input Action
                switch (choice)
                {
                    case 1:
                            ReplaceString obj = new ReplaceString();
                            obj.Replace();
                            break;
                    case 2:
                            FlipToss ft = new FlipToss();
                            ft.TossCoin();
                            break;
                    case 3:
                            LeapYear ly = new LeapYear();
                            ly.FindLeapYear();
                            break;
                    case 4:
                            PowerOfTwo pt = new PowerOfTwo();
                            pt.PowerOf();
                            break;
                   case 5:
                            HarmonicNumber hn = new HarmonicNumber();
                            hn.HarmonicNum();
                            break;
                    case 6:
                            PrimeFactores pf = new PrimeFactores();
                            pf.IsPrime();
                            
                            break;
                    case 7:
                            TripletOfZero toz = new TripletOfZero();
                            toz.IsSumZero();
                            break;
                        case 8:
                            WildChill wc = new WildChill();
                            wc.ConvertTemp(args[0], args[1]);
                            break;
                        case 9:
                           flag = false;
                            break;
                     default:
                           Console.WriteLine(" Wrong Input Please Enter Correct Input");
                           break;
                    }
                }

                
            }
            catch (FormatException format)
            {
                Console.WriteLine(format.Message);
                goto Label;
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
                goto Label;
            }
            ////Console.ReadKey();
        }
    }
} 