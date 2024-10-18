using System;

namespace Børne_Spil
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
            System.Windows.Forms.Label label8;
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RETRY_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Helping_Tool_mat = new System.Windows.Forms.DataGridView();
            this.Enable_Disable_HELP_TOOL = new System.Windows.Forms.Button();
            this.stxNumber = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.STEAKTEXT = new System.Windows.Forms.Label();
            this.LOCKEDBTN = new System.Windows.Forms.Button();
            this.LOCKED1 = new System.Windows.Forms.ToolTip(this.components);
            this.LABEL_COUNTDOWN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Helping_Tool_mat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label8.Location = new System.Drawing.Point(46, 9);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(430, 63);
            label8.TabIndex = 0;
            label8.Text = "Victory Achieved!";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Font = new System.Drawing.Font("MV Boli", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(479, 154);
            this.textBox2.MaxLength = 2;
            this.textBox2.MinimumSize = new System.Drawing.Size(4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 82);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MV Boli", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(387, 79);
            this.textBox1.MaxLength = 2;
            this.textBox1.MinimumSize = new System.Drawing.Size(4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 82);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("MV Boli", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(296, 154);
            this.textBox4.MaxLength = 2;
            this.textBox4.MinimumSize = new System.Drawing.Size(4, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(97, 82);
            this.textBox4.TabIndex = 3;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MV Boli", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(387, 225);
            this.textBox3.MaxLength = 2;
            this.textBox3.MinimumSize = new System.Drawing.Size(4, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 82);
            this.textBox3.TabIndex = 4;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(625, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check answers ✔️";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RETRY_BTN
            // 
            this.RETRY_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RETRY_BTN.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RETRY_BTN.Location = new System.Drawing.Point(625, 394);
            this.RETRY_BTN.Name = "RETRY_BTN";
            this.RETRY_BTN.Size = new System.Drawing.Size(216, 45);
            this.RETRY_BTN.TabIndex = 7;
            this.RETRY_BTN.Text = "Retry 🎲";
            this.RETRY_BTN.UseVisualStyleBackColor = false;
            this.RETRY_BTN.Click += new System.EventHandler(this.RETRY_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(232, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "-1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(393, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 52);
            this.label3.TabIndex = 10;
            this.label3.Text = "+10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(393, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 52);
            this.label4.TabIndex = 11;
            this.label4.Text = "-10";
            // 
            // Helping_Tool_mat
            // 
            this.Helping_Tool_mat.AllowUserToResizeColumns = false;
            this.Helping_Tool_mat.AllowUserToResizeRows = false;
            this.Helping_Tool_mat.BackgroundColor = System.Drawing.Color.Black;
            this.Helping_Tool_mat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Helping_Tool_mat.Enabled = false;
            this.Helping_Tool_mat.GridColor = System.Drawing.Color.Black;
            this.Helping_Tool_mat.Location = new System.Drawing.Point(-6, 469);
            this.Helping_Tool_mat.MultiSelect = false;
            this.Helping_Tool_mat.Name = "Helping_Tool_mat";
            this.Helping_Tool_mat.Size = new System.Drawing.Size(861, 340);
            this.Helping_Tool_mat.TabIndex = 12;
            // 
            // Enable_Disable_HELP_TOOL
            // 
            this.Enable_Disable_HELP_TOOL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Enable_Disable_HELP_TOOL.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enable_Disable_HELP_TOOL.ForeColor = System.Drawing.Color.Black;
            this.Enable_Disable_HELP_TOOL.Location = new System.Drawing.Point(20, 399);
            this.Enable_Disable_HELP_TOOL.Name = "Enable_Disable_HELP_TOOL";
            this.Enable_Disable_HELP_TOOL.Size = new System.Drawing.Size(198, 45);
            this.Enable_Disable_HELP_TOOL.TabIndex = 13;
            this.Enable_Disable_HELP_TOOL.Text = "Disable Tool 🛠️";
            this.Enable_Disable_HELP_TOOL.UseVisualStyleBackColor = false;
            this.Enable_Disable_HELP_TOOL.Click += new System.EventHandler(this.Enable_Disable_HELP_TOOL_Click);
            // 
            // stxNumber
            // 
            this.stxNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stxNumber.Enabled = false;
            this.stxNumber.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stxNumber.ForeColor = System.Drawing.Color.White;
            this.stxNumber.Location = new System.Drawing.Point(387, 154);
            this.stxNumber.MinimumSize = new System.Drawing.Size(4, 4);
            this.stxNumber.Multiline = true;
            this.stxNumber.Name = "stxNumber";
            this.stxNumber.Size = new System.Drawing.Size(97, 82);
            this.stxNumber.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 10;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer8
            // 
            this.timer8.Enabled = true;
            this.timer8.Interval = 1000;
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 46);
            this.label5.TabIndex = 16;
            this.label5.Text = "🔥STREAK:";
            // 
            // STEAKTEXT
            // 
            this.STEAKTEXT.AutoSize = true;
            this.STEAKTEXT.BackColor = System.Drawing.Color.Transparent;
            this.STEAKTEXT.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STEAKTEXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.STEAKTEXT.Location = new System.Drawing.Point(214, 21);
            this.STEAKTEXT.Name = "STEAKTEXT";
            this.STEAKTEXT.Size = new System.Drawing.Size(46, 46);
            this.STEAKTEXT.TabIndex = 17;
            this.STEAKTEXT.Text = "0";
            // 
            // LOCKEDBTN
            // 
            this.LOCKEDBTN.BackColor = System.Drawing.Color.Gray;
            this.LOCKEDBTN.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOCKEDBTN.ForeColor = System.Drawing.Color.Black;
            this.LOCKEDBTN.Location = new System.Drawing.Point(20, 353);
            this.LOCKEDBTN.Name = "LOCKEDBTN";
            this.LOCKEDBTN.Size = new System.Drawing.Size(198, 40);
            this.LOCKEDBTN.TabIndex = 18;
            this.LOCKEDBTN.Text = "LOCKED 🔒";
            this.LOCKED1.SetToolTip(this.LOCKEDBTN, "Achieve 2 streaks to unlock the next level!");
            this.LOCKEDBTN.UseVisualStyleBackColor = false;
            // 
            // LABEL_COUNTDOWN
            // 
            this.LABEL_COUNTDOWN.AutoSize = true;
            this.LABEL_COUNTDOWN.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_COUNTDOWN.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_COUNTDOWN.ForeColor = System.Drawing.Color.White;
            this.LABEL_COUNTDOWN.Location = new System.Drawing.Point(679, 79);
            this.LABEL_COUNTDOWN.Name = "LABEL_COUNTDOWN";
            this.LABEL_COUNTDOWN.Size = new System.Drawing.Size(273, 63);
            this.LABEL_COUNTDOWN.TabIndex = 20;
            this.LABEL_COUNTDOWN.Text = "00:00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(16, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "🔥Unlock with 2 Streaks!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(579, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "+1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(681, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 49);
            this.label7.TabIndex = 22;
            this.label7.Text = "LEVEL 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.BackgroundImage = global::Børne_Spil.Resources.BCK22;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(label8);
            this.panel1.Location = new System.Drawing.Point(208, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 330);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(28, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(484, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "ALALLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(284, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "RETRT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(476, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 57);
            this.button4.TabIndex = 24;
            this.button4.Text = "QUIT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(855, 811);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LABEL_COUNTDOWN);
            this.Controls.Add(this.LOCKEDBTN);
            this.Controls.Add(this.STEAKTEXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stxNumber);
            this.Controls.Add(this.Enable_Disable_HELP_TOOL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RETRY_BTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Helping_Tool_mat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Helping_Tool_mat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void stxNumber_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
      
        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RETRY_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Helping_Tool_mat;
        private System.Windows.Forms.Button Enable_Disable_HELP_TOOL;
        private System.Windows.Forms.TextBox stxNumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        public System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label STEAKTEXT;
        private System.Windows.Forms.Button LOCKEDBTN;
        private System.Windows.Forms.ToolTip LOCKED1;
        private System.Windows.Forms.Label LABEL_COUNTDOWN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
    }
}

