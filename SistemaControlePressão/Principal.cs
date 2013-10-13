using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaControlePressão
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            pictureBox1.Visible = false;
            this.IsMdiContainer = true;
            AferirPressão NCadPressao = new AferirPressão();
            NCadPressao.MdiParent = this;
            NCadPressao.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            pictureBox1.Visible = false;
            this.IsMdiContainer = true;
            Pesquisar NRelatorio = new Pesquisar();
            NRelatorio.MdiParent = this;
            NRelatorio.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;

            horaedata.Text = "Data: " + data.ToShortDateString() + " Hora: " + data.ToLongTimeString();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
        }

        private void btPCadP_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            pictureBox1.Visible = false;
            this.IsMdiContainer = true;
            CadPaciente CadP = new CadPaciente();
            CadP.MdiParent = this;
            CadP.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            pictureBox1.Visible = false;
            this.IsMdiContainer = true;
            AferirPressão NCadPressao = new AferirPressão();
            NCadPressao.MdiParent = this;
            NCadPressao.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            pictureBox1.Visible = false;
            this.IsMdiContainer = true;
            Pesquisar NRelatorio = new Pesquisar();
            NRelatorio.MdiParent = this;
            NRelatorio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            pictureBox1.Visible = false;
            this.IsMdiContainer = true;
            CadPaciente CadP = new CadPaciente();
            CadP.MdiParent = this;
            CadP.Show();
         

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair ?", "****FINALIZANDO****", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }

        }

       

       
    }
}
