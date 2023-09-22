using AdventOfCode15.Help;
using AdventOfCode15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode15
{
    public class D03
    {
        public static void Run()
        {
            // Läs in data
            var day = "03D";
            var data = Helpers.ReadText(day);

            #region part1

            //Skapa grid och startposition
            var grid = new List<CounterPoint>();
            var xpos = 0;
            var ypos = 0;
            grid.Add(new CounterPoint { X = xpos, Y = ypos, Counter = 1 });

            // Gå igenom pil för pil
            foreach (char c in data)
            {
                if (c == '>')
                {
                    xpos++;
                }
                else if (c == '<')
                {
                    xpos--;
                }
                else if (c == '^')
                {
                    ypos--;
                }
                else
                {
                    ypos++;
                }

            }
            // Kolla om koordinaten finns
            // Om finns, plussa counter, annars skapa point 
          
            #endregion

            Console.WriteLine("bla bla");
            Console.ReadLine();
        }
    }
}
