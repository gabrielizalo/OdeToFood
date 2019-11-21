using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> myRestaurants;

        public InMemoryRestaurantData()
        {
            myRestaurants = new List<Restaurant>()
                            {
                                new Restaurant
                                {
                                    Id          = 1, Name = "Gabriel's Pizza", Location = "Sabaneta",
                                    CuisineType = CuisineType.Italian
                                },
                                new Restaurant
                                {
                                    Id          = 2, Name = "Bettys's Owls", Location = "Medellín",
                                    CuisineType = CuisineType.Indian
                                },
                                new Restaurant
                                {
                                    Id          = 3, Name = "Luza's Mexican", Location = "Envigado",
                                    CuisineType = CuisineType.Mexican
                                },
                            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in myRestaurants
                   orderby r.Name
                   select r;
        }
    }
}