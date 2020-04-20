using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// List of the entree choices on the menu
        /// </summary>
        private static List<IOrderItem> entreeList = new List<IOrderItem>();

        /// <summary>
        /// List of the side choices on the menu
        /// </summary>
        private static List<IOrderItem> sideList = new List<IOrderItem>();

        /// <summary>
        /// List of the drink choices on the menu
        /// </summary>
        private static List<IOrderItem> drinkList = new List<IOrderItem>();

        /// <summary>
        /// List of all menu items
        /// </summary>
        private static List<IOrderItem> menuList = new List<IOrderItem>();

        /// <summary>
        /// Adds an instance of every entree to a list and uses it as an IEnumerable
        /// </summary>
        /// <returns>entreeList, IEnumerable of every entree</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            entreeList.Clear(); // So when you refresh or go back to homepage it doesnt show the list again ! 
            entreeList.Add(new AngryChicken());
            entreeList.Add(new CowpokeChili());
            entreeList.Add(new DakotaDoubleBurger());
            entreeList.Add(new PecosPulledPork());
            entreeList.Add(new RustlersRibs());
            entreeList.Add(new TexasTripleBurger());
            entreeList.Add(new TrailBurger());
            return entreeList;
        }

        /// <summary>
        /// Adds an instance of every side to a list and uses it as an IEnumerable
        /// </summary>
        /// <returns>sideList, IEnumerable of every side</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            sideList.Clear(); // So when you refresh or go back to homepage it doesnt show the list again ! 
            sideList.Add(new BakedBeans());
            sideList.Add(new ChiliCheeseFries());
            sideList.Add(new CornDodgers());
            sideList.Add(new PanDeCampo());
            return sideList;
        }

        /// <summary>
        /// Adds an instance of every drink to a list and uses it as an IEnumerable
        /// </summary>
        /// <returns>drinkList an IEnumerable of every drink</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            drinkList.Clear(); // So when you refresh or go back to homepage it doesnt show the list again ! 
            drinkList.Add(new CowboyCoffee());
            drinkList.Add(new JerkedSoda());
            drinkList.Add(new TexasTea());
            drinkList.Add(new Water());
            return drinkList;


        }

        /// <summary>
        /// Populates a list containing every item from the entree, side, and drink lists
        /// </summary>
        /// <returns>menuList an IEnumerable from every other list </returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            menuList.Clear();

            foreach(IOrderItem i in entreeList) 
            {
                menuList.Add(i);
            }
            foreach (IOrderItem i in sideList)
            {
                menuList.Add(i);
            }
            foreach (IOrderItem i in drinkList)
            {
                menuList.Add(i);
            }
            return menuList;
        }
    }
}
