using BeautySite.BLL;
using BeautySite.DTO;
using BeautySite.ZDesktop.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySite.ZDesktop.Servicos
{
    public partial class FrmExcluirServico : Form
    {
        ServicoDTO objModeloServico = new ServicoDTO();

        

        public FrmExcluirServico()
        {
            InitializeComponent();
        }

        private void FrmExcluirServico_Load(object sender, EventArgs e)
        {
            cpInativo();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string objSearchDsk = txtSearch.Text;

            ServicoBLL objBLL = new ServicoBLL();

            objModeloServico = objBLL.SearchServicoDesk(objSearchDsk);
            if (string.IsNullOrEmpty(objSearchDsk))
            {
                txtServico.Text = string.Empty;
                txtServico.BackColor = Color.Red;
                MessageBox.Show($"Digite uma pesquisa valida !!", "Atenção", MessageBoxButtons.OK);
                txtServico.BackColor = DefaultBackColor;
                txtServico.Focus();
                return;

            }
            else if (objSearchDsk != null)
            {
                txtId.Text = objModeloServico.IdServico.ToString();
                txtServico.Text = objModeloServico.NomeServico.ToString();
                txtDescServico.Text = objModeloServico.DescricaoServico.ToString();
                pc1.ImageLocation = objModeloServico.UrlImgServico;

            }
            cpAtivo();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            pc1.Image = null;
            cpInativo();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ServicoBLL objBLL = new ServicoBLL();

            objModeloServico.IdServico = int.Parse(txtId.Text);
            objBLL.DeleteServico(objModeloServico.IdServico);
            MessageBox.Show($"Serviço {txtSearch.Text} excluido com sucesso !!");
            Limpar.ClearControl(this);
            pc1.Image = null;
            txtSearch.Focus();
            cpInativo();
        }
        public void cpAtivo()
        {
            txtServico.Enabled = true;
            txtDescServico.Enabled = true;
            btnImg.Enabled = true;
        }

        public void cpInativo()
        {
            txtId.Enabled = false;
            txtServico.Enabled = false;
            txtDescServico.Enabled = false;
            btnImg.Enabled = false;
        }

    }
}
