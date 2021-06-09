using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSnake
{
    class Figure
    {
        protected List<Point> pList;

<<<<<<< HEAD
        public void Draw()
=======
        public new void Draw()
>>>>>>> 3739da9b997b84e7cb357239cb9f1a7c1d406522
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
<<<<<<< HEAD
        internal bool IsHit(Figure figure)
        {
            foreach (Point p in pList)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }
        internal bool IsHit(Point point)
        {
            foreach (Point p in pList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
=======
>>>>>>> 3739da9b997b84e7cb357239cb9f1a7c1d406522
    }
}