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
    public partial class GFeigenbaum : UserControl
    {
        bool IsVisible;
        bool IsRange;
        bool IsStep => Время.Enabled;

        public GFeigenbaum()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            FOne = new CFeigenbaum(ρ.Value, X0.Value);

            Время.Interval = 100;
            Время.Enabled = false;
            VProperty.Visible = true;

            X0.Value = 0.0 * 100;
            ρ.Value = 2.5 * 100;
            dX0.Value = 1.0 * 100;
            dρ.Value = 1.5 * 100;

            LX0.Text = $"{(X0.Value / 100):0.00}";
            Lρ.Text = $"{(ρ.Value / 100):0.00}";
            LdX0.Text = $"{(dX0.Value / 100):0.00}";
            Ldρ.Text = $"{(dρ.Value / 100):0.00}";

            B3D_Click(B3D, new EventArgs());
        }

        private void GTSwitch001_CheckedChanged(object sender)
        {
            if (GTSwitch001.Checked is null)        //null
            {
                IsVisible = false;
                IsRange = false;
                VProperty.Size = new Size(330, 15);
                G1.Visible = false;
                G2.Visible = false;
                FOne = null;
                FTwo = null;
                FThree = null;
            }
            else if (GTSwitch001.Checked.Value)     //true
            {
                IsVisible = true;
                IsRange = false;
                G1.Visible = true;
                G2.Visible = false;
                VProperty.Size = new Size(330, 90);
                FOne = new CFeigenbaum(ρ.Value / 100, X0.Value / 100);
                FTwo = null;
                FThree = null;
            }
            else                                    //false
            {
                IsVisible = true;
                IsRange = true;
                G1.Visible = true;
                G2.Visible = true;
                VProperty.Size = new Size(660, 90);
                FOne = null;
                FTwo = null;
                FThree = null;
            }

            this.Invalidate();
        }


        private void Время_Tick(object sender, EventArgs e)
        {
            if (IsVisible)
                this.Invalidate();
            GC.Collect();
        }

        private CFeigenbaum? FOne;
        private CFeigenbaum[]? FTwo;
        private CFeigenbaum[][]? FThree;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics GL = e.Graphics;

            if (IsVisible)
            {
                int Count = 300;
                double X0 = this.X0.Value / 100.0;
                double ρ = this.ρ.Value / 100.0;
                double dX0 = (this.dX0.Value / 100.0) / (Count-1);
                double dρ =  (this.dρ.Value / 100.0)  / (Count-1);

                if (!IsRange || (dX0 == 0 && dρ == 0))
                {
                    if (FOne is null || FOne.ρ != ρ || FOne.X0 != X0)
                    {
                        FOne = new CFeigenbaum(ρ, X0);
                        for (int i = 0; i < 100; i++)
                            FOne.Step();
                    }
                    FTwo = null;
                    FThree = null;

                    if (IsStep && 0 < FOne.V && FOne.V < 1)
                        FOne.Step();
                    OnDrawOne(GL, FOne);
                }
                else
                {
                    FOne = null;

                    if (dX0 == 0 || dρ == 0)
                    {
                        FThree = null;

                        if (FTwo is null)
                        {
                            FTwo = new CFeigenbaum[Count];
                            for (int i = 0; i < FTwo.Length; i++)
                                FTwo[i] = new CFeigenbaum(ρ + dρ * i, X0 + dX0 * i);
                            Parallel.ForEach(FTwo, fone => 
                            {
                                for (int j = 0; j < 100; j++) 
                                    fone.Step();
                            });
                        }

                        if (IsStep)
                            Parallel.ForEach(FTwo, fone => fone.Step());
                        OnDrawTwo(GL, FTwo);
                    }
                    else
                    {
                        FTwo = null;

                        if (FThree is null)
                        {
                            FThree = new CFeigenbaum[Count][];
                            for (int i = 0; i < FThree.Length; i++)
                            {
                                FThree[i] = new CFeigenbaum[Count];
                                for (int j = 0; j < FThree[i].Length; j++)
                                    FThree[i][j] = new CFeigenbaum(ρ + dρ * i, X0 + dX0 * j);
                            }
                            //Parallel.ForEach(FThree, ftwo => 
                            //{
                            //    Parallel.ForEach(ftwo, fone =>
                            //    {
                            //        for (int j = 0; j < 100; j++) 
                            //            fone.Step();
                            //    });
                            //});
                        }

                        if (IsStep)
                            Parallel.ForEach(FThree, ftwo =>
                            {
                                Parallel.ForEach(ftwo, fone => fone.Step());
                            });
                        OnDrawThree(GL, FThree);
                    }
                }
            }

        }

        void OnDrawOne(Graphics GL, CFeigenbaum one) => OnDrawOne(GL, one, Color.Black);
        void OnDrawOne(Graphics GL, CFeigenbaum one, Color color)
        {
            if (one is not null)
            {
                int count = 100;// one.Vs.Count;

                if (count < 2) return;
                if (count > 100) count = 100;

                float sx = this.ClientSize.Width / (float)count;
                float sy = this.ClientSize.Height / (float)1;

                GL.ResetTransform();
                GL.ScaleTransform(sx, sy);

                Pen p = new(color, 0.01f);

                one.Draw(GL, p, count);
            }
        }
        void OnDrawTwo(Graphics GL, CFeigenbaum[] two)
        {
            if (two is not null)
            {
                for (int i = 0; i < two.Length; i++)
                    OnDrawOne(GL, two[i], Tools.Colors.Pallete(i));
            }
        }
        void OnDrawThree(Graphics GL, CFeigenbaum[][] three)
        {
            if (three is null) return;
            if (three.Length == 0) return;
            if (three[0].Length == 0) return;

            int countX = three.Length;// one.Vs.Count;
            int countY = three[0].Length;

            float sx = this.ClientSize.Width / (float)(countX + 0);
            float sy = this.ClientSize.Height / (float)(countY + 0);

            GL.ResetTransform();
            GL.ScaleTransform(sx, sy);

            for (int x = 0; x < countX; x++)
            {
                for (int y = 0; y < countY; y++)
                {
                    CFeigenbaum fOne = three[x][y];
                    fOne.Vs.Clear();
                    double d = fOne.V;
                    Color c = DoubleToColor(d);
                    using Brush b = new SolidBrush(c);
                    RectangleF rect = new(x, y, 1, 1);
                    GL.FillRectangle(b, rect);
                    GL.DrawRectangle(new Pen(c, 0.01f), rect.X, rect.Y, rect.Width, rect.Height);
                }
            }

            //Pen p = new(color, 0.01f);

        }
        Color DoubleToColor(double d) 
        {
            if (d == 0) return Color.Black;
            if (d == 1) return Color.White;

            int c = (int)(256 * 256 * 256 * d);
            byte r = (byte)(c % 256);
            c = c / 256;
            byte g = (byte)(c % 256);
            c = c / 256;
            byte b = (byte)(c % 256);
            return Color.FromArgb(r,g,b);//
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            VProperty.Location = new Point(0, this.ClientSize.Height - VProperty.Height);
            this.Invalidate();
        }

        private void X0_ValueChanged(object sender, EventArgs e)
        {
            LX0.Text = $"{(X0.Value / 100):0.00}";
            //if (IsVisible && !IsRange)
            //{
            //    FOne = new CFeigenbaum(ρ.Value / 100, X0.Value / 100);
            //    for (int i = 0; i < 100; i++) FOne.Step();
            //}
            FOne = null;
            FTwo = null;
            FThree = null;
            this.Invalidate();
        }

        private void ρ_ValueChanged(object sender, EventArgs e)
        {
            Lρ.Text = $"{(ρ.Value / 100):0.00}";
            //if (IsVisible && !IsRange)
            //{
            //    FOne = new CFeigenbaum(ρ.Value / 100, X0.Value / 100);
            //    for (int i = 0; i < 100; i++) FOne.Step();
            //}
            FOne = null;
            FTwo = null;
            FThree = null;
            this.Invalidate();
        }

        private void dX0_ValueChanged(object sender, EventArgs e)
        {
            LdX0.Text = $"{(dX0.Value / 100):0.00}";
            FOne = null;
            FTwo = null;
            FThree = null;
            this.Invalidate();
        }

        private void dρ_ValueChanged(object sender, EventArgs e)
        {
            Ldρ.Text = $"{(dρ.Value / 100):0.00}";
            FOne = null;
            FTwo = null;
            FThree = null;
            this.Invalidate();
        }

        private void GFeigenbaum_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Время.Enabled = !Время.Enabled;
                VProperty.Visible = !Время.Enabled;
            }
        }

        private void B3D_Click(object sender, EventArgs e)
        {
            FOne = null;
            FTwo = null;
            FThree = null;
            this.Invalidate();
        }
    }
}
