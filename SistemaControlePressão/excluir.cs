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
    public partial class excluir : Form
    {
        public excluir()
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                SqlConnection conexao = new SqlConnection("Data Source=WELLITON\\SQLEXPRESS;Initial Catalog=pressao;Integrated Security=True");
                SqlCommand comando;

                conexao.Open();
                comando = new SqlCommand("delete from cadastro where cpf = '"+ maskedTextBox1.Text+ "' ", conexao);
                comando.ExecuteNonQuery();
                batatinha();
                MessageBox.Show("Apagado com sucesso");
                conexao.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Campo vazio");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
