using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment2_DanielGuinto.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Calculate the total Calories of a meal depending on the choices of each food item
        /// </summary>
        /// <param name="burger">Index Burger Choice</param>
        /// <param name="drink">Index Drink Choice</param>
        /// <param name="side">Index Side Choice</param>
        /// <param name="dessert">Index Dessert Choice</param>
        /// <example>GET .. api/J1/Menu/1/2/3/4   ->   Your total caolrie count is 691</example>
        /// <returns>Total Caloires of all items selected</returns>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string GetMenu(int burger, int drink, int side, int dessert)
        {
            //Determines calorie count of burger based off of index choice
            if (burger == 1)
            {
                burger = 461;
            }
            else if (burger == 2)
            {
                burger = 431;
            }
            else if (burger == 3)
            {
                burger = 420;
            }
            else if (burger == 4)
            {
                burger = 0;
            }

            //Determines calorie count of drink based off of index choice
            if (drink == 1)
            {
                drink = 130;
            }
            else if (drink == 2)
            {
                drink = 160;
            }
            else if (drink == 3)
            {
                drink = 118;
            }
            else if (drink == 4)
            {
                drink = 0;
            }

            //Determines calorie count of side based off of index choice
            if (side == 1)
            {
                side = 100;
            }
            else if (side == 2)
            {
                side = 57;
            }
            else if (side == 3)
            {
                side = 70;
            }
            else if (side == 4)
            {
                side = 0;
            }

            //Determines calorie count of dessert based off of index choice
            if (dessert == 1)
            {
                dessert = 167;
            }
            else if (dessert == 2)
            {
                dessert = 266;
            }
            else if (dessert == 3)
            {
                dessert = 75;
            }
            else if (dessert == 4)
            {
                dessert = 0;
            }

            //Outputs message with total calorie count
            return "Your total calorie count is " + (burger + drink + side + dessert);
        }
    }
}
