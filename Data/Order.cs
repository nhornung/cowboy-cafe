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

        private List<double> priceList = new List<double>();


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

        public IEnumerable<double> Price
        {
            get
            {
                return priceList.ToArray();
            }
        }

        
        /// <summary>
        /// Property to retrieve and reset the order total price
        /// </summary>
        public double SubTotal
        {
            get;
            set;
        }

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
            priceList.Add(item.Price);

            if (item is INotifyPropertyChanged pcitem) { pcitem.PropertyChanged += OnItemChanged; } // need to do this on every item and iorder interface do not leave this if in code

            SubTotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        /// <summary>
        /// Method to add items to item list when the buttons are invoked
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            priceList.Remove(item.Price);

            if (item is INotifyPropertyChanged pcitem) { pcitem.PropertyChanged -= OnItemChanged; } // need to do this on every item and iorder interface do not leave this if in code

            SubTotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}
