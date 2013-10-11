using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using atualiza;

namespace SistemaControlePressão
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void limpar_texto()
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox6.Text = "";
            maskedTextBox7.Text = "";
            maskedTextBox8.Text = "";
            maskedTextBox9.Text = "";
        }

        SqlConnection conexao = new SqlConnection("Data Source=WELLITON\\SQLEXPRESS;Initial Catalog=pressao;Integrated Security=True");
        SqlCommand comando;

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "" && maskedTextBox2.Text != "" && maskedTextBox3.Text != "" && maskedTextBox4.Text != "" && maskedTextBox5.Text != "" && maskedTextBox6.Text != "" && maskedTextBox7.Text != "" && maskedTextBox8.Text != "" && maskedTextBox9.Text != "")
            {
                try
                {
                    SqlConnection conexao = new SqlConnection("Data Source=WELLITON\\SQLEXPRESS;Initial Catalog=pressao;Integrated Security=True");
                    SqlCommand comando;

                    conexao.Open();
                    comando = new SqlCommand("insert into cadastro values ('" + maskedTextBox1.Text + "' , '" + maskedTextBox2.Text + "' , '" + maskedTextBox3.Text + "' , '" + maskedTextBox4.Text + "' , '" + maskedTextBox5.Text + "' , '" + maskedTextBox6.Text + "' , '" + maskedTextBox7.Text + "' , '" + maskedTextBox8.Text + "' , '" + maskedTextBox9.Text + "') ", conexao);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("cadastro com sucesso");
                    batatinha();
                    conexao.Close();
                    limpar_texto();
                }
                catch
                {
                    MessageBox.Show("ocorreu um erro");
                }
            }
            else
            {
                MessageBox.Show("Preencher todos os campos");
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void batatinha()
        {
            //string valores;

            //valores = "select * from cadastro"; // atribuo o camando em uma variavel

            SqlConnection conexao = new SqlConnection("Data Source=WELLITON\\SQLEXPRESS;Initial Catalog=pressao;Integrated Security=True");
            conexao.Open();
            SqlCommand comando = new SqlCommand("select * from cadastro", conexao);

            SqlDataAdapter adaptar = new SqlDataAdapter(comando); //ponte do banco e dataset ou datatable
            DataTable tabela = new DataTable();

            adaptar.Fill(tabela); // preenche a tabela

            dataGridView1.DataSource = tabela;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            batatinha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            relatorios relatorio = new relatorios();
            relatorio.Show();
        }

        private void button2_Click(object sender, EventArgs e) //alterar
        {
            if (maskedTextBox12.Text != "")
            {
                conexao.Open();
                SqlDataAdapter adaptador;
                adaptador = new SqlDataAdapter("select cpf from cadastro where cpf = '"+maskedTextBox12.Text+"' ", conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);

                maskedTextBox1.Text = Convert.ToString(tabela.Rows[0]["cpf"]);
                ////////////////////////
                adaptador = new SqlDataAdapter("select nome from cadastro where cpf = '" + maskedTextBox12.Text + "' ", conexao);
                adaptador.Fill(tabela);

                maskedTextBox2.Text = Convert.ToString(tabela.Rows[1]["nome"]);

                //////
                adaptador = new SqlDataAdapter("select num_cartao from cadastro where cpf = '" + maskedTextBox12.Text + "' ", conexao);
                adaptador.Fill(tabela);

                maskedTextBox3.Text = Convert.ToString(tabela.Rows[2]["num_cartao"]);

                //////
                adaptador = new SqlDataAdapter("select telefone from cadastro where cpf = '" + maskedTextBox12.Text + "' ", conexao);
                adaptador.Fill(tabela);

                maskedTextBox4.Text = Convert.ToString(tabela.Rows[3]["telefone"]);

                //////
                adaptador = new SqlDataAdapter("select data_nasc from cadastro where cpf = '" + maskedTextBox12.Text + "' ", conexao);
                adaptador.Fill(tabela);

                maskedTextBox5.Text = Convert.ToString(tabela.Rows[4]["data_nasc"]);

                //////
                adaptador = new SqlDataAdapter("select endereco from cadastro where cpf = '" + maskedTextBox12.Text + "' ", conexao);
                adaptador.Fill(tabela);

                maskedTextBox6.Text = Convert.ToString(tabela.Rows[5]["endereco"]);

                //////
                adaptador = new SqlDataAdapter("select numero from cadastro where cpf = '" + maskedTextBox12.Text + "' ", conexao);
                adaptador.Fill(tabela);

                maskedTextBox7.Text = Convert.ToString(tabela.Rows[6]["numero"]);

                //////
                adaptador = new SqlDataAdapter("select bairro from cadastro where cpf = '" + maskedTextBox12.Text + "' ", conexao);
                adaptador.Fill(tabela);

                maskedTextBox8.Text = Convert.ToString(tabela.Rows[7]["bairro"]);

                //////
                adaptador = new SqlDataAdapter("select posto from cadastro where cpf = '" + maskedTextBox12.Text + "' ", conexao);
                adaptador.Fill(tabela);

                maskedTextBox9.Text = Convert.ToString(tabela.Rows[8]["posto"]);
                conexao.Close();
            }
            else
            {
                MessageBox.Show("Campo vazio");
                conexao.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e) //excluir
        {
            if (maskedTextBox11.Text != "")
            {
                SqlConnection conexao = new SqlConnection("Data Source=WELLITON\\SQLEXPRESS;Initial Catalog=pressao;Integrated Security=True");
                SqlCommand comando;

                conexao.Open();
                comando = new SqlCommand("delete from cadastro where cpf = '" + maskedTextBox11.Text + "' ", conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Apagado com sucesso");
                conexao.Close();
                batatinha();
                maskedTextBox11.Text = "";
            }
            else
            {
                MessageBox.Show("Campo vazio");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            batatinha();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Data Source=WELLITON\\SQLEXPRESS;Initial Catalog=pressao;Integrated Security=True");

            conexao.Open();
            comando = new SqlCommand("update cadastro set cpf = '" + maskedTextBox1.Text + "' , nome = '" + maskedTextBox2.Text + "', num_cartao = '" + maskedTextBox3.Text + "' , telefone = '" + maskedTextBox4.Text + "', data_nasc = '" + maskedTextBox5.Text + "', endereco = '" + maskedTextBox6.Text + "', numero = '" + maskedTextBox7.Text + "', bairro = '" + maskedTextBox8.Text + "', posto = '" + maskedTextBox9.Text + "' where cpf = '"+ maskedTextBox12.Text +"' ", conexao);
            comando.ExecuteNonQuery();

            MessageBox.Show("Alterado com sucesso");

            conexao.Close();
            batatinha();
        }
    }
}
