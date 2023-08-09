using BeautySite.BLL;
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
                txtSearch.Text = string.Empty;
                txtSearch.BackColor = Color.Red;
                MessageBox.Show($"Digite Sua Busca !!");
                txtSearch.BackColor = DefaultBackColor;
                txtSearch.Focus();
                cpInativo();
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
                cpAtivo();
            }
            else
            {
                MessageBox.Show("Usuario Não Cadastrado!!", "ATENÇÃO");
                Limpar.ClearControl(this);
                txtSearch.Focus();
                cpInativo();
            }

        }

        public void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidatePage())
            {
                objModelo = new UsuarioDTO();

                objModelo.IdUsuario = Convert.ToInt32(txtId.Text);
                objModelo.Nome = txtNome.Text.Trim();
                objModelo.Senha = txtSenha.Text.Trim();
                objModelo.Email = txtEmail.Text.Trim();
                objModelo.Telefone = txtTel.Text.Trim();
                if (cbo1.Text == "Administrador")
                {
                    objModelo.TipoUsuario_IdTipoUsuario = "1";
                }
                else if (cbo1.Text == "Outros")
                {
                    objModelo.TipoUsuario_IdTipoUsuario = "2";
                }
                else
                {
                    MessageBox.Show("Tipo de usuário inválido !!");
                    cbo1.SelectedText = string.Empty;
                    cbo1.Focus();
                    return;
                }

                objBLL.UpdateUser(objModelo);
                Limpar.ClearControl(this);
                txtTel.Text = string.Empty;
                cbo1.Text = string.Empty;
                txtSearch.Focus();
                MessageBox.Show($"Usuario {objModelo.Nome} Editado com sucesso!!");

                cpInativo();
            }

        }

        public bool ValidatePage()
        {
            bool validator;

            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.BackColor = Color.Red;
                MessageBox.Show("Digite a Busca !!", "Atenção", MessageBoxButtons.OK);
                txtSearch.BackColor = DefaultBackColor;
                txtSearch.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtNome.Text))
            {
                txtNome.BackColor = Color.Red;
                MessageBox.Show("Digite o Nome !!", "Atenção", MessageBoxButtons.OK);
                txtNome.BackColor = DefaultBackColor;
                txtNome.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.BackColor = Color.Red;
                MessageBox.Show("Digite a Senha !!", "Atenção", MessageBoxButtons.OK);
                txtSenha.BackColor = DefaultBackColor;
                txtSenha.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.BackColor = Color.Red;
                MessageBox.Show("Digite o Email !!", "Atenção", MessageBoxButtons.OK);
                txtEmail.BackColor = DefaultBackColor;
                txtEmail.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtTel.Text) || txtTel.Text.Length < 14)
            {
                txtTel.BackColor = Color.Red;
                MessageBox.Show("Digite o Telefone !!", "Atenção", MessageBoxButtons.OK);
                txtTel.BackColor = DefaultBackColor;
                txtTel.Focus();
                validator = false;
            }
            else
            {
                validator = true;
            }
            return validator;

        }


    }
}
