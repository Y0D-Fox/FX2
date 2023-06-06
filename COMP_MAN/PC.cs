using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP_MAN
{
    public partial class PC : Form
    {
        public PC()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.pc == "Пока нет")
            {
                if (Properties.Settings1.Default.monye >= 10)
                {
                    Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 10;
                    Properties.Settings1.Default.pc = "3860х-40";
                }
                else
                {
                    MessageBox.Show("Недостаточно денег или слабый пк");
                }

            }
            if (Properties.Settings1.Default.pc == "3860х-40")
            {
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 30;
                Properties.Settings1.Default.pc = "3860х-66";
            }
            else
            {
                MessageBox.Show("Недостаточно денег или слабый пк");
            }
            if (Properties.Settings1.Default.pc == "3860х-66")
            {
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 80;
                Properties.Settings1.Default.pc = "Pentium";
            }
            else
            {
                MessageBox.Show("Недостаточно денег или слабый пк");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PC_Load(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.pc == "Пока нет")
            {
                button1.Text = "Купить компьютер";

            }
            if (Properties.Settings1.Default.modem == "Пока нет")
            {
                button4.Text = "Купить модем";
            }
            if (Properties.Settings1.Default.hard == "Пока нет")
            {
                button3.Text = "Купить винчестер";
            }
            if (Properties.Settings1.Default.cd == "Пока нет")
            {
                button5.Text = "Купить cd";
            }
            if (Properties.Settings1.Default.soundblaster == "Пока нет")
            {
                button6.Text = "Купить soundblaster";
            }
            else
            {
                button6.Enabled = false;
            }
            if (Properties.Settings1.Default.flash == "Пока нет")
            {
                button2.Text = "Купить память";
            }

            if (Properties.Settings1.Default.pc == "3860х-40")
            {
                button1.Text = "улучшить пк";
            }

            if (Properties.Settings1.Default.pc == "3860х-66")
            {
                button1.Text = "улучшить пк";
            }
            if (Properties.Settings1.Default.pc == "Pentium")
            {
                button1.Text = "улучшить пк";
            }


            if (Properties.Settings1.Default.flash == "4MB" && Properties.Settings1.Default.pc == "3860х-66")
            {
                button2.Text = "улучшить память";
            }

            if (Properties.Settings1.Default.flash == "16MB" && Properties.Settings1.Default.pc == "Pentium")
            {
                button2.Text = "улучшить память";
            }

            if (Properties.Settings1.Default.pc == "3860х-66")
            {
                button3.Text = "улучшить хард";
            }

            if (Properties.Settings1.Default.hard == "210MB" && Properties.Settings1.Default.pc == "3860х-66")
            {
                button3.Text = "улучшить хард";
            }
            if (Properties.Settings1.Default.hard == "850MB" && Properties.Settings1.Default.pc == "Pentium")
            {
                button3.Text = "улучшить хард";
            }

            if (Properties.Settings1.Default.modem == "2400bit" && Properties.Settings1.Default.pc == "3860х-66")
            {

                button4.Text = "улучшить модем";
            }

            if (Properties.Settings1.Default.modem == "14400bit" && Properties.Settings1.Default.pc == "Pentium")
            {

                button4.Text = "улучшить модем";
            }

            if (Properties.Settings1.Default.cd == "4xSpeed" && Properties.Settings1.Default.pc == "3860х-66")
            {

                button5.Text = "улучшить cd";
            }

            if (Properties.Settings1.Default.cd == "8xSpeed" && Properties.Settings1.Default.pc == "Pentium")
            {

                button5.Text = "улучшить cd";
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.pc == "Пока нет")
            {
                label1.Visible = true;
                label1.Text = "Сейчас можно купить\r\n386DX-40 за 10$";

            }
            if (Properties.Settings1.Default.pc == "3860х-40")
            {
                label1.Visible = true;
                label1.Text = "Сейчас можно купить\r\n386DX-66 за 30$";
            }

            if (Properties.Settings1.Default.pc == "3860х-66")
            {
                label1.Visible = true;
                label1.Text = "Сейчас можно купить\r\nPentium за 80$";
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.flash == "Пока нет")
            {
                label1.Visible = true;
                label1.Text = "Сейчас можно купить 4Mb памяти за 5$";
            }
            if (Properties.Settings1.Default.flash == "4MB" && Properties.Settings1.Default.pc == "3860х-66")
            {
                label1.Visible = true;
                label1.Text = "Сейчас можно купить 16Mb памяти за 15$";
                Properties.Settings1.Default.flash = "16MB";
            }

            if (Properties.Settings1.Default.flash == "16MB" && Properties.Settings1.Default.pc == "Pentium")
            {
                label1.Visible = true;
                label1.Text = "Сейчас можно купить 32Mb памяти за 20$";

            }

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.hard == "Пока нет")
            {
                label1.Visible = true;
                label1.Text = "Сейчас можно купить винт на 21ОМЬ за 20$";
            }
            if (Properties.Settings1.Default.hard == "210MB" && Properties.Settings1.Default.pc == "3860х-66")
            {
                label1.Visible = true;
                label1.Text = "Сейчас можно купить винт на 850MB за 50$";
            }
            if (Properties.Settings1.Default.hard == "850MB" && Properties.Settings1.Default.pc == "Pentium")
            {
                label1.Visible = true;
                label1.Text = "Сейчас можно купить винт на 1.6GB за 50$";
            }


        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.modem == "Пока нет")
            {
                label1.Visible = true;
                label1.Text = "Можно купить модем на 2400bit за 10$";
            }
            if (Properties.Settings1.Default.modem == "2400bit" && Properties.Settings1.Default.pc == "3860х-66")
            {
                label1.Visible = true;
                label1.Text = "Можно купить модем на 14400bit за 25$";
            }


            if (Properties.Settings1.Default.modem == "14400bit" && Properties.Settings1.Default.pc == "Pentium")
            {
                label1.Visible = true;
                label1.Text = "Можно купить модем на 28800bit за 50$";
            }

        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.cd == "Пока нет")
            {
                label1.Visible = true;
                label1.Text = "Доступен СО-ВОМ\r\n4xSpeed за 30$";
            }
            if (Properties.Settings1.Default.cd == "4xSpeed" && Properties.Settings1.Default.pc == "3860х-66")
            {
                label1.Visible = true;
                label1.Text = "Доступен СО-ВОМ\r\n8xSpeed за 50$";
            }

            if (Properties.Settings1.Default.cd == "8xSpeed" && Properties.Settings1.Default.pc == "Pentium")
            {
                label1.Visible = true;
                label1.Text = "Доступен СО-ВОМ\r\n16xSpeed за 80$";
            }

        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.soundblaster == "Пока нет")
            {
                label1.Visible = true;
                label1.Text = "Вы можете купить\r\nSoundBlaster за 50$";
            }
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
