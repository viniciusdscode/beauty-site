using BeautySite.BLL;
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

namespace BeautySite.ZDesktop
{
    public partial class FrmRelatorioUsuario : Form
    {
        public FrmRelatorioUsuario()
        {
            InitializeComponent();
        }

        public void PopularGV1()
        {
            UsuarioBLL objBLL = new UsuarioBLL();
            gv1.DataSource = objBLL.ListarUsuario();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            gv1.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            PopularGV1();
            gv1.ReadOnly = true;
            gv1.Visible = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
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
    }

}
