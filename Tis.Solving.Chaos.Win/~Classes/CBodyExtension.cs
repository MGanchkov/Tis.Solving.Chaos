using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tis.Solving.Chaos
{
    public static class CBodyExtension
    {
        public static Brush Body { get; set; } = new SolidBrush(Color.LimeGreen);
        public static Brush BodyPositive { get; set; } = new SolidBrush(Color.Blue);
        public static Brush BodyNegativ { get; set; } = new SolidBrush(Color.Red);
        public static Pen BodyPen { get; set; } = new Pen(Color.LimeGreen);


        public static void Draw(this CBody body, Graphics GL)
        {
            RectangleF rect = new((float)(body.Location.X - body.Radius),
                                  (float)(body.Location.Y - body.Radius),
                                  (float)body.Radius,
                                  (float)body.Radius);

            if (body.q<0)
                GL.FillEllipse(BodyNegativ, rect);
            else if (body.q>0)
                GL.FillEllipse(BodyPositive, rect);
            else
                GL.FillEllipse(Body, rect);

            GL.DrawEllipse(BodyPen, rect);
        }
    }
}
