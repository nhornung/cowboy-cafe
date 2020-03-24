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
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();

            /// Event for each button
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
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new AngryChicken();
            if (DataContext is Order o)
            {
                var screen = new AngryChickenCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event for when Cowpoke Chili button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChiliButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new CowpokeChili();
            if (DataContext is Order o)
            {
                var screen = new CowpokeChiliCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event for when Rustlers Ribs button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new RustlersRibs();
            if (DataContext is Order o)
            {
                var screen = new RustlersRibsCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event for when Pecos Pulled Pork button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new PecosPulledPork();
            if (DataContext is Order o)
            {
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event for when Trail burger button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new TrailBurger();
            if (DataContext is Order o)
            {
                var screen = new TrailBurgerCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event for when Dakota Double burger button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new DakotaDoubleBurger();
            if (DataContext is Order o)
            {
                var screen = new DakotaDoubleCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event for when Texas Triple burger button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new TexasTripleBurger();
            if (DataContext is Order o)
            {
                var screen = new TexasTripleCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }


        /// <summary>
        /// Event for when Chili Cheese Fries button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new ChiliCheeseFries();
            if (DataContext is Order o)
            {
                var screen = new ChiliCheeseFriesCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event for when Corn Dodgers button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new CornDodgers();
            if (DataContext is Order o)
            {
                var screen = new CornDodgersCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event for when Pan de Campo button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new PanDeCampo();
            if (DataContext is Order o)
            {
                var screen = new PanDeCampoCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event for when Baked Beans button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new BakedBeans();
            if (DataContext is Order o)
            {
                var screen = new BakedBeansCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event for when Jerked Soda button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new JerkedSoda();
            if (DataContext is Order o)
            {
                var screen = new JerkedSodaCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event for when Texas Tea button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new TexasTea();
            if (DataContext is Order o)
            {
                var screen = new TexasTeaCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event for when Cowboy Coffee button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new CowboyCoffee();
            if (DataContext is Order o)
            {
                var screen = new CowboyCoffeeCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event for when Water button is clicked to add to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = new Water();
            if (DataContext is Order o)
            {
                var screen = new WaterCustomization();
                screen.DataContext = item;
                o.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

    }
}
