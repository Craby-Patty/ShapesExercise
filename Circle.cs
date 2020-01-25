using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class Circle : CentrePoint
    {
        private int diameter;

        public Circle(int x, int y, int diameter) : base(x,y)

        {
            Diameter = diameter;
        }

        public int Diameter
        {
            get{ return diameter; }
            set{ diameter = value; }
        }

        public override string ToString()
        {
            return string.Format("\n Circle ({0},{1}) size={2}",X,Y,Diameter);
        }


    }
}
