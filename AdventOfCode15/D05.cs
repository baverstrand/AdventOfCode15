using AdventOfCode15.Help;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode15
{
    public class D05
    {
        public static void Run()
        {
            var day = "05D";
            var data = Helpers.ReadLines(day);

            var counter = 0;

            foreach (var line in data)
            {
                //if (IsNiceVowels(line) && HasDoubleLetter(line) && NoForbiddenStrings(line))
                //{
                //    counter++;
                //}
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }

        private static bool HasPairs (string input)
        {
            for (var i = 0; i < input.Length -4; i++)
            {
                // gör substrings med i
                var sub2 = "";
                var sub1 = "";
                
                if (sub2.Contains(sub1))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IsNiceVowels (string input)
        {
            var counter = 0;
            var vowels = "aeiou";
            foreach (var c in input)
            {
                if (vowels.Contains(c))
                {
                    counter++;
                    if (counter == 3)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool HasDoubleLetter (string input)
        {
            for (var i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i +1])
                {
                    return true;
                }
            }
            return false;
        }

        private static bool NoForbiddenStrings (string input)
        {
            if (input.Contains("ab") || input.Contains("cd") || input.Contains("pq") || input.Contains("xy"))
            {
                return false;
            }
            return true;
        }
    }
}
