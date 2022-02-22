namespace Tis.Solving.Chaos
{
    public class CLorenz
    {
        public List<CVector3D> Vs;

        public CVector3D V { get; private set; }

        /// <summary>
        /// σ > 1 — число Прандтля (критерий подобия тепловых процессов в жидкостях и газах);
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Стили именования", Justification = "<Ожидание>")]
        public double σ { get; set; }


        /// <summary>
        /// ρ > 0 — число Рэлея (отображает поведение жидкости под воздействием градиента температуры);
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Стили именования", Justification = "<Ожидание>")]
        public double ρ { get; set; }

        /// <summary>
        /// β > 0 — число, отражающее геометрию конвективной ячейки.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Стили именования", Justification = "<Ожидание>")]
        public double β { get; set; }

        public CVector3D Max { get; private set; }
        public CVector3D Min { get; private set; }

        public void Step(double dTime)
        {
            lock (this)
            {
                CVector3D v = new(V.X + dTime * (σ * (V.Y - V.X)),
                                  V.Y + dTime * (V.X * (ρ - V.Z) - V.Y),
                                  V.Z + dTime * (V.X * V.Y - β * V.Z));
                //v.X = V.X + dTime * (σ * (V.Y - V.X));
                //v.Y = V.Y + dTime * (V.X * (ρ - V.Z) - V.Y);
                //v.Z = V.Z + dTime * (V.X * V.Y - β * V.Z);

                while (Vs.Count > 1000 / dTime)
                    Vs.RemoveAt(0);
                Vs.Add(v);
                V = v;

                Max = CVector3D.Max(Max, v);
                Min = CVector3D.Min(Min, v);
            }
        }

        public CLorenz(CVector3D v, double σ, double ρ, double β)
        {
            Vs = new List<CVector3D>();
            V = v;
            this.σ = σ;
            this.ρ = ρ;
            this.β = β;
        }

    }
}