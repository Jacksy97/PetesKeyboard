namespace Keyboard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnMode = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.timerPress = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrint
            // 
            this.txtPrint.Location = new System.Drawing.Point(13, 33);
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(679, 250);
            this.txtPrint.TabIndex = 0;
            this.txtPrint.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 5, 2);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.toolStrip1.Size = new System.Drawing.Size(704, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel1.Text = "File";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(75, 22);
            this.toolStripLabel2.Text = "Configurator";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 311);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(338, 40);
            this.textBox2.TabIndex = 2;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(193, 321);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(237, 20);
            this.txtDisplay.TabIndex = 3;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(436, 321);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(75, 20);
            this.txtStatus.TabIndex = 4;
            this.txtStatus.Text = "Multi Press";
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(183, 358);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(338, 322);
            this.textBox5.TabIndex = 5;
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMode.Location = new System.Drawing.Point(193, 367);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(75, 57);
            this.btnMode.TabIndex = 6;
            this.btnMode.Text = "Mode";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(274, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(355, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 57);
            this.button3.TabIndex = 8;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(436, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 57);
            this.button4.TabIndex = 9;
            this.button4.Text = "Send Predicted";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Location = new System.Drawing.Point(193, 430);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 57);
            this.button5.TabIndex = 10;
            this.button5.Text = "7\r\n. , \"\r\n";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.LightCoral;
            this.btn8.Location = new System.Drawing.Point(274, 430);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 57);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8\r\nA B C\r\n";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightCoral;
            this.button7.Location = new System.Drawing.Point(355, 430);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 57);
            this.button7.TabIndex = 12;
            this.button7.Text = "9\r\nD E F";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Yellow;
            this.button8.Location = new System.Drawing.Point(436, 430);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 57);
            this.button8.TabIndex = 13;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightCoral;
            this.button9.Location = new System.Drawing.Point(193, 493);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 57);
            this.button9.TabIndex = 14;
            this.button9.Text = "4\r\nG H I";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightCoral;
            this.button10.Location = new System.Drawing.Point(274, 493);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 57);
            this.button10.TabIndex = 15;
            this.button10.Text = "5\r\nJ K L";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightCoral;
            this.button11.Location = new System.Drawing.Point(355, 493);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 57);
            this.button11.TabIndex = 16;
            this.button11.Text = "6\r\nM N O";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Yellow;
            this.button12.Location = new System.Drawing.Point(436, 556);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 120);
            this.button12.TabIndex = 17;
            this.button12.Text = "Enter";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LightCoral;
            this.button13.Location = new System.Drawing.Point(193, 556);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 57);
            this.button13.TabIndex = 18;
            this.button13.Text = "1\r\nP Q R S\r\n";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LightCoral;
            this.button14.Location = new System.Drawing.Point(274, 556);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 57);
            this.button14.TabIndex = 19;
            this.button14.Text = "2\r\nT U V W";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.LightCoral;
            this.button15.Location = new System.Drawing.Point(355, 556);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 57);
            this.button15.TabIndex = 20;
            this.button15.Text = "3\r\nX Y Z\r\n";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LightCoral;
            this.button16.Location = new System.Drawing.Point(193, 616);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 57);
            this.button16.TabIndex = 21;
            this.button16.Text = "* - _";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.PaleGreen;
            this.button17.Location = new System.Drawing.Point(274, 616);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 57);
            this.button17.TabIndex = 22;
            this.button17.Text = "0\r\n[ _ ]";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.LightCoral;
            this.button18.Location = new System.Drawing.Point(355, 616);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 57);
            this.button18.TabIndex = 23;
            this.button18.Text = "#\r\n0 00";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Yellow;
            this.button19.Location = new System.Drawing.Point(436, 493);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 57);
            this.button19.TabIndex = 24;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // timerPress
            // 
            this.timerPress.Interval = 500;
            this.timerPress.Tick += new System.EventHandler(this.timerPress_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 695);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mini Keyboard V1.0";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Timer timerPress;
    }
}

