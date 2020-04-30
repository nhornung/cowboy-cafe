using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// List of the entree choices on the menu
        /// </summary>
        //private static List<IOrderItem> entreeList = new List<IOrderItem>();

        /// <summary>
        /// List of the side choices on the menu
        /// </summary>
        //private static List<IOrderItem> sideList = new List<IOrderItem>();

        /// <summary>
        /// List of the drink choices on the menu
        /// </summary>
        //private static List<IOrderItem> drinkList = new List<IOrderItem>();

        /// <summary>
        /// List of all menu items
        /// </summary>
        //private static List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Adds an instance of every entree to a list and uses it as an IEnumerable
        /// </summary>
        /// <returns>entreeList, IEnumerable of every entree</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeList = new List<IOrderItem>();
            
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
            List<IOrderItem> sideList = new List<IOrderItem>();
            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                var beans = new BakedBeans();
                beans.Size = s;
                sideList.Add(beans);
            }

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                var fries = new ChiliCheeseFries();
                fries.Size = s;
                sideList.Add(fries);
            }

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                var corn = new CornDodgers();
                corn.Size = s;
                sideList.Add(corn);
            }

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                var pan = new PanDeCampo();
                pan.Size = s;
                sideList.Add(pan);
            }
            return sideList;
        }
        



        /// <summary>
        /// Adds an instance of every drink to a list and uses it as an IEnumerable
        /// </summary>
        /// <returns>drinkList an IEnumerable of every drink</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinkList = new List<IOrderItem>();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                var coffee = new CowboyCoffee();
                coffee.Size = s;
                drinkList.Add(coffee);
            }

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                var soda = new JerkedSoda();
                soda.Size = s;
                drinkList.Add(soda);
            }

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                var texas = new TexasTea();
                texas.Size = s;
                drinkList.Add(texas);
            }

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                var water = new Water();
                water.Size = s;
                drinkList.Add(water);
            }
            return drinkList;


        }

        
        /// <summary>
        /// Populates a list containing every item from the entree, side, and drink lists
        /// </summary>
        /// <returns>menuList an IEnumerable from every other list </returns>
        public static IEnumerable<IOrderItem> completeMenu() 
        {
            List<IOrderItem> menuList = new List<IOrderItem>();

            foreach (IOrderItem i in Entrees()) 
            {
                menuList.Add(i);
            }
            foreach (IOrderItem i in Sides())
            {
                menuList.Add(i);
            }
            foreach (IOrderItem i in Drinks())
            {
                menuList.Add(i);
            }
            return menuList;
        }

        //*********************************************************************************************************************************************************


        public static IEnumerable<IOrderItem> All { get { return completeMenu(); } }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="terms"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> all, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null) return all;


            foreach (IOrderItem item in all)
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }

            return results;
        }


        //*********************************************************************************************************************************************************


        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories<= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }


        //*********************************************************************************************************************************************************


        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }


        //*********************************************************************************************************************************************************

        public static string[] Categories
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> category)
        {
            if (category == null || category.Count() == 0) return items;

            List<IOrderItem> results = new List<IOrderItem>();

            foreach (IOrderItem item in items)
            {
                if (item is Entree && category.Contains("Entree"))
                {
                 
                    
                        results.Add(item);
                   
                    
                }
                if (item is Side && category.Contains("Side"))
                {
               
                 
                        results.Add(item);
                 

                }
                if (item is Drink && category.Contains("Drink"))
                {

                        results.Add(item);
             

                }
            }
            return results;
        }
    }
}
