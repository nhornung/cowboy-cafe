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

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {

        public JerkedSodaCustomization()
        {
            InitializeComponent();
        }

        private void OrangeSodaButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda j = (JerkedSoda)DataContext;
            j.Flavor = SodaFlavor.OrangeSoda;
        }

        private void CreamSodaButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda j = (JerkedSoda)DataContext;
            j.Flavor = SodaFlavor.CreamSoda;
        }

        private void SarsparillaButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda j = (JerkedSoda)DataContext;
            j.Flavor = SodaFlavor.Sarsparilla;
        }

        private void BirchBeerButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda j = (JerkedSoda)DataContext;
            j.Flavor = SodaFlavor.BirchBeer;
        }

        private void RootBeerButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda j = (JerkedSoda)DataContext;
            j.Flavor = SodaFlavor.RootBeer;
        }

        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda j = (JerkedSoda)DataContext;
            j.Size = CowboyCafe.Data.Size.Small;
        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda j = (JerkedSoda)DataContext;
            j.Size = CowboyCafe.Data.Size.Medium;
        }

        private void LargeButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda j = (JerkedSoda)DataContext;
            j.Size = CowboyCafe.Data.Size.Large;
        }
    }
}
