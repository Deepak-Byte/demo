// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BubbleSort.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BubbleSort program to sort the integer type array
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// The i use for for loop (iterations)
        /// the j is use for takes elements and swap that element 
        /// the temp is use for the store the variable in temp variable to sort the array 
        /// size is use for takes the size of the array
        /// </summary>
        private int i, j, temp, size;
        /// <summary>
        /// The flag is use for the stoping the iterations
        /// </summary>
        public int flag = 0;
      private readonly  Utility utility = new Utility();
       public void BubbleSorted()
        { 
        Console.WriteLine("Enter the size of the array : ");
            size = this.utility.ReadInt();
          int[] arr = new int[size];
            Console.WriteLine("Enter the elementsin array : ");
          for(i=0;i< size; i++)
          {
        	  arr[i]= this.utility.ReadInt();
            }
          
          for(i=0;i< size; i++)
          {  flag=0;
        	  for(j=0;j< size - 1;j++)
        	  {
        		
        		  if(arr[j] > arr[j + 1])
        		  {
        			  temp = arr[j];
        			  arr[j] = arr[j + 1];
        			  arr[j + 1] = temp;
        			  flag = 1;
                    ////Console.WriteLine(temp);

                   }
                   //// Console.WriteLine(flag);
        	  }
        	  if(flag == 0)
       	       {
                    break;
                }
          }
          for(i=0;i< size; i++)
          {
                Console.Write(arr[i] + " ");
          }
            Console.WriteLine();
       }
    }
}