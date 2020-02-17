/*
 * Author: Nick Hornung
 * Edited by:
 * Class Name: JerkedSoda.cs
 * Purpose: A class to represent the Jerked Soda drink object
 * and hold its properties of instructions, price, and calories
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Jerked Soda object
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// Price of the soda based on the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        } 

        /// <summary>
        /// Calories of the soda based on the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Determines the flavor of soda from the enum
        /// </summary>
        public SodaFlavor Flavor
        {
            get;
            set;
        }

        /// <summary>
        /// Special instructions for the preparations of the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
            
        }
    }
}
