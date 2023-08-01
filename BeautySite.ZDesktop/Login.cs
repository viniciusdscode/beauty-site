using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySite.DTO;
using BeautySite.BLL;
using BeautySite.ZDesktop.Utilitarios;

namespace BeautySite.ZDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            txtNome.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //instanciando objetos
                UsuarioDTO usuario = new UsuarioDTO();
                UsuarioBLL objBLL = new UsuarioBLL();

                //pegando os dados do usuario
                string objNome = txtNome.Text;
                string objSenha = txtSenha.Text;

                usuario = objBLL.AutenticarUsuario(objNome, objSenha);

                if (usuario != null)
                {
                    Session.nomeUsuario = txtNome.Text.Trim();

                    FrmMain obj = new FrmMain();    
                    obj.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario não cadastrado !!!", "Atenção", MessageBoxButtons.OK);
                    Limpar.ClearControl(this);
                    txtNome.Focus();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Usuario não cadastrado !!!", "Atenção", MessageBoxButtons.OK);
                Limpar.ClearControl(this);
                txtNome.Focus();
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
