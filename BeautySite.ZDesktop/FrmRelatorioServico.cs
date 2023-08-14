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
using BeautySite.ZDesktop.Utilitarios;
using BeautySite.DTO;

namespace BeautySite.ZDesktop
{
    public partial class FrmRelatorioServico : Form
    {
        public FrmRelatorioServico()
        {
            InitializeComponent();
            Inativo();
        }

        ServicoBLL objBLL = new ServicoBLL();
        ServicoDTO objDTO = new ServicoDTO();

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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (ValidatePage())
            {
                string objSearchDsk = txtPesquisa.Text;

                gv1.DataSource = objBLL.FiltrarServicoBLL(objSearchDsk);
                if (string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    MessageBox.Show("Digite Um serviço existente!!");
                    txtPesquisa.Focus();
                }
                else if (gv1.DataSource != null)
                {
                    CarregaImg();
                    txtPesquisa.Focus();
                }
                else
                {
                    MessageBox.Show("Digite Um serviço existente!!");
                }
            }


        }

        public bool ValidatePage()
        {
            bool validator;

            if (string.IsNullOrEmpty(txtPesquisa.Text))
            {
                txtPesquisa.BackColor = Color.Red;
                MessageBox.Show("Digite uma busca !!", "ATENÇÃO");
                txtPesquisa.BackColor = DefaultBackColor;
                validator = false;
            }
            else
            {

                validator = true;
            }
            return validator;


        }

        public void Inativo()
        {
            gv1.Visible = false;
            button1.Enabled = false;
            label3.Visible = false;
            txtPesquisa.Visible = false;
            btnPesquisar.Visible = false;
        }

        public void Ativo()
        {
            button1.Enabled = true;
            gv1.Visible = true;
            label3.Visible = true;
            txtPesquisa.Visible = true;
            btnPesquisar.Visible = true;
        }


    }
}
