using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Generation_3
{
    class BinaryTree : MazeAlgorithms
    {
        Random rnd = new Random();

        public void Generate(cell[,] Board, MazeSetup setup, int mazeHeight, int mazeLength)
        {
            this.Board = Board;

            var mazeGeneration = new MazeGeneration();

            //mazeGeneration.coordStart.x = 1;
            //mazeGeneration.coordStart.y = 1;

            //mazeGeneration.coordEnd.x = mazeLength;
            //mazeGeneration.coordEnd.y = mazeHeight;

            for (int yPos = 0; yPos < mazeHeight; yPos++) // check cells specificied states below.
            {
                for (int xPos = 0; xPos < mazeLength; xPos++)
                {
                    var direction = NorthOrEast(xPos, yPos, mazeLength, mazeHeight);

                    if (direction != Direction.None)
                    {
                        var doorCoords = new Coord(xPos, yPos);
                        // add makeDoor method here
                        MakeDoor(doorCoords, direction);
                    }
                }
            }
        }
        private Direction NorthOrEast(int x, int y, int mazeWidth, int mazeHeight)
        {
            if (x == (mazeWidth - 1))
            {
                if (y == 0)
                {
                    return Direction.None;
                }
                return Direction.North;
            }
            else if (y == 0)
            {
                if (x == (mazeWidth - 1))
                {
                    return Direction.None;
                }
                return Direction.East;
            }

            int northOrEast = rnd.Next(2);
            if (northOrEast == 0)
            {
                return Direction.North;
            }
            return Direction.East;
        }

    }
}
