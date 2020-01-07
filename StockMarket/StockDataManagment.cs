// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockDataManagment.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace StockMarket
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  Stock Managment have the details about the Json File 
    /// </summary>
    class StockDataManagment
    {
        /// <summary>
        /// Gets or sets the capgemini.
        /// here we are just takes 
        /// </summary>
        /// <value>
        /// The capgemini.
        /// </value>
        public List<CapgeminiRecord> Capgemini { get; set; }
        // public List<CapgeminiRecord> Capgemini { get; set; }

        /// <summary>
        /// Gets or sets the tata.
        /// </summary>
        /// <value>
        /// The tata.
        /// </value>
        public List<TATARecord> TATA { get; set; }

        /// <summary>
        /// Gets or sets the transaction records.
        /// </summary>
        /// <value>
        /// The transaction records.
        /// </value>
        public List<TransactionRecord> Transaction { get; set; }

        /// <summary>
        /// Transaction Record have the all records details
        /// who buy the share ans from where 
        /// and who sell the share and how much price
        /// </summary>
        public class TransactionRecord  {

            public string Name { get; set; }
            public string Company { get; set; }
            public string Date { get; set; }
            public int Shares { get; set; }
            public int Deducated_Amount { get; set; }
            public int Total_Amount { get; set; }
                
                }

        /// <summary>
        ///  we create a class capgemini to get the value from json file
        ///  here we are takes just two values 
        ///  Avialable_Shares And Share_Price that only important now
        /// </summary>
        public class CapgeminiRecord
        {
            public int Available_Shares { get; set; }
            public int Share_Price { get; set;}
            public int Number_Of_Shares_Holder { get; set; }
            public int Total_Shares_Price { get; set; }
          
        }

        /// <summary>
        /// TATARecord class have to get the values from the json file
        /// here we are takes just two values 
        /// Avialable_Shares And Share_Price that only important now
        /// </summary>
        public class TATARecord
        {
            public int Available_Shares { get; set; }
            public int Share_Price { get; set; }
            public int Number_Of_Shares_Holder { get; set; }
            public int Total_Shares_Price { get; set; }
        }

        public List<Capgemini_Holders> CapgeminiHolder{ get; set; }

        public class Capgemini_Holders
        {
            public string Name { get; set; }
            public string Shares { get; set; }
            public string Money { get; set; }
            public string Date { get; set; }
            public string Since { get; set; }
            public string Company { get; set; }
        }

}
}
