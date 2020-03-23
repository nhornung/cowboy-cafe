using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();

            /// Creates a new order
            var o1 = new Order();
            this.DataContext = o1; // The data of the parent is shared with all of the children

            ///Event listener to initialize the clicks
            CancelOrderButton.Click += CancelOrderButtonClick;
            CompleteOrderButton.Click += CompleteOrderButtonClick;
            ItemSelectionButton.Click += ItemSelectionButtonClicked;


        }

        /// <summary>
        /// Event handler for the cancel order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CancelOrderButtonClick(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Event handler for the complete order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CompleteOrderButtonClick(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        public void ItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
        
    }
}
