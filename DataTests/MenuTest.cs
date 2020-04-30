using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.Linq; // use for . count()

namespace CowboyCafe.DataTests
{
    public class MenuTest
    {
        /// <summary>
        /// Tests if the entree method returns one of each type of entree
        /// </summary>
        /// <param name="t"></param>
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(TrailBurger))]
        public void EntreesShouldContainItem(Type t)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Entrees())
            {
                types.Add(item.GetType());
            }

            Assert.Contains(t, types);
        }

        /// <summary>
        /// Tests if the side method returns one of each type of side
        /// </summary>
        /// <param name="t"></param>
        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        public void SidesShouldContainItem(Type t)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Sides())
            {
                types.Add(item.GetType());
            }

            Assert.Contains(t, types);
        }

        /// <summary>
        /// Tests if the drink method returns one of each type of drink
        /// </summary>
        /// <param name="t"></param>
        [Theory]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(Water))]
        public void DrinksShouldContainItem(Type t)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Drinks())
            {
                types.Add(item.GetType());
            }

            Assert.Contains(t, types);
        }

        /// <summary>
        /// Tests if the complete menu/ALL method returns one of each item on the menu
        /// </summary>
        /// <param name="t"></param>
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(Water))]
        public void CompleteMenuShouldContainAllItems(Type t) // TEST FOR ALL
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.completeMenu())
            {
                types.Add(item.GetType());
            }

            Assert.Contains(t, types);
        }

        /// <summary>
        /// Tests if entree property contains all entree items
        /// </summary>
        [Fact]
        public void EntreesShouldHave7Items() // Including all sizes
        {
            Assert.Equal(7, Menu.Entrees().Count());
        }

        /// <summary>
        /// Tests if side property contains all sides and their sizes
        /// </summary>
        [Fact]
        public void SidesShouldHave12Items() // Including all sizes
        {
            Assert.Equal(12, Menu.Sides().Count());
        }

        /// <summary>
        /// Tests if the drink property contains all drinks and their sizes
        /// </summary>
        [Fact]
        public void DrinksShouldHave12Items() // Including all sizes
        {
            Assert.Equal(12, Menu.Drinks().Count());
        }

        /// <summary>
        /// Tests if the complete menu/all property contains all items on the menu
        /// </summary>
        [Fact]
        public void CompleteMenuShouldHaveAll31Items() // Including all sizes
        {
            Assert.Equal(31, Menu.completeMenu().Count());
        }

        //------------

        /*
        [Fact]
        public void MenuEntreesShouldContainExpectedItems()
        {
            var entrees = new List<IOrderItem>(Menu.Entrees());
            entrees.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                entrees,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }


        [Fact]
        public void MenuSidesShouldContainExpectedItems()
        {
            var sides = new List<IOrderItem>(Menu.Sides());
            sides.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                sides,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }


        [Fact]
        public void MenuDrinksShouldContainExpectedItems()
        {
            var drinks = new List<IOrderItem>(Menu.Drinks());
            drinks.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                drinks,
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (wr) => { Assert.IsType<Water>(wr); }
                );
        }

        [Fact]
        public void AllCompleteMenuShouldContainExpectedItems() // TEST FOR ALL
        {
            var all = new List<IOrderItem>(Menu.completeMenu());
            all.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                all,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (wr) => { Assert.IsType<Water>(wr); }
                );
        
        [Fact]
        public void SidesShouldContainChiliCheeseFries()
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Sides())
            {
                types.Add(item.GetType());
            }

            Assert.Contains(typeof(ChiliCheeseFries), types);
        }
        */
    }
}
