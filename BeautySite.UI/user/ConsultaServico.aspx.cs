using BeautySite.BLL;
using BeautySite.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeautySite.UI.user
{
    public partial class ConsultaServico : System.Web.UI.Page
    {
        ServicoBLL objBLLServico = new ServicoBLL();


        public void PopularGVServico()
        {
            gv1.DataSource = objBLLServico.ListarServico();
            gv1.DataBind();
        }
        public void FiltrarGVServico()
        {
            string objFilter = txtFiltro.Text;
            gv1.DataSource = objBLLServico.FiltrarServicoBLL(objFilter);
            gv1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopularGVServico();
            }
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

    }
}