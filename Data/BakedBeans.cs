/*
 * Author: Nick Hornung
 * Edited by:
 * Class Name: BakedBeans.cs
 * Purpose: A class to represent the Baked Beans side object
 * and hold its properties of ingredients, price, and calories
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Baked Beans side
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// Gets value of the calories associated with size enum
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Gets value of the price associated with size enum
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Price");

                }
            }
        }

        /// <summary>
        /// Creates string for item to put on order list
        /// </summary>
        /// <returns>Baked Beans string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Baked Beans";
        }
    }
}
