using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tis.Solving.Chaos
{
    public partial class GLorenz : UserControl
    {
        readonly bool isResize = false;

        readonly object Lock = new();
        double Time;
        CLorenz? A;
        CLorenz? B;
        readonly Pen penA = new(Color.FromArgb(200, Color.Red), 0.01f);
        readonly Pen penB = new(Color.FromArgb(200, Color.Green), 0.01f);
        readonly SolidBrush brushA = new(System.Drawing.Color.Red);
        readonly SolidBrush brushB = new(System.Drawing.Color.Green);


        bool IsTask;
        Task? Task;


        public GLorenz()
        {
            InitializeComponent();
            this.DoubleBuffered = true;



            double d = 1;
            double k = 1;
            while (true)
            {
                double i = 1 + d / Math.Pow(10, k);
                if (i > 1)
                    k++;
                else break;
            }
            k -= 1;

            k -= 2;

            d = 1 / Math.Pow(10, k);

            Vσ.Text = "10,0";
            Vρ.Text = "28,0";
            Vβ.Text = $"{8 / 3}";

            VAX.Text = $"0,0";
            VAY.Text = $"1,0";
            VAZ.Text = $"1,0";

            VBX.Text = $"0,0";
            VBY.Text = $"1,0";
            VBZ.Text = $"{1 + d}";

            VProperty.Visible = true;
            VProperty.Padding = new Padding(0, 0, 0, 0);
            VProperty.Margin = new Padding(0, 0, 0, 0);
            VProperty.Location = new Point(0, 0);
            if (isResize) this.ClientSize = VProperty.Size;
            else this.ClientSize = new Size(800, 600);
        }

        protected override void OnResize(EventArgs e)
        {
            if (!IsTask && isResize)
            {
                VProperty.Visible = true;
                VProperty.Padding = new Padding(0, 0, 0, 0);
                VProperty.Margin = new Padding(0, 0, 0, 0);
                VProperty.Location = new Point(0, 0);
                this.ClientSize = VProperty.Size;
            }
            base.OnResize(e);

        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (Task != null || IsTask)
            {
                IsTask = false;
                Task = null;

                VProperty.Visible = true;
                VProperty.Padding = new Padding(0, 0, 0, 0);
                VProperty.Margin = new Padding(0, 0, 0, 0);
                VProperty.Location = new Point(0, 0);
                if (isResize) this.ClientSize = VProperty.Size;
            }
            base.OnMouseClick(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (A is null || B is null) return;

            Graphics GL = e.Graphics;

            CVector3D Max = CVector3D.Max(A.Max, B.Max);
            CVector3D Min = CVector3D.Min(A.Min, B.Min);

            GL.DrawString($"Время: {Time};\r\n" +
                          $"dX={A.V.X - B.V.X};\r\n" +
                          $"dY={A.V.Y - B.V.Y};\r\n" +
                          $"dZ={A.V.Z - B.V.Z}", this.Font, Brushes.Black, new Point(0, 0));

            GL.TranslateTransform(ClientSize.Width * 0.5f, ClientSize.Height * 0.5f);

            float kx;
            float ky;
            float kz;

            kx = (float)Math.Max(Math.Abs(Max.X), Math.Abs(Min.X));
            if (kx == 0 || !float.IsNormal(kx)) kx = ClientSize.Width;
            kx = 0.5f * ClientSize.Width / (kx + 10);

            ky = (float)Math.Max(Math.Abs(Max.Y), Math.Abs(Min.Y));
            if (ky == 0 || !float.IsNormal(ky)) ky = ClientSize.Height;
            ky = 0.5f * ClientSize.Height / (ky + 10);

            GL.ScaleTransform(kx, ky);


            kz = (float)Math.Max(Math.Abs(Max.Z), Math.Abs(Min.Z));

            float radiusA = (float)A.V.Z / kz;
            float radiusB = (float)B.V.Z / kz;

            if (radiusA <= 0 || kz == 0) radiusA = 1;
            if (radiusB <= 0 || kz == 0) radiusB = 1;

            lock (Lock)
            {
                if (A.Vs.Count > 1)
                    GL.DrawLines(penA, A.Vs.Select(v => new PointF((float)v.X, (float)v.Y)).ToArray());
                if (B.Vs.Count > 1)
                    GL.DrawLines(penB, B.Vs.Select(v => new PointF((float)v.X, (float)v.Y)).ToArray());

                GL.FillEllipse(brushA, (float)A.V.X - radiusA, (float)A.V.Y - radiusA, 2.0f * radiusA, 2.0f * radiusA);
                GL.DrawEllipse(new Pen(Color.Black, penA.Width), (float)A.V.X - radiusA, (float)A.V.Y - radiusA, 2.0f * radiusA, 2.0f * radiusA);
                GL.FillEllipse(brushB, (float)B.V.X - radiusB, (float)B.V.Y - radiusB, 2.0f * radiusB, 2.0f * radiusB);
                GL.DrawEllipse(new Pen(Color.Black, penB.Width), (float)B.V.X - radiusB, (float)B.V.Y - radiusB, 2.0f * radiusB, 2.0f * radiusB);

                if (A.V.X - B.V.X > 0.1 && A.V.Y - B.V.Y > 0.1 && A.V.Z - B.V.Z > 0.1 && TimeSleep == 0) TimeSleep = 1;
            }

            //A?.Draw(GL, radiusA);
            //B?.Draw(GL, radiusB);
        }

        readonly double dT = 0.001;
        private int TimeSleep = 0;
        private void RunLorens()
        {
            while (IsTask)
            {
                lock (Lock)
                {
                    A?.Step(dT);
                    B?.Step(dT);
                }
                Time += dT;

                if (A is null && B is null) IsTask = false;

                this.Invalidate();
                if (TimeSleep > 0) Thread.Sleep(TimeSleep);
            }
        }

        private void BRun_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Vσ.Text, out double σ) &&
                double.TryParse(Vρ.Text, out double ρ) &&
                double.TryParse(Vβ.Text, out double β) &&
                double.TryParse(VAX.Text, out double ax) &&
                double.TryParse(VAY.Text, out double ay) &&
                double.TryParse(VAZ.Text, out double az) &&
                double.TryParse(VBX.Text, out double bx) &&
                double.TryParse(VBY.Text, out double by) &&
                double.TryParse(VBZ.Text, out double bz))
            {
                VProperty.Visible = false;

                Time = 0;
                TimeSleep = 0;

                Create(σ, ρ, β, ax, ay, az, bx, by, bz);

                IsTask = true;
                Task = Task.Run(RunLorens);
                if (isResize) this.ClientSize = new Size(Math.Max(800, this.Width), Math.Max(600, this.Height));
            }
        }
        private void Create(double σ, double ρ, double β,
                            double ax, double ay, double az,
                            double bx, double by, double bz)
        {
            A = new CLorenz(new CVector3D(ax, ay, az), σ, ρ, β);
            B = new CLorenz(new CVector3D(bx, by, bz), σ, ρ, β);
        }

        private void V_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                if (double.TryParse(tb.Text, out double _))
                {
                    tb.BackColor = Color.Lime;
                }
                else tb.BackColor = Color.Tomato;
            }
        }

    }
}
