using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blood_bank
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int startpos;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos +=1;
            Myprogress.Value = startpos;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                login l = new login();
                l.Show();
                this.Hide();
            }


        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
