using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Comp1
{
    class Line : Shapes
    {
        public override double calcArea()
        {
            throw new NotImplementedException();
        }

        public override double calcPerimeter()
        {
            throw new NotImplementedException();
        }

        public override void draw(Graphics g)
        {
            try
            {
                Pen p = new Pen(colour, 2);
                g.DrawLine(p, previousPoint, currentPoint);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0} error in Line Draw", e.Message);
                Console.WriteLine("{0} ", e.StackTrace);
                Console.WriteLine("Error on {0}", e.GetType());
            }

        }
    }
}
