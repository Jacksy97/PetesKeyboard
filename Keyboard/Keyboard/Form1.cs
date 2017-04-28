using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;
using System.IO;


namespace Keyboard
{
    public partial class Form1 : Form
    {
        int ModeCount = 0;
        int pressCount;
        int check;
        string Str_KeyStrokes;
        int num;
        string delay = "500";
        string FilePath;
        





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


            if (ModeCount == 0)
            {

                ModeCount = 1;
                txtStatus.Text = "Multi Press";



            }
            else if (ModeCount == 1)
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

            if (pressCount == 1)
            {
                Str_KeyStrokes = Str_KeyStrokes + "8";
                txtDisplay.Text = (txtDisplay.Text + ("a"));

            }

            if (pressCount == 2)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "b";
            }

            if (pressCount == 3)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "c";

            }
            if (pressCount == 4)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "8";
            }
            if (pressCount == 5)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "A";
            }

            if (pressCount == 6)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "B";
            }

            if (pressCount == 7)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "C";
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

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            timerPress.Stop();
            timerPress.Start();

            pressCount = pressCount + 1;

            if (pressCount == 1)
            {
                Str_KeyStrokes = Str_KeyStrokes + "9";
                txtDisplay.Text = (txtDisplay.Text + ("d"));

            }

            if (pressCount == 2)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "e";
            }

            if (pressCount == 3)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "f";

            }
            if (pressCount == 4)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "9";
            }
            if (pressCount == 5)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "D";
            }

            if (pressCount == 6)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "E";
            }

            if (pressCount == 7)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "F";
                pressCount = 0;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            timerPress.Stop();
            timerPress.Start();

            pressCount = pressCount + 1;

            if (pressCount == 1)
            {

                txtDisplay.Text = (txtDisplay.Text + ("g"));
                Str_KeyStrokes = Str_KeyStrokes + "4";

            }

            if (pressCount == 2)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "h";
            }

            if (pressCount == 3)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "i";

            }
            if (pressCount == 4)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "4";
            }
            if (pressCount == 5)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "G";
            }

            if (pressCount == 6)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "H";
            }

            if (pressCount == 7)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "I";
                pressCount = 0;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            {
                timerPress.Stop();
                timerPress.Start();

                pressCount = pressCount + 1;

                if (pressCount == 1)
                {

                    txtDisplay.Text = (txtDisplay.Text + ("j"));
                    Str_KeyStrokes = Str_KeyStrokes + "5";

                }

                if (pressCount == 2)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "k";
                }

                if (pressCount == 3)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "l";

                }
                if (pressCount == 4)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "5";
                }
                if (pressCount == 5)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "J";
                }

                if (pressCount == 6)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "K";
                }

                if (pressCount == 7)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "L";
                    pressCount = 0;
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            {
                timerPress.Stop();
                timerPress.Start();

                pressCount = pressCount + 1;

                if (pressCount == 1)
                {

                    txtDisplay.Text = (txtDisplay.Text + ("m"));
                    Str_KeyStrokes = Str_KeyStrokes + "6";

                }

                if (pressCount == 2)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "n";
                }

                if (pressCount == 3)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "o";

                }
                if (pressCount == 4)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "6";
                }
                if (pressCount == 5)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "M";
                }

                if (pressCount == 6)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "N";
                }

                if (pressCount == 7)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "O";
                    pressCount = 0;
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            {
                timerPress.Stop();
                timerPress.Start();

                pressCount = pressCount + 1;

                if (pressCount == 1)
                {

                    txtDisplay.Text = (txtDisplay.Text + ("p"));
                    Str_KeyStrokes = Str_KeyStrokes + "1";

                }

                if (pressCount == 2)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "q";
                }

                if (pressCount == 3)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "r";

                }
                if (pressCount == 4)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "s";
                }
                if (pressCount == 5)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "1";
                }

                if (pressCount == 6)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "P";
                }

                if (pressCount == 7)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "Q";

                }

                if (pressCount == 8)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "R";

                }

                if (pressCount == 7)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "S";
                    pressCount = 0;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            timerPress.Stop();
            timerPress.Start();

            pressCount = pressCount + 1;

            if (pressCount == 1)
            {

                txtDisplay.Text = (txtDisplay.Text + ("t"));
                Str_KeyStrokes = Str_KeyStrokes + "2";

            }

            if (pressCount == 2)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "u";
            }

            if (pressCount == 3)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "v";

            }
            if (pressCount == 4)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "w";
            }
            if (pressCount == 5)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "2";
            }

            if (pressCount == 6)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "T";
            }

            if (pressCount == 7)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "U";

            }

            if (pressCount == 8)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "V";

            }

            if (pressCount == 7)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "W";
                pressCount = 0;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            {
                timerPress.Stop();
                timerPress.Start();

                pressCount = pressCount + 1;

                if (pressCount == 1)
                {

                    txtDisplay.Text = (txtDisplay.Text + ("x"));
                    Str_KeyStrokes = Str_KeyStrokes + "3";

                }

                if (pressCount == 2)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "y";
                }

                if (pressCount == 3)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "z";

                }
                if (pressCount == 4)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "3";
                }
                if (pressCount == 5)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "X";
                }

                if (pressCount == 6)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "Y";
                }

                if (pressCount == 7)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "Z";
                    pressCount = 0;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                timerPress.Stop();
                timerPress.Start();

                pressCount = pressCount + 1;

                if (pressCount == 1)
                {

                    txtDisplay.Text = (txtDisplay.Text + ("."));

                }

                if (pressCount == 2)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + ",";
                }

                if (pressCount == 3)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = (txtDisplay.Text + '\u0022');

                }
                if (pressCount == 4)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    txtDisplay.Text = txtDisplay.Text + "7";
                }
            }
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            timerPress.Stop();
            timerPress.Start();

            pressCount = pressCount + 1;

            if (pressCount == 1)
            {

                txtDisplay.Text = (txtDisplay.Text + ("*"));

            }

            if (pressCount == 2)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "-";
            }

            if (pressCount == 3)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = (txtDisplay.Text + '_');

            }
        }

        private void btnChar2_Click(object sender, EventArgs e)
        {
            timerPress.Stop();
            timerPress.Start();

            pressCount = pressCount + 1;

            if (pressCount == 1)
            {

                txtDisplay.Text = (txtDisplay.Text + ("#"));

            }

            if (pressCount == 2)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text + "-";
            }

            if (pressCount == 3)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                txtDisplay.Text = (txtDisplay.Text + '_');

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtPrint.Text = txtPrint.Text + txtDisplay.Text + " ";
            txtDisplay.Text = "";
            Str_KeyStrokes = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            txtPrint.AppendText(Environment.NewLine);
        }

       

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
delay =  (My_Dialogs.InputBox("Please enter the 'Delay Value' you require, 1000 is equal to a 1 second delay. At present the Delay Value is " + delay + "."));
           num = Convert.ToInt16(delay);
           
            if (num < 500)
            {
                num = 500;
                delay = "500";
            }
            timerPress.Interval = num;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            FilePath = openFileDialog1.FileName;
            if (FilePath != "")
            {
                StreamReader reader = File.OpenText(FilePath);
                for (string str = reader.ReadLine(); str != "\0"; str = reader.ReadLine())
                {
                    txtPrint.AppendText(str);
                }
                reader.Close();
            }
        }

        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            txtPrint.Text = "";
            Str_KeyStrokes = "";

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }

}

