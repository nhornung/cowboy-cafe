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
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
            this.DataContext = new Order();
        }

        private void CreditButton_Click(object sender, RoutedEventArgs e)
        {
            CardTerminal ct = new CardTerminal();
            Order o = (Order)this.DataContext;
        }

        private void CashButton_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new CashRegisterControl();
        }

        private void CompleteButton_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}
