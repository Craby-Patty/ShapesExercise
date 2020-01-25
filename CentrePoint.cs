using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class CentrePoint : Widget
    {
        private int x;
        private int y;

        public CentrePoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public CentrePoint() { }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return string.Format("\n Center Point x {0} y {1}", X, Y );
        }

    }
}
