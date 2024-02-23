using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2.Controllers
{
    public class J3Controller : ApiController
    {
        //GET:localhost/api/J3/DistinctDigits/{y}
        /// <summary>
        /// Link to J3:https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2013/stage1/juniorEn.pdf . 
        /// Recieves an input that represent a year, checks for duplicates of numbers of this year and returns the next year with distinct digits.
        /// </summary>>
        /// <param name="y">The  input number corresponding to a year (range:0 ≤ Y ≤ 10000).</param>
        /// <param name="d">The returning year with distinct digits</param>
        /// <return>
        /// 1. if it finds the next year with distinct digits, then it retuns its number
        /// 2. if it doesn't find any match, it contiues looping until a year with distinct digits is found. Then repeat previous step.
        /// </return>
        /// <example>
        /// GET ../api/J3/DistinctDigits/1987 => 2013
        /// </example>>
        /// <example>
        /// GET ../api/J3/DistinctDigits/999 => 1023
        /// </example>>

        [HttpGet]
        [Route("api/J3/DistinctDigits/{y}")]

        public int DistinctDigits(int y)
        {
            // Validate 0 ≤ Y ≤ 10000
            if (y >= 0 && y <= 10000)
            {
                // Loop for 'y' to go through each year after and see if it meets conditions
                bool IsDistinct = false;
                while (IsDistinct == false)
                { 
                    y = y+1;
                    // Convert int to string
                    string d = y.ToString();
                    char[] digits = d.ToCharArray();
                    string[] digitStrings = digits.Select(c => c.ToString()).ToArray();

                    // Check for distinct digits and ignore years with duplicates 
                    // Break loop because distinct number is found

                    if (digitStrings.Length == 1)
                    {
                        return y;
                    }

                    if (digitStrings.Length == 2)
                    {
                        if (digitStrings[0] != digitStrings[1])
                        {
                            return y;
                        }
                    }

                    if (digitStrings.Length == 3)
                    {
                        if ((digitStrings[0] != digitStrings[1]) &&
                            (digitStrings[1] != digitStrings[2]) &&
                            (digitStrings[2] != digitStrings[0]))
                        {
                            return y;
                        }
                    }

                    if (digitStrings.Length == 4)
                    {
                        if ((digitStrings[0] != digitStrings[1]) &&
                            (digitStrings[0] != digitStrings[2]) &&
                            (digitStrings[1] != digitStrings[2]) &&
                            (digitStrings[1] != digitStrings[3]) &&
                            (digitStrings[2] != digitStrings[3]) &&
                            (digitStrings[3] != digitStrings[0]))
                        {
                            return y;
                        }
                    }

                    if (digitStrings.Length == 5)
                    {
                        if ((digitStrings[0] != digitStrings[1]) &&
                            (digitStrings[0] != digitStrings[2]) &&
                            (digitStrings[0] != digitStrings[3]) &&
                            (digitStrings[1] != digitStrings[2]) &&
                            (digitStrings[1] != digitStrings[3]) &&
                            (digitStrings[1] != digitStrings[4]) &&
                            (digitStrings[2] != digitStrings[3]) &&
                            (digitStrings[2] != digitStrings[4]) &&
                            (digitStrings[3] != digitStrings[4]) &&
                            (digitStrings[4] != digitStrings[0])
                            )
                        {
                            return y;
                        }
                    }





                }
                // If userinput doesn't meet the condition 0 ≤ Y ≤ 10000, it returns 0.
            }
            return 0;

               

        }
}
}
        
