using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tis.Solving.Chaos.WinExe
{
    public partial class FWorld : Form
    {
        public FWorld()
        {
            InitializeComponent();

            VWorld.World = new CWorld(800, 600);

        }
    }
}
