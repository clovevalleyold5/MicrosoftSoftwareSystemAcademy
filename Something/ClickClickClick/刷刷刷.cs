using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickClickClick
{
    public partial class 刷刷刷 : Form
    {
        Autoit autoit = new Autoit();
        public 刷刷刷()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                autoit.mClick("LEFT", 1111, 444, 1, -1);
            }
        }
    }
}
