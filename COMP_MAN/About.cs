using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP_MAN
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            System.IO.Stream str = (Properties.Resources.INTRO);
            System.Media.SoundPlayer sndPlayer = new
            System.Media.SoundPlayer(str);
            sndPlayer.Play();
        }

        private void About_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=ZgIqtFLWf0g&ab") { UseShellExecute = true });
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
