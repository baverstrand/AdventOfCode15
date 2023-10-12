using AdventOfCode15.Help;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode15
{
    public class D08
    {
        public static void Run()
        {
            var day = "08T";
            var data = Helpers.ReadBytes(day);
            //var input = data.Split("\r\n");

            var charCounter = 0;
            var stringCounter = 0;

            var firstChar = Char.Parse(data[0]);

            foreach (var line in data)
            {
                //var cCounter = 0;
                //foreach (var c in line)
                //{
                //    cCounter++;
                //}
                //charCounter += cCounter;
                //var cleanLine = line.Substring(1);
                //cleanLine = cleanLine.Remove(cleanLine.Length - 1);
                //Console.WriteLine(cleanLine);
                //var newString = cleanLine.ToString();
                //stringCounter+= cleanLine.Length;
            }
        }
    }
}
