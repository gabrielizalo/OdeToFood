using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration          _myConfig;
        private readonly IRestaurantData         _myRestaurantData;
        public           string                  Message     { get; set; }
        public           IEnumerable<Restaurant> Restaurants { get; set; }

        public ListModel(IConfiguration myConfig, IRestaurantData myRestaurantData)
        {
            _myConfig         = myConfig;
            _myRestaurantData = myRestaurantData;
        }

        public void OnGet()
        {
            Message     = _myConfig["Message"];
            Restaurants = _myRestaurantData.GetAll();
        }
    }
}