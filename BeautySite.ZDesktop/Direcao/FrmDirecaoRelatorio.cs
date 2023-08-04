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
    public partial class FrmDirecaoRelatorio : Form
    {
        public FrmDirecaoRelatorio()
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
            FrmRelatorioServico obj = new FrmRelatorioServico();
            obj.ShowDialog();

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Close();
            FrmRelatorioUsuario obj = new FrmRelatorioUsuario();
            obj.ShowDialog();
        }
    }
}
