using BeautySite.BLL;
using BeautySite.DTO;
using BeautySite.ZDesktop.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySite.ZDesktop.Servicos
{
    public partial class FrmEditarServico : Form
    {
        ServicoDTO objModeloServico = new ServicoDTO();
        ServicoBLL objBLL = new ServicoBLL();

        public FrmEditarServico()
        {
            InitializeComponent();
        }

        private void FrmEditarServico_Load(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = string.Empty;
                txtSearch.BackColor = Color.Red;
                MessageBox.Show($"Digite sua busca !!", "ATENÇÃO", MessageBoxButtons.OK);
                txtSearch.BackColor = DefaultBackColor;
                txtSearch.Focus();
                cpInativo();
                return;

            }
            else if (objModeloServico != null)
            {
                txtId.Text = objModeloServico.IdServico.ToString();
                txtServico.Text = objModeloServico.NomeServico.ToString();
                txtDescServico.Text = objModeloServico.DescricaoServico.ToString();
                pc1.ImageLocation = objModeloServico.UrlImgServico;
                cpAtivo();

            }
            else
            {
                MessageBox.Show("Serviço não cadastrado !!", "ATENÇÃO");
                Limpar.ClearControl(this);
                pc1.Image = null;
                txtSearch.Focus();
                cpInativo();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            pc1.Image = null;
            cpInativo();
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens |*.bmp;*.jpg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string img = dialog.FileName.ToString();
                pc1.ImageLocation = img;

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidatePage())
            {
                objModeloServico.NomeServico = txtServico.Text;
                objModeloServico.DescricaoServico = txtDescServico.Text;

                string nomeImg = txtServico.Text + ".jpg";
                string pasta = @"C:\Users\vinicius.ssantos79\source\repos\BeautySite\BeautySite.ZDesktop\ImgSave\";
                string caminhoImg = Path.Combine(pasta, nomeImg);
                objModeloServico.UrlImgServico = caminhoImg;

                Image a = pc1.Image;
                a.Save(caminhoImg);

                objBLL.UpdateServicoDsk(objModeloServico);
                MessageBox.Show($"Serviço {txtServico.Text} editado com sucesso !!");
                Limpar.ClearControl(this);
                pc1.Image = null;

                cpInativo();
            }


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

        public bool ValidatePage()
        {
            bool validator;

            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.BackColor = Color.Red;
                MessageBox.Show("Digite uma busca !!", "ATENÇÃO");
                txtSearch.BackColor = DefaultBackColor;
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtId.Text))
            {
                txtSearch.BackColor = Color.Red;
                MessageBox.Show("Pesquise o serviço antes de editar !!", "ATENÇÃO");
                txtSearch.BackColor = DefaultBackColor;
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtServico.Text))
            {
                txtServico.BackColor = Color.Red;
                MessageBox.Show("Digite o serviço !!", "ATENÇÃO");
                txtServico.BackColor = DefaultBackColor;
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtDescServico.Text))
            {
                txtDescServico.BackColor = Color.Red;
                MessageBox.Show("Digite a descrição do serviço !!", "ATENÇÃO");
                txtDescServico.BackColor = DefaultBackColor;
                validator = false;
            }
            else
            {
                validator = true;
            }
            return validator;


        }

    }
}
