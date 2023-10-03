using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode15.Models
{
    public class CoordinateToggle
    {
        public int FromRow { get; set; }
        public int ToRow { get; set; }
        public int FromColumn { get; set; }
        public int ToColumn { get; set; }
        public string Action { get; set; }
    }
}
