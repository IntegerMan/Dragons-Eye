﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonsEye
{
    public class Formatting
    {
        /// <summary>
        /// Formatting function that replaces punctuation and vice-versa. 
        /// DOES NOT include ", _, /, \, =, +, {, }, [, ], &, *, ^, %, $, #, @, ~, `, <, and >.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="isEnciphered"></param>
        /// <returns></returns>
        public string Format(string message, bool isEnciphered)
        {
            List<string> symbols = new List<string>() { " ", "!", "?", "'", ":", "(", ")", "-", ",", "." };
            List<string> substitutes = new List<string>() { "QQ", "XD", "JQ", "ZD", "XX", "KKA", "KKB", "XY", "ZZ", "XZ" };

            for (int i = 0; i < symbols.Count; i++)
            {
                if (!isEnciphered)
                {
                    message = message.Replace(symbols[i], substitutes[i]);
                }
                else
                {
                    message = message.Replace(substitutes[i], symbols[i]);
                }
            }

            return message;
        }

        /// <summary>
        /// Grouping method so that the results are printed out in groups of 4. 
        /// Having major issues with trying to also separate it into lines. Each \n is treated as an "enter" key stroke in console.
        /// Console.WriteLine(), Environment.NewLine with {0} notation, and \r\n all have the same issue.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string Grouping(string message)
        {
            int count = 5;
            for (int i = 4; i < message.Length; i += 5)
            {
                /*if (count % 4 == 0)
                {
                    message = message.Insert(i, "\n");
                    count++;
                }
                else
                {*/
                    message = message.Insert(i, " ");
                    count++;
                //}
            }
            return message;
        }

        /// <summary>
        /// Removes the spaces that were inserted during Grouping. 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string Degrouping(string message)
        {
            return message.Replace(" ", "");
        }
    }
}
