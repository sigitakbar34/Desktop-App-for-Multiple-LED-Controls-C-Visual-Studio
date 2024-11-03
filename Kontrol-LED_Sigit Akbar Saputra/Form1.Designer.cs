namespace Kontrol_LED_Sigit_Akbar_Saputra
{
    partial class LEDControl
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.comPort = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.PB3 = new System.Windows.Forms.PictureBox();
            this.PB4 = new System.Windows.Forms.PictureBox();
            this.PB5 = new System.Windows.Forms.PictureBox();
            this.TB1 = new Kontrol_LED_Sigit_Akbar_Saputra.Kontrol.ToggleButton();
            this.TB2 = new Kontrol_LED_Sigit_Akbar_Saputra.Kontrol.ToggleButton();
            this.TB3 = new Kontrol_LED_Sigit_Akbar_Saputra.Kontrol.ToggleButton();
            this.TB4 = new Kontrol_LED_Sigit_Akbar_Saputra.Kontrol.ToggleButton();
            this.TB5 = new Kontrol_LED_Sigit_Akbar_Saputra.Kontrol.ToggleButton();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB5)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM9";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.HotPink;
            this.btn_Connect.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Connect.FlatAppearance.BorderSize = 0;
            this.btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connect.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Connect.Location = new System.Drawing.Point(91, 19);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(85, 31);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "CONNECT";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.BackColor = System.Drawing.Color.HotPink;
            this.btn_Disconnect.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Disconnect.FlatAppearance.BorderSize = 0;
            this.btn_Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Disconnect.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Disconnect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Disconnect.Location = new System.Drawing.Point(182, 19);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(85, 31);
            this.btn_Disconnect.TabIndex = 5;
            this.btn_Disconnect.Text = "DISCONNECT";
            this.btn_Disconnect.UseVisualStyleBackColor = false;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // comPort
            // 
            this.comPort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comPort.Controls.Add(this.comboBox1);
            this.comPort.Controls.Add(this.btn_Connect);
            this.comPort.Controls.Add(this.btn_Disconnect);
            this.comPort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPort.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comPort.Location = new System.Drawing.Point(209, 74);
            this.comPort.Name = "comPort";
            this.comPort.Padding = new System.Windows.Forms.Padding(5);
            this.comPort.Size = new System.Drawing.Size(275, 60);
            this.comPort.TabIndex = 15;
            this.comPort.TabStop = false;
            this.comPort.Text = "COM PORT";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(30, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(108, 29);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "LED 1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.Color.Transparent;
            this.PB1.Image = global::Kontrol_LED_Sigit_Akbar_Saputra.Properties.Resources.ledoff;
            this.PB1.Location = new System.Drawing.Point(51, 154);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(144, 63);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB1.TabIndex = 17;
            this.PB1.TabStop = false;
            // 
            // PB2
            // 
            this.PB2.BackColor = System.Drawing.Color.Transparent;
            this.PB2.Image = global::Kontrol_LED_Sigit_Akbar_Saputra.Properties.Resources.ledoff;
            this.PB2.Location = new System.Drawing.Point(181, 154);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(144, 64);
            this.PB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB2.TabIndex = 16;
            this.PB2.TabStop = false;
            // 
            // PB3
            // 
            this.PB3.BackColor = System.Drawing.Color.Transparent;
            this.PB3.Image = global::Kontrol_LED_Sigit_Akbar_Saputra.Properties.Resources.ledoff;
            this.PB3.Location = new System.Drawing.Point(311, 154);
            this.PB3.Name = "PB3";
            this.PB3.Size = new System.Drawing.Size(144, 63);
            this.PB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB3.TabIndex = 37;
            this.PB3.TabStop = false;
            // 
            // PB4
            // 
            this.PB4.BackColor = System.Drawing.Color.Transparent;
            this.PB4.Image = global::Kontrol_LED_Sigit_Akbar_Saputra.Properties.Resources.ledoff;
            this.PB4.Location = new System.Drawing.Point(441, 154);
            this.PB4.Name = "PB4";
            this.PB4.Size = new System.Drawing.Size(144, 64);
            this.PB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB4.TabIndex = 36;
            this.PB4.TabStop = false;
            // 
            // PB5
            // 
            this.PB5.BackColor = System.Drawing.Color.Transparent;
            this.PB5.Image = global::Kontrol_LED_Sigit_Akbar_Saputra.Properties.Resources.ledoff;
            this.PB5.Location = new System.Drawing.Point(571, 154);
            this.PB5.Name = "PB5";
            this.PB5.Size = new System.Drawing.Size(144, 64);
            this.PB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB5.TabIndex = 38;
            this.PB5.TabStop = false;
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(30, 171);
            this.TB1.MinimumSize = new System.Drawing.Size(45, 22);
            this.TB1.Name = "TB1";
            this.TB1.OffBackColor = System.Drawing.Color.DarkGray;
            this.TB1.OffTextColor = System.Drawing.Color.WhiteSmoke;
            this.TB1.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TB1.OnBackColor = System.Drawing.Color.HotPink;
            this.TB1.OnTextColor = System.Drawing.Color.White;
            this.TB1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TB1.Size = new System.Drawing.Size(64, 31);
            this.TB1.TabIndex = 47;
            this.TB1.UseVisualStyleBackColor = true;
            this.TB1.CheckedChanged += new System.EventHandler(this.TB1_CheckedChanged_1);
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(160, 171);
            this.TB2.MinimumSize = new System.Drawing.Size(45, 22);
            this.TB2.Name = "TB2";
            this.TB2.OffBackColor = System.Drawing.Color.DarkGray;
            this.TB2.OffTextColor = System.Drawing.Color.WhiteSmoke;
            this.TB2.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TB2.OnBackColor = System.Drawing.Color.HotPink;
            this.TB2.OnTextColor = System.Drawing.Color.White;
            this.TB2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TB2.Size = new System.Drawing.Size(64, 31);
            this.TB2.TabIndex = 46;
            this.TB2.UseVisualStyleBackColor = true;
            this.TB2.CheckedChanged += new System.EventHandler(this.TB2_CheckedChanged_1);
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(290, 171);
            this.TB3.MinimumSize = new System.Drawing.Size(45, 22);
            this.TB3.Name = "TB3";
            this.TB3.OffBackColor = System.Drawing.Color.DarkGray;
            this.TB3.OffTextColor = System.Drawing.Color.WhiteSmoke;
            this.TB3.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TB3.OnBackColor = System.Drawing.Color.HotPink;
            this.TB3.OnTextColor = System.Drawing.Color.White;
            this.TB3.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TB3.Size = new System.Drawing.Size(64, 31);
            this.TB3.TabIndex = 45;
            this.TB3.UseVisualStyleBackColor = true;
            this.TB3.CheckedChanged += new System.EventHandler(this.TB3_CheckedChanged_1);
            // 
            // TB4
            // 
            this.TB4.Location = new System.Drawing.Point(420, 171);
            this.TB4.MinimumSize = new System.Drawing.Size(45, 22);
            this.TB4.Name = "TB4";
            this.TB4.OffBackColor = System.Drawing.Color.DarkGray;
            this.TB4.OffTextColor = System.Drawing.Color.WhiteSmoke;
            this.TB4.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TB4.OnBackColor = System.Drawing.Color.HotPink;
            this.TB4.OnTextColor = System.Drawing.Color.White;
            this.TB4.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TB4.Size = new System.Drawing.Size(64, 31);
            this.TB4.TabIndex = 44;
            this.TB4.UseVisualStyleBackColor = true;
            this.TB4.CheckedChanged += new System.EventHandler(this.TB4_CheckedChanged_1);
            // 
            // TB5
            // 
            this.TB5.Location = new System.Drawing.Point(550, 171);
            this.TB5.MinimumSize = new System.Drawing.Size(45, 22);
            this.TB5.Name = "TB5";
            this.TB5.OffBackColor = System.Drawing.Color.DarkGray;
            this.TB5.OffTextColor = System.Drawing.Color.WhiteSmoke;
            this.TB5.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TB5.OnBackColor = System.Drawing.Color.HotPink;
            this.TB5.OnTextColor = System.Drawing.Color.White;
            this.TB5.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TB5.Size = new System.Drawing.Size(64, 31);
            this.TB5.TabIndex = 43;
            this.TB5.UseVisualStyleBackColor = true;
            this.TB5.CheckedChanged += new System.EventHandler(this.TB5_CheckedChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox6.Location = new System.Drawing.Point(160, 215);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(108, 29);
            this.textBox6.TabIndex = 52;
            this.textBox6.Text = "LED 2";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox7.Location = new System.Drawing.Point(420, 215);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(108, 29);
            this.textBox7.TabIndex = 53;
            this.textBox7.Text = "LED 4";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox8.Location = new System.Drawing.Point(290, 215);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(108, 29);
            this.textBox8.TabIndex = 54;
            this.textBox8.Text = "LED 3";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox9.Location = new System.Drawing.Point(550, 215);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(108, 29);
            this.textBox9.TabIndex = 55;
            this.textBox9.Text = "LED 5";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(4, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(695, 36);
            this.textBox2.TabIndex = 56;
            this.textBox2.Text = "LED CONTROL";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LEDControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB4);
            this.Controls.Add(this.TB5);
            this.Controls.Add(this.PB5);
            this.Controls.Add(this.PB3);
            this.Controls.Add(this.PB4);
            this.Controls.Add(this.comPort);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.PB2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LEDControl";
            this.Text = "LED Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.comPort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox comPort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.PictureBox PB3;
        private System.Windows.Forms.PictureBox PB4;
        private System.Windows.Forms.PictureBox PB5;
        private Kontrol.ToggleButton TB5;
        private Kontrol.ToggleButton TB4;
        private Kontrol.ToggleButton TB2;
        private Kontrol.ToggleButton TB3;
        private Kontrol.ToggleButton TB1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox2;
    }
}

