using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2.Controllers
{
    public class J2Controller : ApiController
    {
        //GET:localhost/api/J2/DiceGame/{m}/{n}
        /// <summary>
        /// Recieves two inputs of numbers that represent numbers of sides for each dice, performs calculations and returns the number of ways to roll dices that give the sum of 10.
        /// </summary>>
        /// <param name="m">The first input number corresponding to a number of sides of the first dice</param>
        /// <param name="n">The second input number corresponding to a number of sides of the second dice</param>
        /// <return>
        /// Returns a message with a calculated total number of ways to roll dices in order to get the sum of 10.
        /// </return>
        /// <example>
        /// GET ../api/J2/DiceGame/6/8 => "There are 5 total ways to get the sum 10"
        /// </example>>
        /// <example>
        /// GET ../api/J2/DiceGame/12/4 => "There are 4 ways to get the sum 10"
        /// </example>>
        /// <example>
        /// GET ../api/J2/DiceGame/3/3 => "There are 0 ways to get the sum 10"
        /// </example>>
        /// <example>
        /// GET ../api/J2/Dicegame/5/5 => "There is 1 way to get the sum 10"
        /// </example>>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        public string DiceGame(int m, int n)
        {
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int z = 1; z <= n; z++)
                {
                    if (i + z == 10)
                    {
                        count++;
                    }
                }
            }

            if (count == 1) {
                return "There is " + count + " way to get the sum 10.";
            } else if (count == 5) {
                return "There are " + count + " total ways to get the sum 10.";
            } else { return "There are " + count + " ways to get the sum 10."; }

        }
    }
}
