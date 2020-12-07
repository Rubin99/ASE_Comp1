using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace ASE_Comp1
{
    class Rectangle : Shapes
    {
        int width, height;
        public Rectangle() : base()
        {
            width = 100;
            height = 100;
        }

        public Rectangle(Color colour, int x, int y, int width, int height) : base(colour, x, y) // Constructor
        {
            this.width = width; // Extra property from shapes
            this.height = height;
        }

        public override void set(Color colour, params int[] list)
        {
            base.set(colour, list[0], list[1]);
            this.width = list[2];
            this.width = list[3];
        }

        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.FillRectangle(b, x, y, width, height);
            g.DrawRectangle(p, x, y, width, height);
        }

        public override double calcArea()
        {
            return width * height;
        }

        public override double calcPerimeter()
        {
            return 2 * width + 2 * height;
        }

    }
}
