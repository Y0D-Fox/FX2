using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP_MAN
{
    public partial class BBS : Form
    {
        public BBS()
        {
            InitializeComponent();
        }

        private void BBS_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings1.Default.pc.Contains("Пока нет") && !Properties.Settings1.Default.flash.Contains("Пока нет") && !Properties.Settings1.Default.hard.Contains("Пока нет") && !Properties.Settings1.Default.modem.Contains("Пока нет"))
            {
                label1.Text = "Для работы вам нужен комп-\r\nпамять. винчестер и модем";
            }
            else
            {
                label1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.pc == "Пока нет" && Properties.Settings1.Default.flash == "Пока нет" && Properties.Settings1.Default.hard == "Пока нет" && Properties.Settings1.Default.modem == "Пока нет")
            {
                MessageBox.Show("У вас нет ни одного из этих предметов");
            }

            else
            {

                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Введите название bbs");
                }
                else
                {

                }
            }
        }
    }
}
