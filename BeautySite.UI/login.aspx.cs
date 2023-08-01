using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeautySite.DTO;
using BeautySite.BLL;

namespace BeautySite.UI
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Enabled = false;
            txtNome.Focus();
            lblMessage.Font.Size = 12;
        }

        protected void btnEntrar_Click1(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO usuario = new UsuarioDTO();
                UsuarioBLL objBLL = new UsuarioBLL();

                string objNome = txtNome.Text;
                string objSenha = txtSenha.Text;

                usuario = objBLL.AutenticarUsuario(objNome, objSenha);

                if (usuario != null)
                {
                    switch (usuario.TipoUsuario_IdTipoUsuario)
                    {
                        case "1":
                            Session["Usuario"] = txtNome.Text.Trim();
                            Response.Redirect("adm/Direcao.aspx");
                            break;
                        case "2":
                            Session["Usuario"] = txtNome.Text.Trim();
                            Response.Redirect("user/ConsultaServico.aspx");
                            break;
                    }
                }
                else
                {
                    lblMessage.Text = "Usuário não Cadastrado!";
                }
            }
            catch (Exception ex) 
            {
                 lblMessage.Text = "Usuário não Cadastrado!" + ex;
            }
        }

    }
}