using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;
using System.Resources;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {

        /// <summary>
        /// Gets and sets the list of items that are filtered throught he website
        /// </summary>
        public IEnumerable<IOrderItem> items { get; protected set; }


        /// <summary>
        /// Get and sets the input strings in the search bar
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// Property for the minimum number of calories to filter
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// Property for the maximum number of calories to filter
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// Property for the minimum price that can be filtered
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        /// <summary>
        /// Property for the maximum price that can be filtered
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        /// <summary>
        /// Gets and sets the multiple categories 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Categories { get; set; }

        /// <summary>
        /// Updates all of the properties to be filtered on a get request
        /// </summary>
        /// <param name="CaloriesMin">minimum calories</param>
        /// <param name="CaloriesMax">maximum calories</param>
        /// <param name="PriceMin">minimum price</param>
        /// <param name="PriceMax">maximum price</param>
        public void OnGet(int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax) // int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax
        {

            // Using linq queries to search for items
            items = Menu.All;

            if (SearchTerms != null)
            {
                items = items.Where(IOrderItem => IOrderItem.ToString() != null && IOrderItem.ToString().Contains(SearchTerms, StringComparison.CurrentCultureIgnoreCase));
            }

            // THE LINQ QUERIES THAT DO NOT WORK
            /*
            if (Categories != null && Categories.Length != 0)
            {
                
                items = items.Where(IOrderItem => Menu.Categories != null && Categories.Contains("Entree") || Categories.Contains("Side") || Categories.Contains("Drink"));
            }
            

            if (PriceMax != null && PriceMin != null)
            {
                items = items.Where(IOrderItem => IOrderItem.Price > PriceMin && IOrderItem.Price < PriceMax); // dont need null check because of ? check
            }
            if (PriceMax == null)
            {
                items = items.Where(IOrderItem => IOrderItem.Price > PriceMin);
            }
            if (PriceMin == null)
            {
                items = items.Where(IOrderItem => IOrderItem.Price < PriceMax);
            }


            if (CaloriesMax != null && CaloriesMin != null)
            {
                items = items.Where(IOrderItem => IOrderItem.Calories > CaloriesMin && IOrderItem.Calories < CaloriesMax); // dont need null check because of ? check
            }
            if (CaloriesMax == null)
            {
                items = items.Where(IOrderItem => IOrderItem.Calories > CaloriesMin);
            }
            if (CaloriesMin == null)
            {
                items = items.Where(IOrderItem => IOrderItem.Calories < CaloriesMax);
            }
            */

            // Get queries
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;


            items = Menu.All;

            SearchTerms = Request.Query["SearchTerms"];
            Categories = Request.Query["Categories"];

            items = Menu.Search(items, SearchTerms);
            items = Menu.FilterByCalories(items, this.CaloriesMin, this.CaloriesMax);
            items = Menu.FilterByPrice(items, this.PriceMin, this.PriceMax);
            items = Menu.FilterByCategory(items, Categories);
            
        }

    }
}
