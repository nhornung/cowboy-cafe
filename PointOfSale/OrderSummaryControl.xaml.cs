using System.Windows;
using System.Windows.Controls;
using CowboyCafe.Data;
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void ItemsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (orderControl == null)
            {
                return;
            }   
            foreach (object o in e.AddedItems)
            {
                 if (o is CowpokeChili)
                 {
                    var ccc = new CowpokeChiliCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                 }
                else if (o is AngryChicken)
                {
                    var ccc = new AngryChickenCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
                else if (o is ChiliCheeseFries)
                {
                    var ccc = new ChiliCheeseFriesCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
                else if (o is CornDodgers)
                {
                    var ccc = new CornDodgersCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
                else if (o is CowboyCoffee)
                {
                    var ccc = new CowboyCoffeeCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
                else if (o is DakotaDoubleBurger)
                {
                    var ccc = new DakotaDoubleCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
                else if (o is JerkedSoda)
                {
                    var ccc = new JerkedSodaCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
                else if (o is PanDeCampo)
                {
                    var ccc = new PanDeCampoCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
                else if (o is PecosPulledPork)
                {
                    var ccc = new PecosPulledPorkCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
                else if (o is RustlersRibs)
                {
                    var ccc = new RustlersRibsCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
                else if (o is TexasTea)
                {
                    var ccc = new TexasTeaCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
                else if (o is TexasTripleBurger)
                {
                    var ccc = new TexasTripleCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
                else if (o is TrailBurger)
                {
                    var ccc = new TrailBurgerCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
                else if (o is Water)
                {
                    var ccc = new WaterCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
                else if (o is BakedBeans)
                {
                    var ccc = new BakedBeansCustomization();
                    ccc.DataContext = o;
                    orderControl.SwapScreen(ccc);
                }
            }      
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            IOrderItem i = (IOrderItem)((sender as Button).DataContext);
            if(DataContext is Order o)
            {
                o.Remove(i);
            }
        }
    }
}
