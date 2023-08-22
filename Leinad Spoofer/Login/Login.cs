using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Leinad_Spoofer.Login
{
    public partial class Login : Form
    {

        MySqlConnection Connect;

        public bool Drag;
        public int Down;
        public int Up;

        public string data_mysql = "datasource=spoofer.mysql.uhserver.com;username=leinad_spoofer;password=leinad1kk@;database=spoofer";

        public Login()
        {
            try
            {
                Connect = new MySqlConnection(data_mysql);
                InitializeComponent();
                Connect.Open();
                Connect.Close();
            }
            catch
            {
                MessageBox.Show("O servidor está temporariamente offline\nEntre em contato para mais informações\n\nErro: Servidor Offline", "Leinad Spoofer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                System.Environment.Exit(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lsTextBox1.Text1.Length < 2)
            {
                DialogResult dialogResult = MessageBox.Show("Key inválida, A key deve ter no minimo 32 caracteres!", "Leinad Spoofer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if(dialogResult == DialogResult.Cancel) Application.Exit();

            }
            else {
                Connect.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `keys` WHERE content='" + lsTextBox1.Text1 + "'", Connect);
                
                
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    this.Hide();
                    Form1 panel = new Form1();
                    panel.Show();
                }
                else
                {
                    Connect.Close();
                    DialogResult dialogResult = MessageBox.Show("Key inválida, A key deve ter no minimo 32 caracteres!", "Leinad Spoofer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (dialogResult == DialogResult.Cancel) Application.Exit();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Drag = true;
                Down = e.X;
                Up = e.Y;
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - Down, currentScreenPos.Y - Up);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Drag = false;
            }
        }

        private void inputKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void minimizedButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closedButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja fechar?", "Leinad Spoofer - Fechar aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://discord.gg/7Bnr6xhhVM");
        }
    }
}
