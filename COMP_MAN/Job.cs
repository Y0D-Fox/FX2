using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
namespace COMP_MAN
{
    public partial class Job : Form
    {
        private Game _game;
        public Job(Game game)
        { 
            InitializeComponent();
            _game = game;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=Gg4RxjR_CiQ&ab") { UseShellExecute = true });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.job = "Дворник";
            Properties.Settings1.Default.salary = 10;
            _game.label22.Text= Properties.Settings1.Default.job + "/" + Convert.ToString(Properties.Settings1.Default.salary) + "в день";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.job = "Слесарь";
            Properties.Settings1.Default.salary = 20;
            _game.label22.Text = Properties.Settings1.Default.job + "/" + Convert.ToString(Properties.Settings1.Default.salary) + " в день";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Job_Load(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.day + 15 < Properties.Settings1.Default.day)
            {

                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

            }
        }
    }
}
