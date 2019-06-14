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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtCep.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cmbEstado.Enabled = false;
            txtTel.Enabled = false;
            txtCurso.Enabled = false;
            cmbTurma.Enabled = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtCep.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cmbEstado.Enabled = true;
            txtTel.Enabled = true;
            txtCurso.Enabled = true;
            cmbTurma.Enabled = true;
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtCep.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cmbEstado.Enabled = false;
            txtTel.Enabled = false;
            txtCurso.Enabled = false;
            cmbTurma.Enabled = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadAluno a = new CadAluno();
            a.Nome = txtNome.Text;
            a.Endereco = txtEndereco.Text;
            a.Numero = txtNumero.Text;
            a.Cep = txtCep.Text;
            a.Bairro = txtBairro.Text;
            a.Cidade = txtCidade.Text;
            a.Estado = cmbEstado.Text;
            a.Tel = txtTel.Text;
            a.Curso = txtCurso.Text;
            a.Turma = cmbTurma.Text;

            MessageBox.Show("Aluno Registrado com Sucesso!");
            

            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtCep.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cmbEstado.Enabled = false;
            txtTel.Enabled = false;
            txtCurso.Enabled = false;
            cmbTurma.Enabled = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio frm = new Relatorio(txtNome.Text,txtEndereco.Text,txtNumero.Text,txtCep.Text,
                                          txtBairro.Text,txtCidade.Text,cmbEstado.Text,txtTel.Text,
                                          txtCurso.Text,cmbTurma.Text);
            frm.Show();

            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtCep.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cmbEstado.Text = "";
            txtTel.Text = "";
            txtCurso.Text = "";
            cmbTurma.Text = "";
        }
    }
}
            