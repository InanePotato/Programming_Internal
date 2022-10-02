using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Internal
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            PNL_LevelDisplay.Location = new Point((this.Width - PNL_LevelDisplay.Width) / 2, (this.Height - PNL_LevelDisplay.Height) / 2);
        }
    }
}
