using AdventOfCode15.Help;
using AdventOfCode15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode15
{
    public class D06
    {
        public static void Run()
        {
            // Läs in data
            var day = "06D";
            var data = Helpers.ReadLines(day);

            var grid = CreateGrid(1000, 1000);

            foreach (var line in data)
            {
                var instruction = line.Split(' ');
                if (instruction[0] == "toggle")
                {
                    var coord1 = instruction[1].Split(',');
                    var coord2 = instruction[3].Split(',');

                    grid = Toggle(grid, int.Parse(coord1[0]), int.Parse(coord1[1]), int.Parse(coord2[0]), int.Parse(coord2[1]));
                }
                else if (instruction[1] == "on")
                {
                    var coord1 = instruction[2].Split(',');
                    var coord2 = instruction[4].Split(',');
                    grid = TurnOn(grid, int.Parse(coord1[0]), int.Parse(coord1[1]), int.Parse(coord2[0]), int.Parse(coord2[1]));
                }
                else
                {
                    var coord1 = instruction[2].Split(',');
                    var coord2 = instruction[4].Split(',');
                    grid = TurnOff(grid, int.Parse(coord1[0]), int.Parse(coord1[1]), int.Parse(coord2[0]), int.Parse(coord2[1]));
                }
            }
        }

        private static List<List<bool>> TurnOff(List<List<bool>> grid, int fromRow, int toRow, int fromColumn, int toColumn)
        {
            throw new NotImplementedException();
        }

        private static List<List<bool>> TurnOn(List<List<bool>> grid, int fromRow, int toRow, int fromColumn, int toColumn)
        {
            
            return grid;
        }

        private static List<List<bool>> Toggle(List<List<bool>> grid, int fromRow, int toRow, int fromColumn, int toColumn)
        {
           
            return grid;
        }

        private static List<List<bool>> CreateGrid(int width, int height)
        {
            var grid = new List<List<bool>>();
            for (var i = 0; i < height; i++) 
            { 
                var row = new List<bool>();
                for (var j = 0; j < width; j++)
                {
                    row.Add(false);
                }
                grid.Add(row);
            }
            return grid;
        }
    }
}
