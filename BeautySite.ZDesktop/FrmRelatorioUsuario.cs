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
            Inativo();
        }

        UsuarioBLL objBLL = new UsuarioBLL();

        public void PopularGV1()
        {
            UsuarioBLL objBLL = new UsuarioBLL();
            gv1.DataSource = objBLL.ListarUsuario();

            gv1.Columns["UrlImg"].Visible = false;
            gv1.Columns["TipoUsuario_IdTipoUsuario"].HeaderText = "Descrição";


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Inativo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            PopularGV1();
            PopularCBO();
            gv1.ReadOnly = true;
            Ativo();
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

        public void Inativo()
        {
            gv1.Visible = false;
            button1.Enabled = false;
            cbo1.Visible = false;
            btnFiltrar.Visible = false;
            label3.Visible = false;

        }

        public void Ativo()
        {
            button1.Enabled = true;
            gv1.Visible = true;
            cbo1.Visible = true;
            btnFiltrar.Visible = true;
            label3.Visible = true;
        }

        public void PopularCBO()
        {
            cbo1.DataSource = objBLL.CarregaDDList();
            cbo1.ValueMember = "IdTipoUsuario";
            cbo1.DisplayMember = "DescricaoTipoUsuario";
            cbo1.Refresh();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string objFiltro = cbo1.Text.ToString();

            gv1.DataSource = objBLL.FiltarUsuarioBLL(objFiltro);
            

            
        }

    }

}
