using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

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
        //[BindProperty]
        public string SearchTerms { get; set; } = "";
        
        /// <summary>
        /// Property for the minimum number of calories to filter
        /// </summary>
        //[BindProperty]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// Property for the maximum number of calories to filter
        /// </summary>
        //[BindProperty]
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// Property for the minimum price that can be filtered
        /// </summary>
        //[BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// Property for the maximum price that can be filtered
        /// </summary>
        //[BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// Gets and sets the multiple categories 
        /// </summary>
        //[BindProperty]
        public string[] Categories { get; set; }

        /// <summary>
        /// Updates all of the properties to be filtered on a get request
        /// </summary>
        /// <param name="CaloriesMin">minimum calories</param>
        /// <param name="CaloriesMax">maximum calories</param>
        /// <param name="PriceMin">minimum price</param>
        /// <param name="PriceMax">maximum price</param>
        public void OnGet(int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax)
        {
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



        /*
        public void OnPost()
        {
            items = Menu.Search(SearchTerms);
            items = Menu.FilterByCalories(items, CaloriesMin, CaloriesMax);
            items = Menu.FilterByPrice(items, PriceMin, PriceMax);
            items = Menu.FilterByCategory(items, Categories);
        }
        */

        /*
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        */
    }
}
