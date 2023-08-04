using BeautySite.ZDesktop.Direcao;
using BeautySite.ZDesktop.Usuario;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            periodoDia();
        }

        public void periodoDia()
        {
            int hora = DateTime.Now.Hour;

            if (hora < 12)
            {
                label1.Text = $"Bom Dia {Session.nomeUsuario}, Bem vindo à BeautySite!!";
            }
            else if (hora < 18)
            {
                label1.Text = $"Boa Tarde {Session.nomeUsuario}, Bem vindo à BeautySite!!";
            }
            else if (hora < 00)
            {
                label1.Text = $"Boa Noite {Session.nomeUsuario}, Bem vindo à BeautySite!!";
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmDirecaoCadastro obj = new FrmDirecaoCadastro();
            obj.ShowDialog();
            

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Session.nomeUsuario} sua sessão será encerrada", "Atenção", MessageBoxButtons.OK);
            Application.Exit(); 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmDirecaoEdit obj = new FrmDirecaoEdit();
            obj.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FrmDirecaoExcluir obj = new FrmDirecaoExcluir();
            obj.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmDirecaoRelatorio obj = new FrmDirecaoRelatorio();
            obj.ShowDialog();
        }

        
    }
}
