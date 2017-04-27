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
    int pressCount;
    int check;
    

        
  
        
        public Form1()
        {
            InitializeComponent();
            timerPress.Interval = 500;
            
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

        private void button6_Click(object sender, EventArgs e)
        {
            timerPress.Stop();
            timerPress.Start();

            pressCount = pressCount + 1;

            if (pressCount == 1){
                
                txtDisplay.Text = (txtDisplay.Text + ("a"));


            }

            if (pressCount == 2)
            {

              txtDisplay.Text = txtDisplay.Text + "b";
             
              


            }

            if (pressCount == 3)
            {
                txtDisplay.Text = txtDisplay.Text + "c";
                pressCount = 0;
              
                


            }
		}

        private void timerPress_Tick(object sender, EventArgs e)
        {
            {

                if (timerPress.Interval >= 500)
                {
this.pressCount = 0;
check = 0;
                } check = timerPress.Interval;
               
					
                   
			}
        }
        }
    }

