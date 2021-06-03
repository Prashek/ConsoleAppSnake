using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSnake
{
<<<<<<< HEAD

=======
>>>>>>> 3739da9b997b84e7cb357239cb9f1a7c1d406522
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}