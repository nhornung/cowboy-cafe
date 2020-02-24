/*
 * Author: Nick Hornung
 * Edited by:
 * Class Name: PanDeCampo.cs
 * Purpose: A class to represent the Pan De Campo side object
 * and hold its properties of ingredients, price, and calories
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pan De Campo side
    /// </summary>
    public class PanDeCampo : Side
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
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        ///  Gets value of the price associated with specific size enum
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
        /// <returns>Pan De Campo string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Pan de Campo";
        }
    }
}
