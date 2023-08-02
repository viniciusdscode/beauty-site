﻿using BeautySite.BLL;
using BeautySite.DTO;
using BeautySite.ZDesktop.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySite.ZDesktop.Usuario
{
    public partial class FrmEditarUsuario : Form
    {
        UsuarioDTO objModelo = new UsuarioDTO();
        UsuarioBLL objBLL = new UsuarioBLL();
        public FrmEditarUsuario()
        {
            InitializeComponent();
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            cpInativo();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            txtTel.Text = string.Empty;
            cbo1.Text = string.Empty;
            txtSearch.Focus();
        }

        public void cpAtivo()
        {
            txtId.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            txtTel.Enabled = true;
            cbo1.Enabled = true;
        }

        public void cpInativo()
        {
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
            txtTel.Enabled = false;
            cbo1.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string objSearch = txtSearch.Text;

            objModelo = objBLL.SearchByNameDesk(objSearch);
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtNome.Text = string.Empty;
                txtNome.BackColor = Color.Red;
                MessageBox.Show($"Usuario Não Cadastrado");
                txtNome.BackColor = DefaultBackColor;
                txtNome.Focus();
                return;
            }
            else if (objModelo != null)
            {
                txtId.Text = objModelo.IdUsuario.ToString();
                txtNome.Text = objModelo.Nome.ToString();
                txtSenha.Text = objModelo.Senha.ToString();
                txtEmail.Text = objModelo.Email.ToString();
                txtTel.Text = objModelo.Telefone.ToString();
                cbo1.SelectedText = objModelo.TipoUsuario_IdTipoUsuario.ToString();
            }
            cpAtivo();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objModelo = new UsuarioDTO();

            objModelo.IdUsuario = Convert.ToInt32(txtId.Text);
            objModelo.Nome = txtNome.Text.Trim();
            objModelo.Senha = txtSenha.Text.Trim();
            objModelo.Email = txtEmail.Text.Trim();
            objModelo.Telefone = txtTel.Text.Trim();
            if(cbo1.Text == "Adminastrador")
            {
                objModelo.TipoUsuario_IdTipoUsuario = "1";
            }
            else if (cbo1.Text == "Outros")
            {
                objModelo.TipoUsuario_IdTipoUsuario = "2";
            }

            objBLL.UpdateUser(objModelo);
            Limpar.ClearControl(this);
            txtTel.Text = string.Empty;
            cbo1.Text = string.Empty;
            txtSearch.Focus();
            MessageBox.Show($"Usuario {objModelo.Nome} com sucesso!!");

            cpInativo();

        }
    }
}
