namespace Tis.Solving.Chaos
{
    public class CLorenz
    {
        public List<Vector3> Vs;

        public Vector3 V { get; private set; }

        /// <summary>
        /// σ > 1 — число Прандтля (критерий подобия тепловых процессов в жидкостях и газах);
        /// </summary>
        public double σ { get; set; }

        /// <summary>
        /// ρ > 0 — число Рэлея (отображает поведение жидкости под воздействием градиента температуры);
        /// </summary>
        public double ρ { get; set; }

        /// <summary>
        /// β > 0 — число, отражающее геометрию конвективной ячейки.
        /// </summary>
        public double β { get; set; }

        public Vector3 Max { get; private set; }
        public Vector3 Min { get; private set; }

        public void Step(double dTime)
        {
            lock (this)
            {
                Vector3 v = new(V.X + dTime * (σ * (V.Y - V.X)),
                                V.Y + dTime * (V.X * (ρ - V.Z) - V.Y),
                                V.Z + dTime * (V.X * V.Y - β * V.Z));
                //v.X = V.X + dTime * (σ * (V.Y - V.X));
                //v.Y = V.Y + dTime * (V.X * (ρ - V.Z) - V.Y);
                //v.Z = V.Z + dTime * (V.X * V.Y - β * V.Z);

                while (Vs.Count > 1000 / dTime)
                    Vs.RemoveAt(0);
                Vs.Add(v);
                V = v;

                Max = Vector3.Max(Max, v);
                Min = Vector3.Min(Min, v);
            }
        }

        public CLorenz(Vector3 v, double σ, double ρ, double β)
        {
            Vs = new List<Vector3>();
            V = v;
            this.σ = σ;
            this.ρ = ρ;
            this.β = β;
        }

    }
}