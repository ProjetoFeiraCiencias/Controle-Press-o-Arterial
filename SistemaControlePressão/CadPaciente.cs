using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaControlePressão
{
    public partial class CadPaciente : Form
    {
        public CadPaciente()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection("Data Source=WELLITON\\SQLEXPRESS;Initial Catalog=pressao;Integrated Security=True");
        SqlCommand comando;

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox7.Text = "sim";
            }
            else
            {
                checkBox7.Text = "nao";
            }
            ////////////////////////////

            if (checkBox6.Checked)
            {
                checkBox6.Text = "sim";
            }
            else
            {
                checkBox6.Text = "nao";
            }
            ////////////////////////////
            if (checkBox5.Checked)
            {
                checkBox5.Text = "sim";
            }
            else
            {
                checkBox5.Text = "nao";
            }
            ////////////////////////////

            if (checkBox9.Checked)
            {
                checkBox9.Text = "sim";
            }
            else
            {
                checkBox9.Text = "nao";
            }
            ////////////////////////////

            if (checkBox12.Checked)
            {
                checkBox12.Text = "sim";
            }
            else
            {
                checkBox12.Text = "nao";
            }
            ////////////////////////////
            if (checkBox4.Checked)
            {
                checkBox4.Text = "sim";
            }
            else
            {
                checkBox4.Text = "nao";
            }
            ////////////////////////////
            if (checkBox1.Checked)
            {
                checkBox1.Text = "sim";
            }
            else
            {
                checkBox1.Text = "nao";
            }
            ////////////////////////////
            if (checkBox2.Checked)
            {
                checkBox2.Text = "sim";
            }
            else
            {
                checkBox2.Text = "nao";
            }
            ////////////////////////////
            if (checkBox3.Checked)
            {
                checkBox3.Text = "sim";
            }
            else
            {
                checkBox3.Text = "nao";
            }
            ////////////////////////////
            if (checkBox11.Checked)
            {
                checkBox11.Text = "sim";
            }
            else
            {
                checkBox11.Text = "nao";
            }
            ////////////////////////////
            if (checkBox10.Checked)
            {
                checkBox10.Text = "sim";
            }
            else
            {
                checkBox10.Text = "nao";
            }
            ////////////////////////////
            if (checkBox8.Checked)
            {
                checkBox8.Text = "sim";
            }
            else
            {
                checkBox8.Text = "nao";
            }
            ////////////////////////////

            conexao.Open();
            comando = new SqlCommand("insert into cliente values ('"+maskedTextBox4.Text+"' , '"+textBox1.Text+"' , '"+maskedTextBox1.Text+"' , '"+maskedTextBox3.Text+"' , '"+maskedTextBox5.Text+"' , '"+maskedTextBox2.Text+"' , '"+comboBox1.Text+"' , '"+comboBox2.Text+"' , '"+textBox2.Text+"' , '"+textBox4.Text+"' , '"+textBox3.Text+"' , '"+comboBox3.Text+"' , '"+checkBox7.Text+"' , '"+checkBox6.Text+"' , '"+checkBox5.Text+"' , '"+checkBox9.Text+"' , '"+checkBox12.Text+"' , '"+checkBox4.Text+"' , '"+checkBox1.Text+"' , '"+checkBox2.Text+"' , '"+checkBox3.Text+"' , '"+checkBox11.Text+"' , '"+checkBox10.Text+"' , '"+checkBox8.Text+"') ",conexao);
            comando.ExecuteNonQuery();
            conexao.Close();

            checkBox7.Text = "Diabetes I";
            checkBox6.Text = "Diabetes II";
            checkBox5.Text = "Cardiopata";
            checkBox9.Text = "Hipertenso";
            checkBox12.Text = "hipotenso";
            checkBox4.Text = "Antece. Familiares Cardiovasculares";
            checkBox1.Text = "Sal";
            checkBox2.Text = "Gordura";
            checkBox3.Text = "Alimentos Industrializados";
            checkBox11.Text = "Obesidade";
            checkBox10.Text = "Sendentarismo";
            checkBox8.Text = "Tabagista";


            MessageBox.Show("Cadastrado com Sucesso");
        }
    }
}
