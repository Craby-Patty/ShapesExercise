using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class TextBox : Rectangle
    {
        private string text;
    

        public TextBox(int x, int y, int width, int height, string text) : base(x, y, width, height)

        {
            Text = text;
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }


        public override string ToString()
        {
            return string.Format("\n Textbox ({0},{1}) width={2} height={3} Text=\"{4}\"", X, Y, Width, Height, Text);
        }
    }

}
