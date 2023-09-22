using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode15.Help;

namespace AdventOfCode15
{
    public class D02
    {
        public static void Run()
        {
            var day = "02D";
            var data = Helpers.ReadLines(day);

            var totalNeed = 0.0;

            #region part1
            // foreach linje
            //foreach (var line in data)
            //{
            //    // split on x
            //    var meas = line.Split('x');

            //    // l, w, h
            //    var length = int.Parse(meas[0]);
            //    var width= int.Parse(meas[1]);
            //    var height= int.Parse(meas[2]);

            //    // pluttificera ytor
            //    var surface1 = length * width;
            //    var surface2 = length * height;
            //    var surface3 = height * width;

            //    // hitta minsta, pluttificera igen
            //    var smallestSurface = 0;

            //    if (surface1 <= surface2)
            //    {
            //        smallestSurface = surface1;
            //    }
            //    else
            //    {
            //        smallestSurface = surface2;
            //    }
            //    if (surface3 <= smallestSurface)
            //    {
            //        smallestSurface = surface3;
            //    }

            //    var thisPackage = (surface1 * 2) + (surface2 * 2) + (surface3 * 2) + smallestSurface;
                
            //    // lägg till totalen
            //    totalNeed += thisPackage;
            //}
            #endregion

            #region part2

            foreach (var line in data)
            {
                // split on x
                var meas = line.Split('x');

                // l, w, h
                var length = int.Parse(meas[0]);
                var width = int.Parse(meas[1]);
                var height = int.Parse(meas[2]);

                var lwh = new List<int> { length, width, height };
                lwh.Sort();

                // volume
                var volume = length * width * height;

                // hitta de minsta
                var ribbonLength = lwh[0] + lwh[0] + lwh[1] + lwh[1] + volume;

                // lägg till totalen
                totalNeed += ribbonLength;
            }
            #endregion

            Console.WriteLine("Total need: " + totalNeed);
            Console.ReadLine();
        }
    }
}
