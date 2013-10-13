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
    public partial class AferirPressão : Form
    {
        public AferirPressão()
        {
            InitializeComponent();
        }

        private void AferirPressão_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadPaciente NCadPaciente = new CadPaciente();
            NCadPaciente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

           
        }
    }
}
