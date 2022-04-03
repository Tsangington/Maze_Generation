using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Generation_3
{
    public class cell
    {
        public bool visited = false;
        public bool northWall = true;
        public bool southWall = true;
        public bool eastWall = true;
        public bool westWall = true;
    }
}
