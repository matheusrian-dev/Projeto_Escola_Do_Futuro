﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    public partial class FormEditarProfessor : Form
    {
        ClassFuncionario funcionario = new ClassFuncionario();
        public FormEditarProfessor()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBuscarProfessor_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = funcionario.MostrarProfs();
        }

        private void btnEditarProfessor_Click(object sender, EventArgs e)
        {
            funcionario.Cpf = mskCpf.Text;
            funcionario.Nome = txtNome.Text;
            funcionario.Telefone = mskTelefone.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.Sexo = cboSexo.Text;
            funcionario.Cargo = cboCargo.Text;
            funcionario.EditarFuncionario();
        }

        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            funcionario.Cpf = mskCpf.Text;
            funcionario.Nome = txtNome.Text;
            funcionario.Telefone = mskTelefone.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.Sexo = cboSexo.Text;
            funcionario.Cargo = cboCargo.Text;
            DialogResult result = MessageBox.Show("Tem certeza que quer excluir esse cadastro?", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                funcionario.ExcluirFuncionario();
            }
            else
            {

            }
        }
    }
}
