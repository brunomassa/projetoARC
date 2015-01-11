using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace prt
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text ="( "+ ((double)progressBar1.Value + "% "+")");
            progressBar1.Increment(1);
            if (progressBar1.Value == 60)
            {
                label1.Text = "A iniciar";
            }
            if (progressBar1.Value == 101)
            {
                timer1.Stop();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
