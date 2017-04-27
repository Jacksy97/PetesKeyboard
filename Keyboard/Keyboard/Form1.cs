using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard
{
    public partial class Form1 : Form
    {int ModeCount = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            

            if (ModeCount == 0) {

                ModeCount = 1;
                txtStatus.Text = "Multi Press";



            }else if (ModeCount == 1)
            {
                ModeCount = 0;
                txtStatus.Text = "Prediction";

            }

        }
    }
}
