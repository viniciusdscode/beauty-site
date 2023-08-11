using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySite.BLL;

namespace BeautySite.ZDesktop
{
    public partial class FrmRelatorioServico : Form
    {
        public FrmRelatorioServico()
        {
            InitializeComponent();
            Inativo();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Ativo();
            PopularGV();
            CarregaImg();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Inativo();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            DGVPrinter printer = new DGVPrinter();

            printer.Title = lblTitulo.Text;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;
            printer.Footer = DateTime.Now.ToString();
            printer.PrintDataGridView(gv1);


        }

        public void PopularGV()
        {
            ServicoBLL objBLL = new ServicoBLL();

            gv1.DataSource = objBLL.ListarServico();
        }

        public void CarregaImg()
        {
            foreach (DataGridViewRow row in gv1.Rows)
            {
                DataGridViewImageColumn col = new DataGridViewImageColumn();
                col.Name = "Img";
                col.HeaderText = "Imagem";
                col.ImageLayout = DataGridViewImageCellLayout.Zoom;
                row.Cells["Img"].Value = Image.FromFile(row.Cells["UrlImgServico"].Value.ToString());
            }
        }

        public void Inativo()
        {
            gv1.Visible = false;
            button1.Enabled = false;
        }

        public void Ativo()
        {
            button1.Enabled = true;
            gv1.Visible = true;
        }

    }
}
