using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tis.Solving.Chaos
{
    public class CBigLorenz
    {
        CDouble X;
        CDouble Y;
        CDouble Z;
        CVector3D v;

        public List<CVector3D> Vs;

        public CVector3D V => v;

        /// <summary>
        /// σ > 1 — число Прандтля (критерий подобия тепловых процессов в жидкостях и газах);
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Стили именования", Justification = "<Ожидание>")]
        public double σ { get; }


        /// <summary>
        /// ρ > 0 — число Рэлея (отображает поведение жидкости под воздействием градиента температуры);
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Стили именования", Justification = "<Ожидание>")]
        public double ρ { get; }

        /// <summary>
        /// β > 0 — число, отражающее геометрию конвективной ячейки.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Стили именования", Justification = "<Ожидание>")]
        public double β { get; }

        public CVector3D Max { get; private set; }
        public CVector3D Min { get; private set; }

        public void Step(double dTime)
        {
            lock (this)
            {

                CDouble x = X + dTime * (σ * (Y - X));
                CDouble y = Y + dTime * (X * (ρ - Z) - Y);
                CDouble z = Z + dTime * (X * Y - β * Z);

                //x.Simplify();
                //y.Simplify();
                //z.Simplify();

                X = x;
                Y = y;
                Z = z;
                v = new CVector3D(X.ToDouble(), Y.ToDouble(), Z.ToDouble());

                while (Vs.Count > 1000 / dTime)
                    Vs.RemoveAt(0);
                Vs.Add(v);

                Max = CVector3D.Max(Max, v);
                Min = CVector3D.Min(Min, v);
            }
        }

        public CBigLorenz(CVector3D v, double σ, double ρ, double β)
        {
            Vs = new List<CVector3D>();
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            this.v = v;

            this.σ = σ;
            this.ρ = ρ;
            this.β = β;
        }

    }
}
