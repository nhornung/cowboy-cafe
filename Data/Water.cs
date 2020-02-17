/*
 * Author: Nick Hornung
 * Edited by:
 * Class Name: Water.cs
 * Purpose: A class to represent the water drink object
 * and hold its properties of instructions, price, and calories
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent water object
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        /// <summary>
        /// Calories of the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// If the water has a lemon
        /// </summary>
        public bool Lemon
        {
            get;
            set;
        }

        /// <summary>
        /// Special instructions for the preparation of the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
    }
}
