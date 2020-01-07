// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockAccount.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOPS
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class StockAccount
    {

        ////public int id { get; set; }

        /// <summary>
        /// Gets or sets the stock.
        /// Here we call the 
        /// </summary>
        /// <value>
        /// The stock.
        /// </value>
        public List<Stock> Stock { get; set; }
    }

       
        /// <summary>
        /// Stock class have the store report
        /// </summary>
      public class Stock
        {
            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets the numberofstock.
        /// </summary>
        /// <value>
        /// The numberofstock.
        /// </value>
        public int Numberofshare { get; set; }
    }
}
