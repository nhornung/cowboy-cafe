/*
 * Author: Nick Hornung
 * Edited by:
 * Class Name: CowboyCoffee.cs
 * Purpose: A class to represent the Cowboy Coffee drink object
 * and hold its properties of instructions, price, and calories
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent the Cowboy Coffee object
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// The value of the price based on the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return 0.60;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }
    
        /// <summary>
        /// The value of the calories of based on the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Determines if the coffee is decaf
        /// </summary>
        public bool Decaf
        {
            get;
            set;
        }

        /// <summary>
        /// Determines if the coffee has cream
        /// </summary>
        public bool RoomForCream
        {
            get;
            set;
        }

        /// <summary>
        /// If the coffee is iced, false by default
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Special instructions for the preparation of the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if(Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// Creates string for item to put on order list
        /// </summary>
        /// <returns>Cowboy Coffee string</returns>
        public override string ToString()
        {
            string request = Size.ToString();
            if (Decaf)
            {
                return request + "Decaf Cowboy Coffee";
            }
            else {
                return request + " Cowboy Coffee";
            }
        }
    }
}
