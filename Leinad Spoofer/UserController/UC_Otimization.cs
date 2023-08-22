using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leinad_Spoofer.UserController
{
    public partial class UC_Otimization : UserControl
    {
        public UC_Otimization()
        {
            InitializeComponent();
        }

        private void clearCacheButton_Click(object sender, EventArgs e)
        {
            Form1.clearFolder("C:/Users/" + System.Environment.UserName + "/AppData/Local/FiveM/FiveM.app/data/cache");
            MessageBox.Show("Cache excluído com sucesso!");
        }

        private void deleteModsButton_Click(object sender, EventArgs e)
        {
            Form1.clearFolder("C:/Users/" + System.Environment.UserName + "/AppData/Local/FiveM/FiveM.app/data/game-storage");
            Form1.clearFolder("C:/Users/" + System.Environment.UserName + "/AppData/Local/FiveM/FiveM.app/data/server-cache");
            Form1.clearFolder("C:/Users/" + System.Environment.UserName + "/AppData/Local/FiveM/FiveM.app/data/server-cache-priv");
            Form1.clearFolder("C:/Users/" + System.Environment.UserName + "/AppData/Local/FiveM/FiveM.app/data/nui-storage");
            MessageBox.Show("Mods excluído com sucesso!");
        }

        private void deleteFilesButton_Click(object sender, EventArgs e)
        {
            Form1.clearFolder("C:/Windows/temp");
            Form1.clearFolder("C:/Windows/Prefetch");
            //clearFolder("C:/Users/" + System.Environment.UserName + "/AppData/Local/Temp");
            MessageBox.Show("Windows otimizado com sucesso!");
        }

        private void UC_Otimization_Load(object sender, EventArgs e)
        {

        }
    }
}
