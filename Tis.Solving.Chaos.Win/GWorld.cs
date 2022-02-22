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
    public partial class GWorld : UserControl
    {

        CWorld? world;

        public CWorld? World
        {
            get => world;
            set => world = value;
        }

        public GWorld()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }
        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        double fps = -1;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (world is null) return;

            Graphics GL = e.Graphics;

            float sW = (float)(ClientSize.Width / world.Size.Width);
            float sH = (float)(ClientSize.Height / world.Size.Height);

            //GL.TranslateTransform(sW, sH);

            DateTime start = DateTime.Now;
            world.Draw(GL);
            DateTime end = DateTime.Now;

            GL.ResetTransform();

            if (world.Count > 0)
                GL.DrawString($"[{world.Count}] {(world.Span / world.Count).TotalMilliseconds}", Font, Brushes.Black, 0, 0);

            if (world.Count > 0)
            {
                if (fps < 0) fps = 1 / (end - start).TotalSeconds;
                else fps += (1 / (end - start).TotalSeconds - fps) / Math.Max(1, fps);
                string s = $"FPS: {(1 / (end - start).TotalSeconds):#,##0}";
                SizeF size = GL.MeasureString(s, Font);
                GL.DrawString(s, Font, Brushes.Black, ClientSize.Width - size.Width, 0);

            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                isRuning = !isRuning;
            }
            else if (world != null && !isRuning)
            {
                RectangleF p = world.RectangleDraw(ClientRectangle);

                if (p.Contains(e.Location))
                {
                    CVector2D point = new(world.Size.Width * (e.Location.X - p.X) / p.Width,
                                          world.Size.Height * (e.Location.Y - p.Y) / p.Height);

                    CBody? body = world.Bodies.FirstOrDefault(b => b.Location.Distance(new CVector3D(point.X, point.Y, 0.0)) < b.Radius, null);
                    if (body is null)
                    {
                        VBodyCreate.Clear(new CVector3D(point.X, point.Y, 0), new CVector3D(0, 0, 0), 10, 1, 0);

                        int x = e.Location.X + 5;
                        int y = e.Location.Y + 5;

                        if (x + GB001.Width > ClientSize.Width) x = e.Location.X - GB001.Width - 5;
                        if (y + GB001.Height > ClientSize.Height) y = e.Location.Y - GB001.Height - 5;

                        if (x < 0 || y < 0)
                            ToolsWin.Box.ShowMessage("Не возможно отобразить внутреннее окно.\r\n" +
                                                     "Увелисте отображаемый размер мира.", "Не возможность", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GB001.Location = new Point(x, y);
                        
                        GB001.Visible = true;
                    }
                }
            }

            base.OnMouseClick(e);
        }

        public void Run() => isRuning = true;
        public void Stop() => isRuning = false;

        public bool IsRuning => isRuning;
        bool isRuning = false;
        bool isRun = false;
        private void Время_Tick(object sender, EventArgs e)
        {
            if (world is not null)
            {
                if (isRuning && !isRun)
                {
                    isRun = true;
                    world.Solving();
                    double dT = world.dT;
                    if (dT == 0) dT = 0.000001;
                    world.Step(dT);
                    isRuning = world.Bodies.Count > 1;
                    isRun = false;
                }

                Form f = this.ParentForm;
                if (f != null)
                {
                    if (world.Time > 0)
                        f.Text = $"[{world.Time}] {(world.Span / world.Time).TotalMilliseconds} [{(isRuning ? "Runing" : "Stop")}]";
                    else
                    {
                        f.Text = $"No runing";
                    }
                }

                //GC.Collect();
            }

            this.Invalidate();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            GB001.Visible = false;
            VBodyCreate.Clear();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (!isRuning && world is not null && VBodyCreate.TryNew(out CBody? body) && body is not null)
            {
                world.Add(body);
            }
            BClose_Click(BClose, e);
        }
    }
}
