using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Menu(int burger, int drink, int side, int dessert)
        {
            int burgerCalories = GetBurgerCalories(burger);
            int drinkCalories = GetDrinkCalories(drink);
            int sideCalories = GetSideCalories(side);
            int dessertCalories = GetDessertCalories(dessert);

            int totalCalories = burgerCalories + drinkCalories + sideCalories + dessertCalories;

            return Ok($"Your total calorie count is {totalCalories}");
        }

        private int GetBurgerCalories(int burger)
        {
            switch (burger)
            {
                case 1:
                    return 461;
                case 2:
                    return 431;
                case 3:
                    return 420;
                default:
                    return 0;
            }
        }

        private int GetDrinkCalories(int drink)
        {
            switch (drink)
            {
                case 1:
                    return 130;
                case 2:
                    return 160;
                case 3:
                    return 118;
                default:
                    return 0;
            }
        }

        private int GetSideCalories(int side)
        {
            switch (side)
            {
                case 1:
                    return 100;
                case 2:
                    return 57;
                case 3:
                    return 70;
                default:
                    return 0;
            }
        }

        private int GetDessertCalories(int dessert)
        {
            switch (dessert)
            {
                case 1:
                    return 167;
                case 2:
                    return 266;
                case 3:
                    return 75;
                default:
                    return 0;
            }
        }
    }
}
