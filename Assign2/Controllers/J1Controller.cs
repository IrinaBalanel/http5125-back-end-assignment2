using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2.Controllers
{

    public class J1Controller : ApiController
    {   //GET:localhost/api/J1/Menu/{burger}/{drink}/{side}/{dessert}
        /// <summary>
        /// Recieves four numbers, perfroms calculations and returns a total of values assigned to these numbers
        /// </summary>>
        /// <param name="burger">The first input number corresponding to a burger</param>
        /// <param name="drink">The second input number corresponding to a drink</param>
        /// <param name="side">The third input number corresponding to a side</param>
        /// <param name="dessert">The fourth input number corresponding to a dessert</param>
        /// <return>
        /// Returns a message with a calculated total of calories
        /// </return>
        /// <example>
        /// GET ../api/J1/Menu/4/4/4/4 => "Your total calorie count is 0"
        /// </example>>
        /// <example>
        /// GET ../api/J1/Menu/1/2/3/4 => "Your total calorie count is 691"
        /// </example>>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int[] burgerCalories = { 461, 431, 420, 0 };
            int[] drinkCalories = { 130, 160, 118, 0 };
            int[] sideCalories = { 100, 57, 70, 0 };
            int[] dessertCalories = { 167, 266, 75, 0 };
            int totalCalories = burgerCalories[burger - 1] + drinkCalories[drink - 1] + sideCalories[side - 1] + dessertCalories[dessert - 1];
            string message = "Your total calorie count is " + totalCalories;
            return message;
        }

    }
}



