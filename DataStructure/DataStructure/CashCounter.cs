// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CashCounter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// CashCounter class implements the bank operations
    /// </summary>
  public class CashCounter
    {
        /// <summary>
        /// The q is Queue object this is used to set the user into Queue
        /// </summary>
      private readonly Queue q = new Queue();

        /// <summary>
        /// The utility class have the logical part
        /// </summary>
       private readonly Utility utility = new Utility();

        /// <summary>
        /// Inserts this instance. 
        /// this method handle all operation
        /// </summary>
        public void Insert()
        {
            ////take the how much user are in queue
            Console.WriteLine("Enter the number of customers ");
            int customer = Convert.ToInt32(Console.ReadLine());

            //// send the one by one customer into the queue
            for (int i = 0; i < customer; i++)
            {
                //// q object is send the one by one all customer into the queue
                this.q.EnQueue(i);
                Console.WriteLine("Customer {0}", i);
                //// Transaction() method is use to do the transactions like deposit amount withdrawal amount
                this.Transaction();
            }
            ////q.display();
        }

        /// <summary>
        /// The bank balance  
        /// This is bank balance of any bank
        /// </summary>
        private static long BankBalance = 1000;

        /// <summary>
        /// The customer amount this array to store the customer money
        /// </summary>
       private static readonly int[] customerAmount = new int[10];

        /// <summary>
        /// Transactions this instance.
        /// this method have the all transaction
        /// </summary>
        public void Transaction()
        {
            ////take the username here
          Console.WriteLine("Please Enter Your Name Please ");
            string name = Console.ReadLine();
              
            Console.WriteLine("Welcome " + name);
            //// showing the all options
            Console.WriteLine(" 1. Deposite \n 2. Display Balance \n 3. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            //// QueueNode custmer = new QueueNode();
            //// switch case is use to Depsite Display balance and exit 
            switch (choice)
            {
                case 1:
                    int[] amount = Deposit();
                    Console.WriteLine("Your Amount is {0} " + amount[0] + " Deposited ");
                    Console.WriteLine("Do you want to withdrawal if yes press 'y' or 'n' ");
                    char responce = Console.ReadLine()[0];
                    if ('y'.Equals(responce))
                    {
                        CashCounter.Withdrawal();
                    }
                    else
                    {
                        break;
                    }

                    break;
                case 2:
                    CheckBalance();
                    break;

                case 3:

                    break;
                case 4:

                    break;
            }
        }

        /// <summary>
        /// Deposits this instance.
        /// this  method store the deposit amount into the array
        /// </summary>
        /// <returns>Return the array the is user balance</returns>
        public static int[] Deposit()
        {
            int size = 0;
            int amount = 0;
            Console.WriteLine("Enter Your Amount To Deposit ");
             amount = Convert.ToInt32(Console.ReadLine());
            //// it will store the amount into the array
            customerAmount[size] = amount;
            //// update the bank balance also
            BankBalance = BankBalance + customerAmount[0];
          ////  Console.WriteLine("bank balnacce "+BankBalance);
            return customerAmount;
        }

        /// <summary>
        /// Withdrawals this instance.
        /// this method Withdrawal the amount from the user account and also the bank
        /// </summary>
        public static void Withdrawal()
        { 
                Console.WriteLine("Enter your Amount To Withdrawal");
                int amount = Convert.ToInt32(Console.ReadLine());
                customerAmount[0] = customerAmount[0] - amount;
            //// print the user remaining amount(Balance)
                Console.WriteLine("remaining balance" + customerAmount[0]);
            //// reduse the amount from the bankBalance also
              BankBalance = BankBalance - amount;
            Console.WriteLine("bank baalance " + BankBalance);
            ////return customerAmount;
        }

        /// <summary>
        /// Checks the balance.
        /// this method check the balance of user
        /// </summary>
        public static void CheckBalance()
        {
            int[] amount = Deposit();
            Console.WriteLine("Your Amount is  {0}" + amount[0]); 
        }
    }
}