/*
 * Author: Nick Hornung
 * Edited by:
 * Class Name: ChiliCheeseFries.cs
 * Purpose: A class to represent the Chili Cheese Fries side object
 * and hold its properties of ingredients, price, and calories
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Chili Cheese Fries side
    /// </summary>
    public class ChiliCheeseFries : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets value of the calories associated with size enum
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
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
                switch(Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unknown Price");

                }
            }
        }

        private Size size = Size.Small;
        /// <summary>
        /// Determines the size of fries from the enum
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Creates string for item to put on order list
        /// </summary>
        /// <returns>Chili Cheese Fries string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Chili Cheese Fries";
        }
    }
}
