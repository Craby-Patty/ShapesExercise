using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class Rectangle : CentrePoint
    {
        private int width;
        private int height;

        public Rectangle(int x, int y, int width, int height) : base(x, y)

        {
            Width = width;
            Height = height;

        }

         public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public override string ToString()
        {
            return string.Format("\n Rectangle ({0},{1}) width={2} height={3}", X, Y, Width, Height);
        }

    }
}
