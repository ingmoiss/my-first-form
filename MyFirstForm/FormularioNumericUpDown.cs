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
    public partial class FormularioNumericUpDown : Form
    {
        public FormularioNumericUpDown()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            decimal valor = txtValor.Value;

            lbMostrar.Text = "El valor es: " + valor;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbMostrar.Text = "";
            txtValor.Value = 0;
        }
    }
}
