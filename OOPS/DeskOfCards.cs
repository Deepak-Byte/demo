// <copyright file="DeskOfCards.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace OOPS
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  class is use to play the cards game
    /// </summary>
   public class DeskOfCards
    {
        

        /// <summary>
        /// The utility
        /// </summary>
        readonly private Utility utility = new Utility();

        /// <summary>
        /// Plays the game.
        /// </summary>
        public void PlayGame()
        {
            int i, j;
            //// this array is use to give the cards with some symbols that are in cards game only
            string[] suite = { "Clubs", "Diamonds", "Hearts", "Spades" };

            //// this array is use to have the all cards
            string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int[,] player = new int[9, 4];
            int n = 3;
            Random random = new Random();
            for (i = 0; i < 3; i++)
            {    
           ////  Console.Write(rank[index]+" ");
                for (j = 0; j < 4; j++)
                {
                    int index = random.Next(rank.Length);
                    string card = Convert.ToString(index);
                    player[i, j] = index;
                   //// Console.Write(player[i, j] + " ");
                    if (i == 2 && j == 0)
                    {
                      ////  player[i, j] = rank[index];
                        break;
                    }
                }

                Console.WriteLine();
            }

           this.utility.Sort(player, n);
        ////    utility.Display();
        }
    }
}