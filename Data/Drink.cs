/*
 * Author: Nick Hornung
 * Edited by:
 * Class Name: Drink.cs
 * Purpose: An abstract base class for drinks to get values and
 * override the different properties of the sides
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Get the size of the drink but set the default to small
        /// </summary>
        public Size Size { get; set; } = Size.Small; // check this one

        /// <summary>
        /// Get the price of the drink
        /// </summary>
        public abstract double Price
        {
            get;
        }

        /// <summary>
        /// Get the calories of the drink
        /// </summary>
        public abstract uint Calories
        {
            get;
        }

        /// <summary>
        /// Determine if the drink contains ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the drink
        /// </summary>
        public abstract List<string> SpecialInstructions
        {
            get;
        }
    }
}
