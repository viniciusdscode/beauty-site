using BeautySite.BLL;
using BeautySite.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeautySite.UI.adm
{
    public partial class ManageUser : System.Web.UI.Page
    {
        UsuarioDTO objModelo = new UsuarioDTO();
        UsuarioBLL objBLL = new UsuarioBLL();

        public void PopularDDL1()
        {
            ddl1.DataSource = objBLL.CarregaDDList();
            ddl1.DataBind();
        }

        public void PopularGV()
        {
            gv1.DataSource = objBLL.ListarUsuario();
            gv1.DataBind();
        }

        public void CarregaDados()
        {
            int objSearch = int.Parse(txtIdUsuario.Text);

            objModelo = objBLL.SearchById(objSearch);
            txtIdUsuario.Text = objModelo.IdUsuario.ToString();
            txtNome.Text = objModelo.Nome.ToString();
            txtEmail.Text = objModelo.Email.ToString();
            txtSenha.Text = objModelo.Senha.ToString();
            txtTel.Text = objModelo.Telefone.ToString();
            ddl1.SelectedValue = objModelo.TipoUsuario_IdTipoUsuario.ToString();

        }

        public void Search()
        {
            string objSearch = txtSearch.Text;
            objModelo = objBLL.SearchByName(objSearch);
            txtIdUsuario.Text = objModelo.IdUsuario.ToString();
            txtNome.Text = objModelo.Nome.ToString();
            txtEmail.Text = objModelo.Email.ToString();
            txtSenha.Text = objModelo.Senha.ToString();
            txtTel.Text = objModelo.Telefone.ToString();
            ddl1.SelectedValue = objModelo.TipoUsuario_IdTipoUsuario.ToString();
            txtSearch.Text = string.Empty;
            txtNome.Focus();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtIdUsuario.Enabled = false;
                PopularDDL1();
                PopularGV();
            }
        }

        protected void gv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdUsuario.Text = gv1.SelectedRow.Cells[1].Text;
            PopularDDL1();
            CarregaDados();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                lblSearch.Text = "Digite a busca!!";
                txtSearch.Focus();
                return;
            }
            Search();
            lblSearch.Text = string.Empty;
        }

        //CRUD
        protected void btnRecord_Click(object sender, EventArgs e)
        {
            if (ValidatePage())
            {
                objModelo = new UsuarioDTO();
                objModelo.Nome = txtNome.Text.Trim();
                objModelo.Email = txtEmail.Text.Trim();
                objModelo.Senha = txtSenha.Text.Trim();
                objModelo.Telefone = txtTel.Text.Trim();
                objModelo.TipoUsuario_IdTipoUsuario = ddl1.SelectedValue;

                if (string.IsNullOrEmpty(txtIdUsuario.Text))
                {
                    objBLL.CadastrarUsuario(objModelo);
                    PopularGV();
                    lblMessage.Text = $"Usuário {objModelo.Nome} cadastrado com sucesso !!";
                    Limpar.ClearControl(this);

                    Response.Redirect("ManageUser.aspx");

                }
                else
                {
                    //passando objeto preenchido no metodo editar
                    objModelo.IdUsuario = int.Parse(txtIdUsuario.Text);
                    objBLL.UpdateUser(objModelo);
                    PopularGV();
                    Limpar.ClearControl(this);
                    lblMessage.Text = $"Usuário {objModelo.Nome} editado com sucesso !!";
                    Response.Redirect("ManageUser.aspx");

                }
            }
        }
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


        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            PopularGV();
            Limpar.ClearControl(this);
            Response.Redirect("ManageUser.aspx");

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            objModelo.IdUsuario = int.Parse(txtIdUsuario.Text);
            objBLL.DeleteUser(objModelo.IdUsuario);
            PopularGV();
            Limpar.ClearControl(this);
            Response.Redirect("ManageUser.aspx");

        }
    }
}