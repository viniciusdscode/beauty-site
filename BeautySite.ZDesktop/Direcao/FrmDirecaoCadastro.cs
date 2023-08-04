using BeautySite.ZDesktop.Servicos;
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

namespace BeautySite.ZDesktop.Direcao
{
    public partial class FrmDirecaoCadastro : Form
    {
        public FrmDirecaoCadastro()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Close();
            FrmCadastrarServico obj = new FrmCadastrarServico();
            obj.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Close();
            FrmCadastrarUsuario obj = new FrmCadastrarUsuario();
            obj.ShowDialog();
        }
    }
}
