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

            AddCowpokeChiliButton.Click += AddCowpokeChiliButtonClick;
            AddRustlersRibsButton.Click += AddRustlersRibsButtonClick;
            AddPecosPulledPorkButton.Click += AddPecosPulledPorkButtonClick;
            AddTrailBurgerButton.Click += AddTrailBurgerButtonClick;
            AddDakotaDoubleBurgerButton.Click += AddDakotaDoubleBurgerButtonClick;
            AddTexasTripleBurgerButton.Click += AddTexasTripleBurgerButtonClick;
            AddAngryChickenButton.Click += AddAngryChickenButtonClick;
            AddChiliCheeseFriesButton.Click += AddChiliCheeseFriesButtonClick;
            AddCornDodgersButton.Click += AddCornDodgersButtonClick;
            AddPanDeCampoButton.Click += AddPanDeCampoButtonClick;
            AddBakedBeansButton.Click += AddBakedBeansButtonClick;
            AddJerkedSodaButton.Click += AddJerkedSodaButtonClick;
            AddTexasTeaButton.Click += AddTexasTeaButtonClick;
            AddCowboyCoffeeButton.Click += AddCowboyCoffeeButtonClick;
            AddWaterButton.Click += AddWaterButtonClick;

        }

        /// <summary>
        /// Event for when Angry Chicken button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChickenButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new AngryChicken());
        }

        /// <summary>
        /// Event for when Cowpoke Chili button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChiliButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowpokeChili());
        }

        /// <summary>
        /// Event for when Rustlers Ribs button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new RustlersRibs());
        }

        /// <summary>
        /// Event for when Pecos Pulled Pork button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Event for when Trail burger button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TrailBurger());
        }

        /// <summary>
        /// Event for when Dakota Double burger button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Event for when Texas Triple burger button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTripleBurger());
        }


        /// <summary>
        /// Event for when Chili Cheese Fries button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Event for when Corn Dodgers button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CornDodgers());
        }

        /// <summary>
        /// Event for when Pan de Campo button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PanDeCampo());
        }

        /// <summary>
        /// Event for when Baked Beans button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new BakedBeans());
        }

        /// <summary>
        /// Event for when Jerked Soda button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new JerkedSoda());
        }

        /// <summary>
        /// Event for when Texas Tea button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTea());
        }

        /// <summary>
        /// Event for when Cowboy Coffee button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowboyCoffee());
        }

        /// <summary>
        /// Event for when Water button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new Water());
        }

    }
}
