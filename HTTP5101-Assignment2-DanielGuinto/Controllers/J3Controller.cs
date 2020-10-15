using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing.Constraints;
using System.Web.UI.WebControls;
using WebGrease.Activities;

namespace HTTP5101_Assignment2_DanielGuinto.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Determines the amount of time it would take to type out a given word from a cellphone number pad
        /// </summary>
        /// <param name="text">Text typed by cellphone</param>
        /// <example>GET .. api/J3/CellText/abba   ->   12</example>
        /// <returns>Minimun number of seconds neede to type in the word, with one number output in seconds</returns>
        [Route ("api/J3/CellText/{text}")]
        public int GetCellText(string text)
        {
            //Sets initial value for time
            int time = 0;
            //int[] button = new int[20];

            //IF statement to check if input is "halt"
            //Returns 0 if halt is inputted, otherwise will calculate time
            if (text == "halt")
            {
                time = 0;
            }
            else
            {
                //FOR loop to go through each character in the input, and will only compute the time for up to 20 characters
                foreach (char i in text.Take(20))
                {
                //IF statement to determine how much time is taken for each specific letter  
                //Only working section :(
                    if ((i == 'a') || (i == 'd') || (i == 'g') || (i == 'j') || (i == 'm') || (i == 'p') || (i == 't') || (i == 'w'))
                    {
                        time = time + 1;
                    }
                    else if ((i == 'b') || (i == 'e') || (i == 'h') || (i == 'k') || (i == 'n') || (i == 'q') || (i == 'u') || (i == 'x'))
                    {
                        time = time + 2;
                    }
                    else if ((i == 'c') || (i == 'f') || (i == 'i') || (i == 'l') || (i == 'o') || (i == 'r') || (i == 'v') || (i == 'y'))
                    {
                        time = time + 3;
                    }
                    else if ((i == 's') || (i == 'z'))
                    {
                        time = time + 4;
                    }

                    /*
                    //****************ATTMEPT 1************************* 
                    //IF Statement to determine which button is being pressed for each specific letter
                    //Would later check if same button is clicked twice in a row, then add 2 seconds
                    if ((i == 'a') || (i == 'b') || (i == 'c'))
                    {
                        button[i] = 2;
                    }
                    else if ((i == 'd') || (i == 'e') || (i == 'f'))
                    {
                        button[i] = 3;
                    }
                    else if ((i == 'g') || (i == 'h') || (i == 'i'))
                    {
                        button[i] = 4;
                    }
                    else if ((i == 'j') || (i == 'k') || (i == 'l'))
                    {
                        button[i] = 5;
                    }
                    else if ((i == 'm') || (i == 'n') || (i == 'o'))
                    {
                        button[i] = 6;
                    }
                    else if ((i == 'p') || (i == 'q') || (i == 'r') || (i == 's'))
                    {
                        button[i] = 7;
                    }
                    else if ((i == 't') || (i == 'u') || (i == 'v'))
                    {
                        button[i] = 8;
                    }
                    else if ((i == 'w') || (i == 'x') || (i == 'y') || (i == 'z'))
                    {
                        button[i] = 9;
                    }
                    */


                    //****************ATTMEPT 2*************************
                    //IF Statement checks if specific letters are clicked in sequence (i and i-1 => a letter and the letter right before it)
                    //If specific letters on the same button are pressed in sequence, add 2 seconds
                    if
                    (i > 1
                    &&
                    (
                    (((i == 'a') || (i == 'b') || (i == 'c')) && (((i - 1) == 'a') || ((i - 1) == 'b') || ((i - 1) == 'c')))
                    ||
                    (((i == 'd') || (i == 'e') || (i == 'f')) && (((i - 1) == 'd') || ((i - 1) == 'e') || ((i - 1) == 'f')))
                    ||
                    (((i == 'g') || (i == 'h') || (i == 'i')) && (((i - 1) == 'g') || ((i - 1) == 'h') || ((i - 1) == 'i')))
                    ||
                    (((i == 'j') || (i == 'k') || (i == 'l')) && (((i - 1) == 'j') || ((i - 1) == 'k') || ((i - 1) == 'l')))
                    ||
                    (((i == 'm') || (i == 'n') || (i == 'o')) && (((i - 1) == 'm') || ((i - 1) == 'n') || ((i - 1) == 'o')))
                    ||
                    (((i == 'p') || (i == 'q') || (i == 'r') || (i == 's')) && (((i - 1) == 'p') || ((i - 1) == 'q') || ((i - 1) == 'r') || ((i - 1) == 's')))
                    ||
                    (((i == 't') || (i == 'u') || (i == 'v')) && (((i - 1) == 't') || ((i - 1) == 'u') || ((i - 1) == 'v')))
                    ||
                    (((i == 'w') || (i == 'x') || (i == 'y') || (i == 'z')) && (((i - 1) == 'w') || ((i - 1) == 'x') || ((i - 1) == 'y') || ((i - 1) == 'z')))
                    )
                    )
                    {
                        time = time + 2;
                    }
                }
            }
            //Outputs time in seconds
            return time;
        }
    }
}
