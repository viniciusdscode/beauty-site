using BeautySite.BLL;
using BeautySite.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeautySite.UI
{
    public partial class Cadastro : System.Web.UI.Page
    {
        UsuarioDTO objModelo = new UsuarioDTO();
        UsuarioBLL objBLL = new UsuarioBLL();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtIdUsuario.Enabled = false;
            }
        }

        //validation
        public bool ValidatePage()
        {
            bool validator;
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                lblNome.Text = "  Digite o nome!";
                txtNome.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblEmail.Text = "  Digite o email!";
                txtEmail.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                lblSenha.Text = "  Digite a senha!";
                txtSenha.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtTel.Text))
            {
                lblTel.Text = "  Digite o telefone!";
                txtTel.Focus();
                validator = false;
            }
            else
            {
                validator = true;
            }
            return validator;
        }

        protected void btnRecord_Click(object sender, EventArgs e)
        {
            if (ValidatePage())
            {


            objModelo = new UsuarioDTO();
            objModelo.Nome = txtNome.Text.Trim();
            objModelo.Email = txtEmail.Text.Trim();
            objModelo.Senha = txtSenha.Text.Trim();
            objModelo.Telefone = txtTel.Text.Trim();

            if (string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                objBLL.CadastrarClienteBLL(objModelo);;
                lblMessage.Text = $"Usuário {objModelo.Nome} cadastrado com sucesso !!";
                Limpar.ClearControl(this);

                Response.Redirect("Login.aspx");

            }
            else
            {
                //passando objeto preenchido no metodo editar
                objModelo.IdUsuario = int.Parse(txtIdUsuario.Text);
                objBLL.UpdateUser(objModelo);
                Limpar.ClearControl(this);
                lblMessage.Text = $"Usuário {objModelo.Nome} editado com sucesso !!";
                Response.Redirect("Login.aspx");

            }

            }

        }
    }
}