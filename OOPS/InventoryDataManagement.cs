// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryDataManagment.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOPS
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Inventory class with rice, pulses and 
    /// </summary>
    public class InventoryDataManagement
    {
        /// <summary>
        /// Gets or sets the rice.
        /// </summary>
        /// <value>
        /// The rice.
        /// </value>
        public List<Rice> rice { get; set; }

        /// <summary>
        /// Gets or sets the pulses.
        /// </summary>
        /// <value>
        /// The pulses.
        /// </value>
        public List<Pulses> pulses { get; set; }

        /// <summary>
        /// Gets or sets the wheats.
        /// </summary>
        /// <value>
        /// The wheats.
        /// </value>
        public List<Wheats> wheats { get; set; }
    }

    /// <summary>
    /// Rice class with name, weight and price.
    /// </summary>
    public class Rice
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public int Weight { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price { get; set; }
    }

    /// <summary>
    /// Pulses class with name,weight and price.
    /// </summary>
    public class Pulses
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price { get; set; }
    }

    /// <summary>
    /// Wheats class with name,weight and price.
    /// </summary>
    public class Wheats
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price { get; set; }
    }
}