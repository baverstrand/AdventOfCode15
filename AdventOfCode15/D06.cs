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
                    grid = Toggle(grid, int.Parse(instruction[1]), int.Parse(instruction[4]), int.Parse(instruction[2]), int.Parse(instruction[5]));
                }
            }
        }

        private static List<List<bool>> Toggle(List<List<bool>> grid, int fromRow, int toRow, int fromColumn, int toColumn)
        {
            // fixa första raden
            for (var i = fromColumn; i < grid[0].Count; i++)
            {
                if (grid[fromRow][i] is true)
                {
                    grid[fromRow][i] = false;
                }
                else
                {
                    grid[fromRow][i] = true;
                }
            }

            // fixa mellanraderna
            for (var i = fromRow + 1; i < toRow; i++)
            {
                for (var j = 0; i < grid[0].Count; j++)
                {
                    if (grid[i][j] is true)
                    {
                        grid[i][j] = false;
                    }
                    else
                    {
                        grid[i][j] = true;
                    }
                }
            }
            // fixa sista raden

            for (var i = 0; i <= toColumn; i++ )
            {
                if (grid[toRow][i] is true)
                {
                    grid[toRow][i] = false;
                }
                else
                {
                    grid[toRow][i] = true;
                }
            }
            return grid;
        }

        private static List<List<bool>> TurnOn(List<List<bool>> grid, int fromRow, int toRow, int fromColumn, int toColumn)
        {
            var row = fromRow;
            var column = fromColumn;
            while (row <= toRow && column <= toColumn)
            {
                if (grid[row][column] is true)
                {
                    grid[row][column] = false;
                }
                else
                {
                    grid[row][column] = true;
                }

                row++;
                column++;
            }
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
