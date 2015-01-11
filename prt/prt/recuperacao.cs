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

using System.Net;
using System.Web;
using System.Net.Mail;
using System.Net.Mime;

namespace prt
{
    public partial class recuperacao : Form
    {
        string email;
        public recuperacao()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string conexao = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection recup = new MySqlConnection(conexao);
                MySqlCommand user = new MySqlCommand("select email from bdprt.usuarios where email='" + textBox1.Text + "';",recup);
                MySqlDataReader ler;
                recup.Open();
                ler = user.ExecuteReader();
                int cont = 0;
                while (ler.Read())
                {
                    cont = cont + 1;
                }
                if (cont == 1)
                {
                    email = textBox1.Text;
                    var rp = new Pass();
                    rp.Show();
                }
                else
                {
                    MessageBox.Show("Email introduzido nao coincide com o da sua conta");
                }
                recup.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro\n\n"+ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void recuperacao_Load(object sender, EventArgs e)
        {

        }
    }
}
