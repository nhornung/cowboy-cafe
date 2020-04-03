/*
 * Author: Nick Hornung
 * Edited by:
 * Class Name: Drink.cs
 * Purpose: An abstract base class for drinks to get values and
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
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;
        /// <summary>
        /// Get the size of the drink but set the default to small
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                NotifyPropertyChanged("Price");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Get the price of the drink
        /// </summary>
        public abstract double Price
        {
            get;
        }

        /// <summary>
        /// Get the calories of the drink
        /// </summary>
        public abstract uint Calories
        {
            get;
        }

        /// <summary>
        /// Determine if the drink contains ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the drink
        /// </summary>
        public abstract List<string> SpecialInstructions
        {
            get;
        }

        protected void NotifyPropertyChanged(string s)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }

    }
}
