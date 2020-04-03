/*
 * Author: Nathan Bean
 * Edited by:
 * Class Name: Side.cs
 * Purpose: An abstract base class for sides to get values and
 * override the different properties of the sides
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// Determines the size of the beans and updates the property
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
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

        /// <summary>
        /// Special instructions for the preparation of the side
        /// </summary>
        public virtual List<string> SpecialInstructions
        {
            get;
        }
    }
}
