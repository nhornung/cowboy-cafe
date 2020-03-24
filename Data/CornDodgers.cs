/*
 * Author: Nick Hornung
 * Edited by:
 * Class Name: CornDodgers.cs
 * Purpose: A class to represent the Corn Dodgers side object
 * and hold its properties of ingredients, price, and calories
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Corn Dodgers side
    /// </summary>
    public class CornDodgers : Side, INotifyPropertyChanged
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
                switch (Size)
                {
                    case Size.Large:
                        return 717;
                    case Size.Medium:
                        return 685;
                    case Size.Small:
                        return 512;
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

        private Size size = Size.Small;
        /// <summary>
        /// Determines the size of dodgers from the enum and updates property
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
        /// <returns>Corn Dodgers string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Corn Dodgers";
        }
    }
}
