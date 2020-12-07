using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Comp1
{
    abstract class Shapes:ShapeInterface
    {
        protected Color colour; //shapes color
        protected int x, y;
        protected Point previousPoint;
        protected Point currentPoint;
        public Shapes()
        {
            colour = Color.Red;
            x = y = 100;
        }

        public Shapes(Color colour, int x, int y)
        {
            this.colour = colour; // shapes color
            this.x = x; // x pos
            this.y = y; // y pos
        }

        // Declaring as abstract to implement them to the derived classes 
        public abstract void draw(Graphics g);
        public abstract double calcArea();
        public abstract double calcPerimeter();

        // Set is declared virtual so that it can be overriden by a specific class.
        public virtual void set(Color colour, params int[] list)
        {
            this.colour = colour;
            this.x = list[0];
            this.y = list[1];
        }

        public override string ToString()
        {
            return base.ToString() + "   " + this.x + "   " + this.y + " : ";
        }
        public void setPoint(Point previousPoint, Point currentPoint)
        {
            this.previousPoint = previousPoint;
            this.currentPoint = currentPoint;
        }
    }
}
