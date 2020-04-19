using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        private static List<IOrderItem> entreeList = new List<IOrderItem>();

        private static List<IOrderItem> sideList = new List<IOrderItem>();

        private static List<IOrderItem> drinkList = new List<IOrderItem>();

        public static IEnumerable<IOrderItem> Entrees()
        {
            throw new NotImplementedException();
            
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            throw new NotImplementedException();
          
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            throw new NotImplementedException();
           
        }

        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            throw new NotImplementedException();
            
        }
    }
}
