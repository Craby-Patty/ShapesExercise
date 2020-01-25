using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class Ellipse : Circle
    {
        int verticalDiameter;

        public Ellipse(int x, int y, int diameter, int verticalDiameter) : base (x,y,diameter) 
        {
            VerticalDiameter = verticalDiameter;

        }

        public int VerticalDiameter
        {
            get { return verticalDiameter; }
            set { verticalDiameter = value; }
        }

        public override string ToString()
        {
            return string.Format("\n Ellipse ({0},{1}) diameterH = {2} diameterV = {3}",X,Y, Diameter, VerticalDiameter);
        }
    }
}
