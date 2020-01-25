using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class Square : CentrePoint 
    {
        private int size;

        public Square(int x, int y, int size) : base(x, y)
        {
            Size = size;
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public override string ToString()
        {
            return string.Format("\n Square ({0},{1}) size={2}", X, Y, Size);
        }

    }
}
