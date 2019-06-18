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
            List <CadAluno> ListaAluno  = new List<CadAluno>();
           
            ListaAluno.Add(new CadAluno(txtNome.Text, txtEndereco.Text, txtNumero.Text, 
                                        txtCep.Text, txtBairro.Text, txtCidade.Text,
                                        cmbEstado.Text, txtTel.Text, txtCurso.Text, cmbTurma.Text));
            

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

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

            List<CadAluno> ListaAluno = new List<CadAluno>();

            dataGridView.DataSource = ListaAluno;

            dataGridView.Columns[0].Name = "Nome";
            dataGridView.Columns[1].Name = "Endereço";
            dataGridView.Columns[2].Name = "Numero";
            dataGridView.Columns[3].Name = "CEP";
            dataGridView.Columns[4].Name = "Bairro";
            dataGridView.Columns[5].Name = "Cidade";
            dataGridView.Columns[6].Name = "Estado";
            dataGridView.Columns[7].Name = "Tel";
            dataGridView.Columns[8].Name = "Curso";
            dataGridView.Columns[9].Name = "Turma";



             

            
        }
    }
}
            