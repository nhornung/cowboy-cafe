/*
 * Author: Nick Hornung
 * Edited by:
 * Class Name: PecosPulledPork.cs
 * Purpose: An abstract class to represent the Pecos Pulled Pork entree object
 * and hold its properties of ingredients, price, and calories
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork : Entree
    {
        private bool bread = true;
        /// <summary>
        /// If the pulled pork uses bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }


        private bool pickle = true;
        /// <summary>
        /// If the pulled pork has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// The price of the pulled pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the pulled pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the pulled pork
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
        /// <returns>Pecos Pulled Pork string</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
