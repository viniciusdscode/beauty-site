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
    public partial class FrmDirecaoEdit : Form
    {
        public FrmDirecaoEdit()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            Close();
            FrmEditarServico obj = new FrmEditarServico();
            obj.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Close();
            FrmEditarUsuario obj = new FrmEditarUsuario();
            obj.ShowDialog();
        }
    }
}
