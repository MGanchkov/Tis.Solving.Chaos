using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tis.Solving.Chaos
{
    public static class CLorenzException
    {

        public static void Draw(this CLorenz lorenz, Graphics GL, float radius, Pen Pen, SolidBrush SolidBrush)
        {
            if (radius <= 0) radius = 1;

            lock (lorenz)
            {
                if (lorenz.Vs.Count > 1)
                    GL.DrawLines(Pen, lorenz.Vs.Select(v => new PointF((float)v.X, (float)v.Y)).ToArray());

                GL.FillEllipse(SolidBrush, (float)lorenz.V.X - radius, (float)lorenz.V.Y - radius, 2.0f * radius, 2.0f * radius);
            }
        }

    }
}
