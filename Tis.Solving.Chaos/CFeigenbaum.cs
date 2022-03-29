using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tis.Solving.Chaos
{
    public class CFeigenbaum
    {
        public List<double> Vs { get; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Стили именования", Justification = "<Ожидание>")]
        public double ρ { get; }
        public double X0 { get; }

        public CFeigenbaum(double ρ, double x0)
        {
            this.ρ = ρ;
            this.X0 = x0;
            this.V = x0;
            Vs = new();
            Min = x0;
            Max = x0;
        }

        public double V { get; private set; }
        public double Max { get; private set; }
        public double Min { get; private set; }

        public void Step()
        {
            double v = ρ * V * (1 - V);
            if (0 < v && v < 10) 
            {
                V = v;
                Vs.Add(V);
                if (V < Min) Min = V;
                if (V > Max) Max = V;
            }
            else
            {
                V = -1;
                Vs.Add(V);
            }
            
            
        }
        

    }
}
