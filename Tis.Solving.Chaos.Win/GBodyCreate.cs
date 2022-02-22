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
    public partial class GBodyCreate : UserControl
    {
        public GBodyCreate()
        {
            InitializeComponent();
            this.ClientSize = TLP001.Size;
            this.MinimumSize = TLP001.MinimumSize;
            this.MaximumSize = TLP001.MaximumSize;
            TLP001.Dock = DockStyle.Fill;
        }

        public void Clear() => Clear(CVector3D.Zero, CVector3D.Zero, 0, 0, 0);
        public void Clear(CVector3D location, CVector3D speed, double radius, double m, double q)
        {
            VLocation.Set(location);
            VSpeed.Set(speed);
            VRadius.Text = $"{radius}";
            Vm.Text = $"{m}";
            Vq.Text = $"{q}";

        }

        public bool TryNew(out CBody? body)
        {
            if (VLocation.TryNew(out CVector3D Location) &&
                VSpeed.TryNew(out CVector3D Speed) &&
                double.TryParse(VRadius.Text, out double Radius) &&
                double.TryParse(Vm.Text, out double m) &&
                double.TryParse(Vq.Text, out double q))
            {
                body = new CBody(Location, Speed, Radius, m, q);
            }
            else body = null;

            return body is not null;
        }

        private void VDouble_TextChanged(object? sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (double.TryParse(textBox.Text, out double _))
                    textBox.BackColor = Color.LightGreen;
                else textBox.BackColor = Color.Tomato;
            }
        }

    }
}
