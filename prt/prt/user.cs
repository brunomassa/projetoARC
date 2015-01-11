using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prt.Properties;

using System.Net;
using System.Web;
using System.Net.Mail;
using System.Net.Mime;

namespace prt
{
    public partial class user : Form
    {
        int mn = 0;
        int loc = 0;
        string entrega = "";
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            label11.Text ="Bem-vindo "+ Settings.Default["loguser"].ToString();
            ficheiroToolStripMenuItem.BackColor = Color.Orange;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("minimizar", label2);

            label2.BackColor = Color.AliceBlue;
            label2.ForeColor = Color.Blue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            

            label2.BackColor = Color.White;
            label2.ForeColor = Color.Black;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Fechar", label1);
            
            label1.BackColor = Color.AliceBlue;
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loc == 0)
            {
                entrega = "";
            }
            else if(loc==1)
            {
                entrega="Sim";
            }
            else if(loc==2)
            {
                entrega="Não";
            }
            try
            {
                SmtpClient cliente = new SmtpClient("smtp.gmail.com",587);
                cliente.EnableSsl = true;
                cliente.Timeout = 10000;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new NetworkCredential("fixe123fixe@gmail.com","familia1234");
                MailMessage msg = new MailMessage();
                msg.To.Add("fixe123fixe@gmail.com");
                msg.From = new MailAddress("fixe123fixe@gmail.com");
                msg.Subject = "Encomenda";
                msg.Body = ("Nº Artigo:\n" + textBox1.Text + "\n Nome Artigo:\n" + textBox2.Text + "\n Quantidade:\n" + textBox4.Text + "\n Preço Total:\n" + textBox5.Text+"\n Entrega local:\n"+entrega);
                cliente.Send(msg);
                MessageBox.Show("Encomenda efetuada com susseco");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            loc = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            loc = 2;
        }

        private void ficheiroToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
        }

        private void ficheiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ficheiroToolStripMenuItem.BackColor = Color.Orange;
        }

        private void novaEncomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("menu", label12);
            label12.BackColor = Color.AliceBlue;
            label12.ForeColor = Color.Blue;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            if(mn==0){
            label12.BackColor = Color.White;
            label12.ForeColor = Color.Black;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            mn = 1;
            label12.BackColor = Color.AliceBlue;
            label12.ForeColor = Color.Blue;
            Point posicao = new Point(label12.Width+10000, label12.Height+15);
            contextMenuStrip1.Show(posicao);
        }

        private void terminarSessaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inicio = new Form1();
            inicio.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para efetuar uma encomenda precisa de:\n -preencher os campos\n -clicar no butao encomendar","ajuda");
        }

        private void user_Click(object sender, EventArgs e)
        {
            mn = 0;
            label12.BackColor = Color.White;
            label12.ForeColor = Color.Black;
        }

        private void user_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Gestão encomendas-Serviços em execução";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
