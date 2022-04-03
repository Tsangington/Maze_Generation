using System.Windows.Forms;
using System.Drawing;

namespace Maze_Generation_3
{
    public partial class MazeGeneration : Form
    {
        public struct Coord
        {
            public int x;
            public int y;

            public Coord(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public Coord coordStart;
        public Coord coordEnd;

        private void pictureBoxMazePaint(object sender, PaintEventArgs e)
        {
            if (Board == null)  // used so the code below is not ran upon start up, saving time for the user.
            {
                return;
            }
            Graphics mazeRender = e.Graphics;

            Pen gridPen = new Pen(Color.Black);
            gridPen.Width = 4.0F;

            const int roomSize = 30;

            for (int x = 0; x < int.Parse(textboxLength.Text); x++)
            {
                for (int y = 0; y < int.Parse(textboxHeight.Text); y++)
                {
                    var yCoord = y * roomSize;
                    var xCoord = x * roomSize;
                    if (Board[x, y].northWall == true)
                    {
                        mazeRender.DrawLine(gridPen, xCoord, yCoord, xCoord + roomSize, yCoord);
                    }
                    if (Board[x, y].southWall == true)
                    {
                        mazeRender.DrawLine(gridPen, xCoord, yCoord + roomSize, xCoord + roomSize, yCoord + roomSize);
                    }
                    if (Board[x, y].eastWall == true)
                    {
                        mazeRender.DrawLine(gridPen, xCoord + roomSize, yCoord, xCoord + roomSize, yCoord + roomSize);
                    }
                    if (Board[x, y].westWall == true)
                    {
                        mazeRender.DrawLine(gridPen, xCoord, yCoord, xCoord, yCoord + roomSize);
                    }
                }
            }
            // Create solid brush.
            SolidBrush startPen = new SolidBrush(Color.Green);

            int xStart = int.Parse(textboxXStart.Text)-1;
            int yStart = int.Parse(textboxYStart.Text)-1;

            // Create rectangle.
            Rectangle startRect = new Rectangle(xStart * roomSize+2, yStart * roomSize+2, roomSize-4, roomSize-4);

            // Fill rectangle to screen.
            e.Graphics.FillRectangle(startPen, startRect);

            //SolidBrush endPen = new SolidBrush(Color.Red);
            //int xEnd = coordEnd.x;
            //int yEnd = coordEnd.y;
            //Rectangle EndRect = new Rectangle(xEnd * roomSize + 2, yEnd * roomSize + 2, roomSize - 4, roomSize - 4);
            //e.Graphics.FillRectangle(endPen, EndRect);

        }
    }
}