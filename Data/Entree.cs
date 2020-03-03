/*
 * Author: Nick Hornung
 * Edited by:
 * Class Name: Entree.cs
 * Purpose: An abstract base class for the entrees to retrieve 
 * or override values associated with the price, calories, and ingredients of entrees
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price
        {
            get;
        }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories
        {
            get;
        }

        /// <summary>
        /// Gets any list of unique ingredients
        /// </summary>
        public abstract List<string> SpecialInstructions
        {
            get;
        }
        
        
        
    }
}
