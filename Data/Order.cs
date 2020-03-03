using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// First order number
        /// </summary>
        private static uint lastOrderNumber = 1;

        /// <summary>
        /// Private field list of different items of Order item type
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Property to get the list of order items 
        /// </summary>
        public IEnumerable<IOrderItem> Items
        {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// Property to retrieve and reset the order total price
        /// </summary>
        public double SubTotal
        {
            get;
            set;
        } = 0;

        /// <summary>
        /// Property for the current order number
        /// </summary>
        public uint OrderNumber
        {
            get;
        }

        /// <summary>
        /// Event field for when a property in the control is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor to initialize a first order
        /// </summary>
        public Order() 
        {
            OrderNumber = lastOrderNumber++;
        }
       
        /// <summary>
        /// Method to add items to order summary when the buttons are invoked
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            SubTotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Method to add items to item list when the buttons are invoked
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            SubTotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
