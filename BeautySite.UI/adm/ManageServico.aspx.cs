using BeautySite.DTO;
using BeautySite.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeautySite.UI.adm
{
    public partial class ManageServico : System.Web.UI.Page
    {
        ServicoDTO objModeloServico = new ServicoDTO();
        ServicoBLL objBLLServico = new ServicoBLL();

        public void CarregaDados()
        {
            int objSearch = int.Parse(txtIdServico.Text);

            objModeloServico = objBLLServico.SearchServicoBLL(objSearch);
            txtIdServico.Text = objModeloServico.IdServico.ToString();
            txtNomeServico.Text = objModeloServico.NomeServico.ToString();
            txtDescricaoServico.Text = objModeloServico.DescricaoServico.ToString();

        }

        public void PopularGVServico()
        {
            gv1.DataSource = objBLLServico.ListarServico();
            gv1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtIdServico.Enabled = false;
                PopularGVServico();

            }
        }

        public void FiltrarGVServico()
        {
            string objFilter = txtFiltro.Text;
            gv1.DataSource = objBLLServico.FiltrarServicoBLL(objFilter);
            gv1.DataBind();
        }

        public bool ValidatePage()
        {
            bool validator;
            if (string.IsNullOrEmpty(txtNomeServico.Text))
            {
                lblNomeServico.Text = "  Digite o serviço!";
                txtNomeServico.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtDescricaoServico.Text))
            {
                lblDescricaoServico.Text = "  Digite a descrição do serviço!";
                txtDescricaoServico.Focus();
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

                objModeloServico = new ServicoDTO();
                objModeloServico.NomeServico = txtNomeServico.Text.Trim();
                objModeloServico.DescricaoServico = txtDescricaoServico.Text.Trim();

                //cadastro imagem
                if (fUp1.HasFile)
                {
                    string str = fUp1.FileName;
                    fUp1.PostedFile.SaveAs(Server.MapPath("~/resource/img/" + str));
                    string CaminhoImg = "~/resource/img/" + str.ToString();
                    objModeloServico.UrlImgServico = CaminhoImg;
                }
                else
                {
                    lblFiltro.Text = "Deu Ruim!!";
                }

                if (string.IsNullOrEmpty(txtIdServico.Text))
                {
                    objBLLServico.CadastrarServicoBLL(objModeloServico);
                    PopularGVServico();
                    lblMessage.Text = $"Servico {objModeloServico.NomeServico} Cadastrado com sucesso";
                    Limpar.ClearControl(this);
                    Response.Redirect("ManageServico.aspx");
                }
                else
                {
                    objModeloServico.IdServico = int.Parse(txtIdServico.Text);
                    objBLLServico.UpdateServico(objModeloServico);
                    PopularGVServico();
                    Limpar.ClearControl(this);
                    Response.Redirect("ManageServico.aspx");
                    lblMessage.Text = $"Servico {objModeloServico.NomeServico} Editado com sucesso";

                }
            }

        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            PopularGVServico();
            Limpar.ClearControl(this);
            Response.Redirect("ManageServico.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            objModeloServico.IdServico = int.Parse(txtIdServico.Text);
            objBLLServico.DeleteServico(objModeloServico.IdServico);
            PopularGVServico();
            Limpar.ClearControl(this);
            Response.Redirect("ManageServico.aspx");

        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            string objFilter = txtFiltro.Text;
            var result = objBLLServico.FiltrarServicoBLL(objFilter);

            if (string.IsNullOrEmpty(txtFiltro.Text) || (result.Count == 0))
            {
                lblFiltro.ForeColor = System.Drawing.Color.Black;
                lblFiltro.Text = "Digite um serviço existente!!";
                PopularGVServico();
            }
            else
            {
                FiltrarGVServico();
            }
        }

        protected void gv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdServico.Text = gv1.SelectedRow.Cells[1].Text;
            CarregaDados();

        }
    }
}