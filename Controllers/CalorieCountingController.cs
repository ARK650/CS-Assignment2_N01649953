using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class CalorieCountingController : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string CalorieCounter(int burger, int drink, int side, int dessert)
        {
            string[] burgerItems = { "Cheese burger", "Fish burger", "Veggie burger", "No burger" };
            int[] burgerCalories = { 461, 431, 420, 0 };

            string[] drinks = { "Soft Drink", "Orange Juice", "Milk", "No drink" };
            int[] drinkCalories = { 130, 160, 118, 0 };

            string[] sides = { "Fries", "Baked Potato", "Chef Salad", "No side order" };
            int[] sideCalories = { 100, 57, 70, 0 };

            string[] desserts = { "Apple Pie", "Sundae", "Fruit Cup", "No Dessert" };
            int[] dessertCalories = { 167, 266, 75, 0 };

            int totalCalories = burgerCalories[burger - 1]
                             + drinkCalories[drink - 1]
                             + sideCalories[side - 1]
                             + dessertCalories[dessert - 1];

            return "Total Calories of this meal is: " + totalCalories;
        }
    }
}
