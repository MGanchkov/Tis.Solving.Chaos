using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tis.Solving.Chaos
{
    public class CBody
    {

        public CBody(CVector3D location, CVector3D speed, double radius, double m, double q)
            : this(new CSID(), true, location, speed, CVector3D.Zero, radius, m, q) { }

        [System.Text.Json.Serialization.JsonConstructor]
        public CBody(CSID id, bool isEnable, CVector3D location, CVector3D speed, CVector3D acceleration, double radius, double m, double q)
        {
            ID = id;
            IsEnable = isEnable;
            Location = location;
            Speed = speed;
            Acceleration = acceleration;
            Radius = radius;
            this.m = m;
            this.q = q;
        }

        public CSID ID { get; set; }

        public bool IsEnable { get; set; }
        public CVector3D Location { get; set; }

        public CVector3D Speed { get; set; }

        public CVector3D Acceleration { get; set; }

        public double Radius { get; set; }

        public double Volume => (4 / 3) * Math.PI * Radius * Radius * Radius;
        public double Density => m / Volume;

        /// <summary>
        /// Масса
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Стили именования", Justification = "Масса объекта")]
        public double m { get; set; }
        /// <summary>
        /// Заряд
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Стили именования", Justification = "Электрический заряд")]
        public double q { get; set; }

        public double dT { get; set; }




        CVector3D A(CBody b)
        {
            CVector3D a;
            CVector3D r = b.Location - this.Location;
            double d = r.Magnitude;
            double d3 = d * d * d;

            a = Tools.Maths.Const.G * b.m * r / d3;       //Гравитация.
            a -= Tools.Maths.Const.k * q * b.q * r / d3;  //Куллон, притягиваются, если заряды разные.

            return a;
        }

        public void Solving(IEnumerable<CBody> bodies)
        {
            CVector3D a = CVector3D.Zero;

            foreach (CBody b in bodies.Where(body => !ReferenceEquals(this, body))) 
                a += A(b);

            Acceleration = a;

            double dT = a.Magnitude;
            this.dT = 1 * Radius / dT;

            if (!double.IsNormal(a.X))
            {
                Console.WriteLine("123");
            }
        }

        public void Step(double t)
        {
            int count = 10;
            double dt = t / count;
            CVector3D dSpeed = Acceleration * dt;

            for (int i = 0; i < count; i++)
            {
                Location += Speed * dt + dSpeed * dt / 2;
                Speed += dSpeed;
            }


            if (!double.IsNormal(Location.X))
            {
                Console.WriteLine("123");
            }
        }

    }
}
