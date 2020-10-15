using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Schema;

namespace HTTP5101_Assignment2_DanielGuinto.Controllers
{
    public class J2Controller : ApiController
    {
    /// <summary>
    /// Determines how many ways a pair of dice can roll the value of 10 when given the number of sides each die has
    /// </summary>
    /// <param name="m">Number of sides on die 1</param>
    /// <param name="n">Number of sides on die 2</param>
    /// <example>GET .. api/J2/DiceGame/6/8   ->   There are 5 total ways to get the sum 10</example>
    /// <returns>The number of ways a pair of dice can roll a 10 based off of the number of sides each die has</returns>
    [Route ("api/J2/DiceGame/{m}/{n}")]
    public string GetDiceGame(int m, int n)
        {
            //Sets up message string to be output later
            string message = "";

            //Creates initial variable for total number of ways dice can roll a 10
            int total = 0;

            //FOR Loop test values from 1 to m
            for (int i = 1; i <= m; i++)
            {

                //IF statement to check how many ways a pair of dice can roll a 10
                if (10 - i <= n && 10 - i > 0)
                {
                    total = total + 1;
                }


                //IF statement to create message with correct grammar (singular vs. multiple ways to get to sum of 10)
                if (total == 1)
                {
                    message = "There is " + total + " way to get the sum of 10";
                }
                else
                {
                    message = "There are " + total + " ways to get the sum of 10";
                }
            }

            //Returns final message
            return message;
        }
    }
}
