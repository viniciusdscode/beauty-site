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
    public partial class FrmCadastrarUsuario : Form
    {

        UsuarioBLL objBLL = new UsuarioBLL();

        public FrmCadastrarUsuario()
        {
            InitializeComponent();
        }

        public void PopularCBO()
        {
            cbo1.DataSource = objBLL.CarregaDDList();
            cbo1.ValueMember = "IdTipoUsuario";
            cbo1.DisplayMember = "DescricaoTipoUsuario";
            cbo1.Refresh();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            txtTel.Text = string.Empty;
            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidatePage())
            {
                UsuarioDTO objCad = new UsuarioDTO();

                objCad.Nome = txtNome.Text;
                objCad.Senha = txtSenha.Text;
                objCad.Email = txtEmail.Text;
                objCad.Telefone = txtTel.Text;
                objCad.TipoUsuario_IdTipoUsuario = cbo1.SelectedValue.ToString();

                objBLL.CadastrarUsuario(objCad);

                MessageBox.Show($"Usuário {txtNome.Text} Cadastrado com sucesso!!");
                Limpar.ClearControl(this);
                cbo1.Text = string.Empty;
                txtTel.Text = string.Empty;
                txtNome.Focus();
            }
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            PopularCBO();
        }

        public bool ValidatePage()
        {
            bool validator;

            if (string.IsNullOrEmpty(txtNome.Text))
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
