using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tis.Solving.Chaos
{
    public class CWorld
    {
        public bool IsMerger { get; set; } = true;
        public CSizeD Size { get; set; }
        public double Time { get; private set; }
        public long Count { get; private set; }
        public TimeSpan Span { get; private set; }
        public TimeSpan SpanSolving { get; private set; }

        public List<CBody> Bodies { get; }
        public double dT { get; set; }



        readonly object Lock = new();
        public CWorld(double width, double height)
        {
            Size = new CSizeD(width, height);
            Bodies = new List<CBody>();

        }

        public void Add(CBody body)
        {
            lock (Lock)
            {
                Bodies.Add(body);
            }            
        }
        public void Add(CVector3D location, CVector3D speed, double radius, double m, double q) => Add(new CBody(CSID.New, true, location, speed, CVector3D.Zero, radius, m, q));

        public void Solving()
        {
            DateTime start = DateTime.Now;
            Parallel.ForEach(Bodies, body => body.Solving(Bodies));
            this.dT = Bodies.Min(b => b.dT);
            DateTime stop = DateTime.Now;
            SpanSolving += (stop - start);
        }

        public void Step(double t)
        {
            DateTime start = DateTime.Now;

            Parallel.ForEach(Bodies, body => body.Step(t));
            if (IsMerger)
            {
                List<CBody> R = new();
                for (int i = 0; i < Bodies.Count; i++)
                {
                    for (int j = 0; j < Bodies.Count; j++)
                    {
                        CBody a = Bodies[i];
                        CBody b = Bodies[j];
                        if (!ReferenceEquals(a, b) && a.IsEnable && b.IsEnable)
                        {
                            double d = b.Location.Distance(a.Location);

                            if (d < b.Radius + b.Radius)
                            {
                                double ad = a.Density;
                                double bd = b.Density;

                                if (ad == 0) ad = 1;
                                if (bd == 0) bd = 1;

                                //Изменение координат в зависимости от плотности
                                a.Location = (a.Location * ad + b.Location * bd) / (ad + bd);
                                //Закон сохранения импульса.
                                if (a.m != 0 && b.m != 0) 
                                    a.Speed = (a.Speed * a.m + b.Speed * b.m) / (a.m + b.m);
                                else
                                    a.Speed = a.Speed + b.Speed;
                                //Изменяем радиус, плотность остаётся средней.
                                a.Radius = Math.Pow(a.Radius * a.Radius * a.Radius + b.Radius * b.Radius * b.Radius, 1.0 / 3.0);

                                a.m += b.m;
                                a.q += b.q;

                                b.IsEnable = false;
                                R.Add(b);
                            }
                        }
                    }
                }

                foreach (CBody body in R)
                    Bodies.Remove(body);
            }

            DateTime stop = DateTime.Now;


            Time += t;
            Count += 1;
            Span += (stop - start);
        }


    }
}
