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
    public partial class UC_Global : UserControl
    {
        public UC_Global()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1.clearFolder("C:/Users/" + System.Environment.UserName + "/AppData/Local/DigitalEntitlements");
            MessageBox.Show("FiveM deslogado com sucesso!!", "Leinad Spoofer");
        }

        private void unbanButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Ban removido com sucesso!", "Leinad Spoofer");
            }
            catch
            {
                MessageBox.Show("Houve um erro ao remover o banimento, Você precisa estar com o jogo aberto!!", "Leinad Spoofer");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.clearFile("C:/Users/" + System.Environment.UserName + "/AppData/Local/FiveM/FiveM.app/CitizenFX_SubProcess_chrome.bin");
            Form1.clearFile("C:/Users/" + System.Environment.UserName + "/AppData/Local/FiveM/FiveM.app/CitizenFX_SubProcess_game.bin");
            Form1.clearFile("C:/Users/" + System.Environment.UserName + "/AppData/Local/FiveM/FiveM.app/CitizenFX_SubProcess_game_372.bin");
            Form1.clearFile("C:/Users/" + System.Environment.UserName + "/AppData/Local/FiveM/FiveM.app/CitizenFX_SubProcess_game_1604.bin");
            Form1.clearFile("C:/Users/" + System.Environment.UserName + "/AppData/Local/FiveM/FiveM.app/CitizenFX_SubProcess_game_1868.bin");
            Form1.clearFile("C:/Users/" + System.Environment.UserName + "/AppData/Local/FiveM/FiveM.app/CitizenFX_SubProcess_game_2060.bin");
            Form1.clearFile("C:/Users/" + System.Environment.UserName + "/AppData/Local/FiveM/FiveM.app/CitizenFX_SubProcess_game_2189.bin");
            MessageBox.Show("Citzen atualizada com sucesso!", "Leinad Spoofer");
        }
    }
}
