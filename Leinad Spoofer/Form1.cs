using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leinad_Spoofer
{
    public partial class Form1 : Form
    {
        public bool Drag;
        public int Down;
        public int Up;

        public string window;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public static void clearFolder(string FolderName)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(FolderName);

            foreach (System.IO.FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (System.IO.DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }

        public static void clearFile(string FileName)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(FileName);
            fi.Delete();
        }

        public static int GetProcID(string procname)
        {
            var procId = 0;

            var processes = System.Diagnostics.Process.GetProcessesByName(procname);

            foreach (var process in processes)
            {
                procId = process.Id;
            }

            return procId;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja fechar?", "Leinad Spoofer - Fechar aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            window = "Global";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Drag = true;
                Down = e.X;
                Up = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Drag = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - Down, currentScreenPos.Y - Up);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            window = "HWID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            window = "Cidade";
        }

        private void closedButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja fechar?", "Leinad Spoofer - Fechar aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void minimizedButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelController.Controls.Clear();
            panelController.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void otmizeButtonMenu_Click(object sender, EventArgs e)
        {
            UserController.UC_Otimization uc = new UserController.UC_Otimization();
            addUserControl(uc);
            otmizeButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            globalButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
        }

        private void globalButtonMenu_Click(object sender, EventArgs e)
        {
            UserController.UC_Global uc = new UserController.UC_Global();
            addUserControl(uc);
            otmizeButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            globalButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
        }
    }
}
