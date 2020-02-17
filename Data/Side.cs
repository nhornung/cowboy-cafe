﻿/*
 * Author: Nathan Bean
 * Edited by:
 * Class Name: Side.cs
 * Purpose: An abstract base class for sides to get values and
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
    public abstract class Side
    {
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price
        {
            get;
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories
        {
            get;
        }
    }
}
