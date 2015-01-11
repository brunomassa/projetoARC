using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using prt.Properties;
using MySql.Data.MySqlClient;
using System.Windows.Forms.VisualStyles;

namespace prt
{
    public partial class Form1 : Form
    {
        int ch = 0;
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(splashs));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void splashs()
        {
            Application.Run(new splash());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection log = new MySqlConnection(conexao);
                MySqlCommand ver = new MySqlCommand("select*from bdprt.usuarios where usuario='"+this.textBox1.Text+"' and Pass=aes_encrypt('"+this.textBox2.Text+"','"+this.textBox2.Text+"') ;",log);
                MySqlDataReader ler;
                log.Open();
                ler = ver.ExecuteReader();
                int i = 0;
                while (ler.Read())
                {
                    i = i + 1;
                }
                if (i == 1)
                {
                    Settings.Default["loguser"] = textBox1.Text;
                    Settings.Default.Save();
                    var pcp = new user();
                    pcp.Show();
                    this.Hide();
                }
                else if (i > 1)
                {
                    MessageBox.Show("Utilizador duplicado","iniciar sessão");
                }
                else
                {
                    MessageBox.Show("Nome de utilizador e Pass incorretos", "iniciar sessão");
                }
                log.Close();
            }
            catch (Exception prob)
            {
                MessageBox.Show("Ocorreu um erro \n\n"+prob.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (ch == 1)
            {
                Settings.Default["user"] = textBox1.Text;
                Settings.Default["pass"] = textBox2.Text;
                Settings.Default.Save();
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var reg = new registo();
            reg.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default["user"].ToString();
            textBox2.Text = Settings.Default["pass"].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Enter(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
            label3.BackColor = Color.AliceBlue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
            label3.BackColor = Color.White;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Blue;
            label4.BackColor = Color.AliceBlue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
            label4.BackColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                try
                {
                    string conexao = "datasource=localhost;port=3306;username=root;password=";
                    MySqlConnection log = new MySqlConnection(conexao);
                    MySqlCommand ver = new MySqlCommand("select*from bdprt.usuarios where usuario='" + this.textBox1.Text + "' and Pass=aes_encrypt('" + this.textBox2.Text +"','"+this.textBox2.Text+"') ;", log);
                    MySqlDataReader ler;
                    log.Open();
                    ler = ver.ExecuteReader();
                    int i = 0;
                    while (ler.Read())
                    {
                        i = i + 1;
                    }
                    if (i == 1)
                    {
                        var pcp = new user();
                        pcp.Show();
                        this.Hide();
                    }
                    else if (i > 1)
                    {
                        MessageBox.Show("Utilizador duplicado", "iniciar sessão");
                    }
                    else
                    {
                        MessageBox.Show("Nome de utilizador e Pass incorretos", "iniciar sessão");
                    }
                    log.Close();
                }
                catch (Exception prob)
                {
                    MessageBox.Show("Ocorreu um erro ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                try
                {
                    string conexao = "datasource=localhost;port=3306;username=root;password=";
                    MySqlConnection log = new MySqlConnection(conexao);
                    MySqlCommand ver = new MySqlCommand("select*from bdprt.usuarios where usuario='" + this.textBox1.Text + "' and Pass=aes_encrypt('" + this.textBox2.Text + "','"+this.textBox2.Text+"') ;", log);
                    MySqlDataReader ler;
                    log.Open();
                    ler = ver.ExecuteReader();
                    int i = 0;
                    while (ler.Read())
                    {
                        i = i + 1;
                    }
                    if (i == 1)
                    {
                        var pcp = new user();
                        pcp.Show();
                        this.Hide();
                    }
                    else if (i > 1)
                    {
                        MessageBox.Show("Utilizador duplicado", "iniciar sessão");
                    }
                    else
                    {
                        MessageBox.Show("Nome de utilizador e Pass incorretos", "iniciar sessão");
                    }
                    log.Close();
                }
                catch (Exception prob)
                {
                    MessageBox.Show("Ocorreu um erro ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ch = 1;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font.Name,label5.Font.SizeInPoints,FontStyle.Underline);
            Cursor.Current = Cursors.Hand;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font.Name, label5.Font.SizeInPoints, FontStyle.Regular);
            Cursor.Current = Cursors.Default;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var rec = new recuperacao();
            rec.Show();
        }
    }
}
