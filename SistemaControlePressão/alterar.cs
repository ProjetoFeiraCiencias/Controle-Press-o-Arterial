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
    public partial class alterar : Form
    {
        public alterar()
        {
            InitializeComponent();
        }

        public void batatinha()
        {
            SqlConnection conexao = new SqlConnection("Data Source=WELLITON\\SQLEXPRESS;Initial Catalog=pressao;Integrated Security=True");
            conexao.Open();
            SqlCommand comando = new SqlCommand("select * from cadastro", conexao);

            SqlDataAdapter adaptar = new SqlDataAdapter(comando); //ponte do banco e dataset ou datatable
            DataTable tabela = new DataTable();

            adaptar.Fill(tabela); // preenche a tabela
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection conexao = new SqlConnection("Data Source=WELLITON\\SQLEXPRESS;Initial Catalog=pressao;Integrated Security=True");
                SqlCommand comando;

                conexao.Open();
                comando = new SqlCommand("update cadastro set '" + textBox1.Text + "' where cpf = '" + textBox1.Text + "' ", conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Alterado com sucesso");
                conexao.Close();
                this.Dispose();
                batatinha();
            }
            else
            {
                MessageBox.Show("Campo vazio");
            }
        }
    }
}
