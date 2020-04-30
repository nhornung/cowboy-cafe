using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.Linq;

namespace CowboyCafe.DataTests
{
    public class SearchFilterTest
    {
        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsAngryChicken()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "AngryChicken");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("angrychicken", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsBakedBeans()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "BakedBeans");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("bakedbeans", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsChiliCheeseFries()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "ChiliCheeseFries");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("chilicheesefries", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsCornDodgers()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "CornDodgers");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("corndodgers", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsCowboyCoffee()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "CowboyCoffee");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("cowboycoffee", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsCowpokeChili()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "TexasTripleBurger");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("texastripleburger", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsDakotaDoubleBurger()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "DakotaDoubleBurger");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("dakotadoubleburger", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsJerkedSoda()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "JerkedSoda");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("jerkedsoda", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsPanDeCampo()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "PanDeCampo");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("pandecampo", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsPecosPulledPork()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "PecosPulledPork");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("pecospulledpork", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsRustlersRibs()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "RustlersRibs");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("RustlersRibs", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsTexasTea()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "TexasTea");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("texastea", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsTexasTripleBurger()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "TexasTripleBurger");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("texastripleburger", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsTrailBurger()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "Trailburger");
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("trailburger", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if search contains that specific item
        /// </summary>
        [Fact]
        public void SearchContainsWater()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "Water");
            bool contains = false;
            foreach(IOrderItem item in test)
            {
                if (item.ToString().Contains("water", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Test to see if search checks and filters for null input
        /// </summary>
        [Fact]
        public void SearchShouldCheckForNULLInput()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.Search(all, "");
            Assert.Equal<int>(all.Count(), test.Count());
        }

        /// <summary>
        /// Test to see if price filter checks and filters for null input
        /// </summary>
        [Fact]
        public void PriceShouldCheckForNULLInput()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.FilterByPrice(all, null, null);
            Assert.Equal<int>(all.Count(), test.Count());
        }

        /// <summary>
        /// Test to see if the calories filter checks and filters for null input
        /// </summary>
        [Fact]
        public void CaloriesShouldCheckForNULLInput()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.FilterByCalories(all, null, null);
            Assert.Equal<int>(all.Count(), test.Count());
        }

        /// <summary>
        /// Test to see if the categories filter checks and filters for null input
        /// </summary>
        [Fact]
        public void CategoriesShouldCheckForNULLInput()
        {
            IEnumerable<IOrderItem> all = Menu.completeMenu();
            IEnumerable<IOrderItem> test = Menu.FilterByCategory(all, null);
            Assert.Equal<int>(all.Count(), test.Count());
        }

        //-----------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Test to see if entree category filter contains entrees when filtered
        /// </summary>
        [Fact]
        public void EntreeCategoryShouldCheckForEntrees()
        {
            string[] category = new string[] { "Entrees" };
            IEnumerable<IOrderItem> test = Menu.FilterByCategory(Menu.completeMenu(), category);
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("AngryChicken", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if side category filter contains sides when filtered
        /// </summary>
        [Fact]
        public void SideCategoryShouldCheckForSides()
        {
            string[] category = new string[] { "Sides" };
            IEnumerable<IOrderItem> test = Menu.FilterByCategory(Menu.completeMenu(), category);
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("BakedBeans", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

        /// <summary>
        /// Test to see if drink category filter contains drinks when filtered
        /// </summary>
        [Fact]
        public void DrinkCategoryShouldCheckForDrinks()
        {
            string[] category = new string[] { "Drinks" };
            IEnumerable<IOrderItem> test = Menu.FilterByCategory(Menu.completeMenu(), category);
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("JerkedSoda", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
                Assert.True(contains);
            }
        }

    }
}
