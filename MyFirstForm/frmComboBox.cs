using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstForm
{
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            string valor = comboDias.Text;
            lbResultado.Text = "El dia es" + valor;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbResultado.Text = "";
            comboDias.Text = "Selecione";
        }
    }
}
