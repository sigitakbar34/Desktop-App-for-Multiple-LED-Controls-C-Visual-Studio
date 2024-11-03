using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Reflection.Emit;
using Kontrol_LED_Sigit_Akbar_Saputra.Kontrol;

namespace Kontrol_LED_Sigit_Akbar_Saputra
{
    public partial class LEDControl : Form
    {
        private ToolTip tooltip = new ToolTip();

        public LEDControl()
        {
            InitializeComponent();

            //set appereance peringatan kalau tidak bisa klik toggle button kalau port belum open
            tooltip.IsBalloon = false;
            tooltip.BackColor = Color.LightYellow;
            tooltip.ForeColor = Color.Black; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Disconnect.Enabled = false;

            //PictureBox icon led
            PB3.Image = Properties.Resources.ledoff;
            PB2.Image = Properties.Resources.ledoff;
            PB1.Image = Properties.Resources.ledoff;
            PB4.Image = Properties.Resources.ledoff;
            PB5.Image = Properties.Resources.ledoff;

            var ports = SerialPort.GetPortNames();
            comboBox1.DataSource = ports;
        }

        //Button connect ditekan
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
                tooltip.Show("Connected", btn_Connect, btn_Connect.Width / 2, btn_Connect.Height, 2000);
                btn_Disconnect.Enabled = true;
                btn_Connect.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Select a COM Port");
            }
        }

        //Button disconnect ditekan
        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Kirim perintah untuk mematikan semua LED ketika disconnected
                serialPort1.Write("f");

                serialPort1.Close();
                btn_Disconnect.Enabled = false;
                btn_Connect.Enabled = true;

                tooltip.Show("Disconnected", btn_Disconnect, btn_Disconnect.Width / 2, btn_Disconnect.Height, 2000);

                //MessageBox.Show("COM Port Closed");

                // Reset status toggle button ke unchecked
                TB1.Checked = false;
                TB2.Checked = false;
                TB3.Checked = false;
                TB4.Checked = false;
                TB5.Checked = false;

                //PictureBox icon led
                PB3.Image = Properties.Resources.ledoff;
                PB2.Image = Properties.Resources.ledoff;
                PB1.Image = Properties.Resources.ledoff;
                PB4.Image = Properties.Resources.ledoff;
                PB5.Image = Properties.Resources.ledoff;
            }
            catch (Exception)
            {

            }
        }

        private void ToggleButton_CheckedChanged(CheckBox toggleButton, string onCommand, string offCommand, PictureBox pictureBox)
        {
            //port com tidak terbuka dan toggle berusaha diklik
            if (!serialPort1.IsOpen && toggleButton.Checked) 
            {
                // Tampilkan peringatan jika port belum terbuka
                tooltip.Show("Connect to COM Port First", toggleButton, toggleButton.Width / 2, toggleButton.Height, 2000);
                toggleButton.Checked = false; 
            }
            else
            {
                try
                {
                    serialPort1.Write(toggleButton.Checked ? onCommand : offCommand);
                    pictureBox.Image = toggleButton.Checked ? Properties.Resources.ledon : Properties.Resources.ledoff; 
                }
                catch (Exception)
                {
                }
            }
        }

        //Kirim huruf kapital untuk mengaktifkan led dan huruf kecil untuk menonaktifkan led
        private void TB1_CheckedChanged_1(object sender, EventArgs e)
        {
            ToggleButton_CheckedChanged(TB1, "A", "a", PB1);
        }

        private void TB2_CheckedChanged_1(object sender, EventArgs e)
        {
            ToggleButton_CheckedChanged(TB2, "B", "b", PB2);
        }

        private void TB3_CheckedChanged_1(object sender, EventArgs e)
        {
            ToggleButton_CheckedChanged(TB3, "C", "c", PB3);
        }

        private void TB4_CheckedChanged_1(object sender, EventArgs e)
        {
            ToggleButton_CheckedChanged(TB4, "D", "d", PB4);
        }
        private void TB5_CheckedChanged(object sender, EventArgs e)
        {
            ToggleButton_CheckedChanged(TB5, "E", "e", PB5);
        }
    }
}