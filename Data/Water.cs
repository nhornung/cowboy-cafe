/*
 * Author: Nick Hornung
 * Edited by:
 * Class Name: Water.cs
 * Purpose: A class to represent the water drink object
 * and hold its properties of instructions, price, and calories
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent water object
    /// </summary>
    public class Water : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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

        private Size size = Size.Small;
        /// <summary>
        /// Determines the size of water from the enum and updates property
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

        private bool lemon = false;
        /// <summary>
        /// If the water has a lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {              
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));   
            }
        }

        private bool ice = true;
        /// <summary>
        /// If the water has ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
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

        /// <summary>
        /// Creates string for item to put on order list
        /// </summary>
        /// <returns>Water</returns>
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
