using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using BusinessLayers;

namespace ProjectViewers
{
    public partial class AddMarCat : Form
    {
        MarcaNegocio marca = new MarcaNegocio();
        public AddMarCat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult resultMB = MessageBox.Show("¿Está seguro que desea agregar la marca a la Base de Datos ?", "Confirmación",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultMB == DialogResult.Yes)
            {
                marca.AgregarMarca(addTextBox.Text);
                Dispose();
            }

        }
        private void AddMarCat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Dispose();
            }
        }
        
    }
}
