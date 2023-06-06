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
    public partial class PC_Program : Form
    {
        int i = 0;
        int max = 300;
        private Game _game;
        private void NewMethod()
        {
            label7.Text = "";
            label7.Visible = false;
        }
        public PC_Program(Game game)
        {
            InitializeComponent();
            _game = game;
        }

        private void button7_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Один из наиболее известных языков программирования,\n используется для обучения программированию";
        }

        private void button7_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Транслятор программы из текста на языке ассемблера,\n в программу на машинном языке";

        }

        private void button8_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Язык программирования, а также интегрированная среда \n разработки программного обеспечения,\n разрабатываемые корпорацией Microsoft.";
        }

        private void button9_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button10_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button10_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Интегрированная среда разработки ПО для Microsoft Windows,\n macOS, iOS и Android \nна языке Delphi (ранее носившем название Object Pascal)";
        }

        private void button3_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Общее название поколения операционных систем Windows\n от корпорации Microsoft, выпущенных с 1990 года(Windows 3.0)\n по 1994 год(Windows 3.2).";

        }

        private void button4_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button5_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button6_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button3_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button4_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Графическая многозадачная операционная система корпорации Microsoft. ";
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {

        }

        private void button5_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Последняя версия семейства сетевых\n операционных систем Microsoft Windows NT.";
        }

        private void button6_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Операционная система фирмы IBM,\n в определённый период времени разрабатывавшаяся с участием Microsoft.";

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value = i;
            i++;
            if (i > max)
            {
                timer1.Enabled = false;
                _game.label29.Text = Properties.Settings1.Default.system;
                label6.Text = "готово";

            }
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.flash == "32MB" && Properties.Settings1.Default.pc == "Pentium" && Properties.Settings1.Default.cd == "16xSpeed" && Properties.Settings1.Default.hard == "1.6GB")
            {
                Properties.Settings1.Default.system = "OS/2 5.0 Warp";

                label6.Text = "";
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Слабое железо");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.flash == "32MB" && Properties.Settings1.Default.pc == "Pentium" && Properties.Settings1.Default.cd == "16xSpeed" && Properties.Settings1.Default.hard == "1.6GB")
            {
                Properties.Settings1.Default.system = "Windows 95";
                _game.label29.Text = Properties.Settings1.Default.system;
                label6.Text = "";
                timer1.Start();
            }
            else { MessageBox.Show("Слабое железо"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.flash == "16MB" && Properties.Settings1.Default.pc == "3860x-66" && Properties.Settings1.Default.cd == "8xSpeed" && Properties.Settings1.Default.hard == "850MB")
            {
                Properties.Settings1.Default.system = "Windows 95";
                _game.label29.Text = Properties.Settings1.Default.system;
                label6.Text = "";
                timer1.Start();
            }
            else { MessageBox.Show("Слабое железо"); }
        }

        private void PC_Program_Load(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.flash == "пока нет" && Properties.Settings1.Default.pc == "пока нет" && Properties.Settings1.Default.cd == "пока нет" && Properties.Settings1.Default.hard == "пока нет")
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                label6.Text = "";
            }
            if (Properties.Settings1.Default.flash == "4MB" && Properties.Settings1.Default.pc == "3860x-40" && Properties.Settings1.Default.cd == "4xSpeed" && Properties.Settings1.Default.hard == "210MB")
            {
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                label6.Text = "";
            }
            if (Properties.Settings1.Default.flash == "16MB" && Properties.Settings1.Default.pc == "3860x-66" && Properties.Settings1.Default.cd == "8xSpeed" && Properties.Settings1.Default.hard == "850MB")
            {
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                label6.Text = "";
            }
            if (Properties.Settings1.Default.flash == "32MB" && Properties.Settings1.Default.pc == "Pentium" && Properties.Settings1.Default.cd == "16xSpeed" && Properties.Settings1.Default.hard == "1.6GB")
            {
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                label6.Text = "";
            }
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
            progressBar1.Maximum = max;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.flash == "4MB" && Properties.Settings1.Default.pc == "3860x-40" && Properties.Settings1.Default.cd == "4xSpeed" && Properties.Settings1.Default.hard == "210MB")
            {
                Properties.Settings1.Default.system = "Windows 3.1";
                _game.label29.Text = Properties.Settings1.Default.system;
                label6.Text = "";
                timer1.Start();
            }
            else { MessageBox.Show("Слабое железо"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
