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
                    grid = Toggle(grid, instruction);
                }
                else if (instruction[1] == "on")
                {
                    grid = TurnOn(grid, instruction);
                }
                else
                {
                    grid = TurnOff(grid, instruction);
                }
            }

            // int lightsOn = CountLights(grid);
            // Console.WriteLine("Lights on: " + lightsOn);
            double brightness = CheckBrightness(grid);
            Console.WriteLine("Total brighness: " + brightness);
            Console.ReadLine();
        }

        private static double CheckBrightness(List<List<int>> grid)
        {
            var count = 0.0;
            foreach (var line in grid)
            {
                foreach (var light in line)
                {
                    
                    count += light;
                }
            }
            return count;
        }

        private static int CountLights(List<List<bool>> grid)
        {
            var count = 0;
            foreach (var line in grid)
            {
                foreach (var light in line)
                {
                    if (light)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        //private static List<List<bool>> TurnOff(List<List<bool>> grid, string[] instruction)
        //{
        //    var coord1 = instruction[2].Split(',');
        //    var x1 = int.Parse(coord1[0]);
        //    var y1 = int.Parse(coord1[1]);
        //    var coord2 = instruction[4].Split(',');
        //    var x2 = int.Parse(coord2[0]);
        //    var y2 = int.Parse(coord2[1]);

        //    for (var x = x1; x <= x2; x++)
        //    {
        //        for (var y = y1; y <= y2; y++)
        //        {
        //            grid[x][y] = false;
        //        }
        //    }
        //    return grid;
        //}
        private static List<List<int>> TurnOff(List<List<int>> grid, string[] instruction)
        {
            var coord1 = instruction[2].Split(',');
            var x1 = int.Parse(coord1[0]);
            var y1 = int.Parse(coord1[1]);
            var coord2 = instruction[4].Split(',');
            var x2 = int.Parse(coord2[0]);
            var y2 = int.Parse(coord2[1]);

            for (var x = x1; x <= x2; x++)
            {
                for (var y = y1; y <= y2; y++)
                {
                    if (grid[x][y] > 0)
                    {
                        grid[x][y]--;
                    }
                }
            }
            return grid;
        }

        //private static List<List<bool>> TurnOn(List<List<bool>> grid, string[] instruction)
        //{
        //    var coord1 = instruction[2].Split(',');
        //    var x1 = int.Parse(coord1[0]);
        //    var y1 = int.Parse(coord1[1]);
        //    var coord2 = instruction[4].Split(',');
        //    var x2 = int.Parse(coord2[0]);
        //    var y2 = int.Parse(coord2[1]);

        //    for (var x = x1; x <= x2; x++)
        //    {
        //        for (var y = y1; y <= y2; y++)
        //        {
        //            grid[x][y] = true;
        //        }
        //    }
        //    return grid;
        //}

        //private static List<List<bool>> TurnOn(List<List<bool>> grid, string[] instruction)
        //{
        //    var coord1 = instruction[2].Split(',');
        //    var x1 = int.Parse(coord1[0]);
        //    var y1 = int.Parse(coord1[1]);
        //    var coord2 = instruction[4].Split(',');
        //    var x2 = int.Parse(coord2[0]);
        //    var y2 = int.Parse(coord2[1]);

        //    for (var x = x1; x <= x2; x++)
        //    {
        //        for (var y = y1; y <= y2; y++)
        //        {
        //            grid[x][y] = true;
        //        }
        //    }
        //    return grid;
        //}

        private static List<List<int>> TurnOn(List<List<int>> grid, string[] instruction)
        {
            var coord1 = instruction[2].Split(',');
            var x1 = int.Parse(coord1[0]);
            var y1 = int.Parse(coord1[1]);
            var coord2 = instruction[4].Split(',');
            var x2 = int.Parse(coord2[0]);
            var y2 = int.Parse(coord2[1]);

            for (var x = x1; x <= x2; x++)
            {
                for (var y = y1; y <= y2; y++)
                {
                    grid[x][y]++;
                }
            }
            return grid;
        }

        //private static List<List<bool>> Toggle(List<List<bool>> grid, string[] instruction)
        //{
        //    var coord1 = instruction[1].Split(',');
        //    var x1 = int.Parse(coord1[0]);
        //    var y1 = int.Parse(coord1[1]);
        //    var coord2 = instruction[3].Split(',');
        //    var x2 = int.Parse(coord2[0]);
        //    var y2 = int.Parse(coord2[1]);

        //    for (var x = x1; x <= x2; x++)
        //    {
        //        for (var y = y1; y <= y2; y++)
        //        {
        //            if (grid[x][y])
        //            {
        //                grid[x][y] = false;
        //            }
        //            else
        //            {
        //                grid[x][y] = true;
        //            }
        //        }
        //    }
        //    return grid;
        //}

        private static List<List<int>> Toggle(List<List<int>> grid, string[] instruction)
        {
            var coord1 = instruction[1].Split(',');
            var x1 = int.Parse(coord1[0]);
            var y1 = int.Parse(coord1[1]);
            var coord2 = instruction[3].Split(',');
            var x2 = int.Parse(coord2[0]);
            var y2 = int.Parse(coord2[1]);

            for (var x = x1; x <= x2; x++)
            {
                for (var y = y1; y <= y2; y++)
                {
                    grid[x][y] = grid[x][y] + 2;
                }
            }
            return grid;
        }
        
        //private static List<List<bool>> CreateGrid(int width, int height)
        //{
        //    var grid = new List<List<bool>>();
        //    for (var i = 0; i < height; i++) 
        //    { 
        //        var row = new List<bool>();
        //        for (var j = 0; j < width; j++)
        //        {
        //            row.Add(false);
        //        }
        //        grid.Add(row);
        //    }
        //    return grid;
        //}
        private static List<List<int>> CreateGrid(int width, int height)
        {
            var grid = new List<List<int>>();
            for (var i = 0; i < height; i++)
            {
                var row = new List<int>();
                for (var j = 0; j < width; j++)
                {
                    row.Add(0);
                }
                grid.Add(row);
            }
            return grid;
        }
    }
}
