/*
 * Author: Nick Hornung
 * Edited by:
 * Class Name: AngryChicken.cs
 * Purpose: A class to represent the Angry Chicken entree object
 * and hold its properties of ingredients, price, and calories
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private bool bread = true;
        /// <summary>
        /// If the chicken uses bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set
            {
                bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the chicken has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The price of the chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Creates string for item to put on order list
        /// </summary>
        /// <returns>Angry Chicken string</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
