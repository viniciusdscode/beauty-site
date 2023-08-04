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
    public partial class FrmCadastrarServico : Form
    {
        public FrmCadastrarServico()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            pc1.Image = null;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ServicoDTO objCad = new ServicoDTO();

            objCad.NomeServico = txtServico.Text;
            objCad.DescricaoServico = txtDescServico.Text;

            string nomeImg = txtServico.Text + ".jpg";
            string pasta = @"C:\Users\vinicius.ssantos79\source\repos\BeautySite\BeautySite.ZDesktop\ImgSave\";
            string caminhoImg = Path.Combine(pasta, nomeImg);
            objCad.UrlImgServico = caminhoImg;

            Image a = pc1.Image;
            a.Save(caminhoImg);

            ServicoBLL objCadastra = new ServicoBLL();
            objCadastra.CadastrarServicoBLL(objCad);
            MessageBox.Show($"Serviço {txtServico.Text} Cadastrado com sucesso !!!");
            Limpar.ClearControl(this);
            pc1.Image = null;
            txtServico.Focus();
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

    }
}
