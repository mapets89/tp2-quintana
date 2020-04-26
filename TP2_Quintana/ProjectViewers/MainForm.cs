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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                ListaForm listar = new ListaForm();
                listar.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregar alta = new frmAgregar();
                alta.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarForm Modificar = new EliminarForm("Modificar");
                Modificar.ShowDialog();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarForm eliminar = new EliminarForm("Eliminar");
                eliminar.ShowDialog();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
