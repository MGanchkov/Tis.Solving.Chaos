using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tis.Solving.Chaos
{ 
    public static class CFeigenbaumExtension
    {
        public static void Draw(this CFeigenbaum feigenbaum, Graphics GL) => Draw(feigenbaum, GL, Pens.Black);
        public static void Draw(this CFeigenbaum feigenbaum, Graphics GL, Pen pen, int count = 100)
        {
            lock (feigenbaum)
            {
                if (feigenbaum.Vs.Count > 1)
                {
                    if (count < 2) count = feigenbaum.Vs.Count;
                    if (count > feigenbaum.Vs.Count) count = feigenbaum.Vs.Count;

                    float y1 = (float)feigenbaum.Vs[feigenbaum.Vs.Count - count];
                    float y2 = y1;
                    float x0 = feigenbaum.Vs.Count - count;
                    for (int i = (int)x0 + 1; i < feigenbaum.Vs.Count; i++)
                    {
                        y2 = (float)feigenbaum.Vs[i];
                        GL.DrawLine(pen, i - 1 - x0, y1, i - x0, y2);
                        y1 = y2;
                    }
                    
                }
            }
        }
    }
}
