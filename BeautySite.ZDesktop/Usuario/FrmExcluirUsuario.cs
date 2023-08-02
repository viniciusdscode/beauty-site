using BeautySite.BLL;
using BeautySite.DTO;
using BeautySite.ZDesktop.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySite.ZDesktop.Usuario
{
    public partial class FrmExcluirUsuario : Form
    {
        UsuarioBLL objBLL = new UsuarioBLL();
        UsuarioDTO objModelo = new UsuarioDTO();

        public FrmExcluirUsuario()
        {
            InitializeComponent();
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
            cpInativo();
            txtSearch.Focus();

            
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show($"Deseja excluir {objModelo.Nome}?", "Atenção", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes) 
            {
                objModelo.IdUsuario = int.Parse(txtId.Text);
                objBLL.DeleteUser(objModelo.IdUsuario);
                cbo1.Text = string.Empty;
                txtTel.Text = string.Empty;
                Limpar.ClearControl(this);
                MessageBox.Show($"Usuario {objModelo.Nome} obliterado com sucesso!!");
                txtSearch.Focus();
                cpInativo();
            }
            else if(confirmar == DialogResult.No)
            {
                FrmExcluirUsuario obj = new FrmExcluirUsuario();
                obj.ShowDialog();
            }
        }

        private void FrmExcluirUsuario_Load(object sender, EventArgs e)
        {
            cpInativo();
        }
    }
}
