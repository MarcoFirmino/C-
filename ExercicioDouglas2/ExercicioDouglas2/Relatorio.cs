using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioDouglas2
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }
       

        public Relatorio(string RNome, string REndereco, string RNumero, string RCep,
        string RBairro, string RCidade, string REstado, string RTel, string RCurso, string RTurma)
        {
            InitializeComponent();

            lblNome.Text = RNome;
            lblEndereco.Text = REndereco;
            lblNum.Text = RNumero;
            lblCep.Text = RCep;
            lblBairro.Text = RBairro;
            lblCidade.Text = RCidade;
            lblEstado.Text = REstado;
            lblTel.Text = RTel;
            lblCurso.Text = RCurso;
            lblTurma.Text = RTurma;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

        }
    }
}
