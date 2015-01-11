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

namespace prt
{
    public partial class registo : Form
    {
        public registo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pas="";
            if (textBox3.Text == textBox4.Text)
            {
                pas = textBox3.Text;
            }
            else if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Palavras-passe não combinam");
                textBox3.Text = "";
                textBox4.Text = "";
            }
            if (textBox1.Text == "")
            {
                label5.Text = "Campos vazios";
                textBox1.BackColor = Color.Red;
            }
            if (textBox2.Text == "")
            {
                label5.Text = "Campos vazios";
                textBox2.BackColor = Color.Red;
            }
            if (textBox3.Text == "")
            {
                label5.Text = "Campos vazios";
                textBox3.BackColor = Color.Red;
            }
            if (textBox4.Text == "")
            {
                label5.Text = "Campos vazios";
                textBox4.BackColor = Color.Red;
            }
            else
            {
                try
                {
                    string registar = "datasource=localhost;port=3306;username=root;password=";
                    MySqlConnection reg = new MySqlConnection(registar);
                    MySqlCommand enter = new MySqlCommand("INSERT INTO bdprt.usuarios(usuario,Pass,email)Values('" + textBox1.Text + "',aes_encrypt('" + pas + "','"+pas+"'),'" + textBox2.Text + "')",reg);
                    reg.Open();
                    enter.ExecuteNonQuery();
                    reg.Close();
                    MessageBox.Show("registo efetuado com sucesso");
                }
                catch (Exception prb)
                {
                    MessageBox.Show("ocorreu um erro ","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
            label6.BackColor = Color.AliceBlue;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
            label6.BackColor = Color.White;
        }
    }
}
