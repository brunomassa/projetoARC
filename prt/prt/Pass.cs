using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using MySql.Data.Common;
using MySql.Data.Types;

namespace prt
{
    public partial class Pass : Form
    {
        
        public Pass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Pass_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexao = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection ps = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand("select pass from bdprt.usuarios where utilizador='" + textBox1.Text + "';", ps);

            try
            {
                ps.Open();
                MySqlDataAdapter adapt = new MySqlDataAdapter();
                adapt.SelectCommand = cmd;
                DataTable dtt = new DataTable();
                adapt.Fill(dtt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dtt;
                dataGridView1.DataSource = bs;
                adapt.Update(dtt);
                ps.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocorreu um erro\n\n"+ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.AliceBlue;
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.AliceBlue;
            label2.ForeColor = Color.Blue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Black;
        }
    }
}
