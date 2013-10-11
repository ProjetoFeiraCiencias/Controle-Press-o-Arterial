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
    public partial class relatorios : Form
    {
        public relatorios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void relatorios_Load(object sender, EventArgs e)
        {
            string valores;
            
            valores = "select * from cadastro";

            SqlConnection conexao = new SqlConnection("Data Source=WELLITON\\SQLEXPRESS;Initial Catalog=pressao;Integrated Security=True");
            conexao.Open();
            SqlCommand comando = new SqlCommand(valores,conexao);
            
            SqlDataAdapter adapta = new SqlDataAdapter(comando);//ponte com o banco e o dataset ou tabela
            DataTable tabela = new DataTable();

            adapta.Fill(tabela);
            dataGridView1.DataSource = tabela;
        }
    }
}
