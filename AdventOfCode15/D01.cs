using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode15.Help;

namespace AdventOfCode15
{
    public class D01
    {
        public static void Run()
        {
            var day = "01D";
            var data = Helpers.ReadText(day);

            var level = 0;
            var position = 0;

            #region part1
            //foreach (var c in data)
            //{
            //    if (c == '(')
            //    {
            //        level++;
            //    }
            //    if (c == ')')
            //    {
            //        level--;
            //    }
            //}
            #endregion

            for (var i = 0; i < data.Length; i++)
            {
                if (data[i] == '(')
                {
                    level++;
                }

                if (data[i] == ')')
                {
                    level--;
                }

                if (level == -1)
                {
                    position = i +1;
                    break;
                }
            }

            Console.WriteLine("Floor: " + level);
            Console.WriteLine("Position: " + position);
            Console.ReadLine();
        }
    }
}
