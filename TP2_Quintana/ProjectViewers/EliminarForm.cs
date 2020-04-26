using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayers;
using ClassLibrary;

namespace ProjectViewers
{
    public partial class EliminarForm : Form
    {
        CategoriaNegocio categoria = new CategoriaNegocio();
        String procedencia;
        public EliminarForm()
        {
            InitializeComponent();
        }

        public EliminarForm(String procedencia)
        {
            this.procedencia = procedencia;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            RefreshDatos(dgvEliminar);
        }

        public void EliminarForm_Load(object sender, EventArgs e)
        {
            try
            {
                if(procedencia == "Modificar")
                {
                    modificarButton.Visible = true;
                    btnEliminar.Visible = false;
                    tituloFormEliminar.Text = "Modificar Articulo";

                }
                ArticuloNegocio negocio = new ArticuloNegocio();
                dgvEliminar.DataSource = negocio.ListarArticulos();
                dgvEliminar.Columns[0].Visible = false;
                dgvEliminar.Columns[4].Visible = false;
                dgvEliminar.Columns[3].Visible = false;
                dgvEliminar.Columns[6].Visible = false;
                dgvEliminar.Columns[7].Visible = false;
                dgvEliminar.Columns[8].Visible = false;
                dgvEliminar.Columns[2].HeaderText = "Nombre de Articulo";
                dgvEliminar.Columns[4].HeaderText = "Marca de Articulo";
                dgvEliminar.Columns[5].HeaderText = "Categoria de Articulo";
                dgvEliminar.Columns[1].HeaderText = "Codigo de Articulo";
                categoriaBox.DataSource = categoria.ListarCategoria();
                categoriaBox.ValueMember = "Id";
                categoriaBox.DisplayMember = "Descripcion";
                categoriaBox.SelectedIndex = -1;
                categoriaBox.Text = "Categoria";
                categoriaBox.ForeColor = Color.DarkGray;
                dgvEliminar.Refresh();
                dgvEliminar.RefreshEdit();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void RefreshDatos(DataGridView dgvUniversal)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                dgvUniversal.DataSource = negocio.ListarArticulos();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultMB = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ?","Confirmación",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultMB == DialogResult.Yes)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo eliminar;
                eliminar = (Articulo)dgvEliminar.CurrentRow.DataBoundItem;
                eliminar.Alta = 0;
                negocio.Baja(eliminar);
                RefreshDatos(dgvEliminar);
            }

        }

        private void dgvEliminar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Articulo articulo;
                articulo = (Articulo)dgvEliminar.CurrentRow.DataBoundItem;
                try
                {
                    eliminarPicture.Load(articulo.ImagenUrl);
                }
                catch (Exception)
                {

                    eliminarPicture.Load("https://i.pinimg.com/originals/cb/15/f6/cb15f6417493b802312984f9e591181c.jpg");
                }
                tituloEliminar.Text = articulo.Nombre;
                precioEliminar.Text = "$ " + articulo.Precio;
                precioEliminar.Visible = true;
                tituloEliminar.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void searchBoxCod_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> lista = new ArticuloNegocio().ListarArticulos();
            try
            {
                if (searchBoxCod.Text == "" || searchBoxCod.Text == "Codigo Articulo")
                {
                    RefreshDatos(dgvEliminar);
                }
                else
                {
                    var listaFiltrada = lista.FindAll(k => k.Codigo.ToLower().Contains(searchBoxCod.Text.ToLower()));
                    dgvEliminar.DataSource = listaFiltrada;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void searchBoxCod_Leave(object sender, EventArgs e)
        {
            if(searchBoxCod.Text == ""){
                searchBoxCod.Text = "Codigo Articulo";
                searchBoxCod.ForeColor = Color.DarkGray;
            }
        }

        private void searchBoxCod_Enter(object sender, EventArgs e)
        {
            if(searchBoxCod.Text == "Codigo Articulo")
            {
                searchBoxCod.Text = "";
                searchBoxCod.ForeColor = Color.Black;
            }
        }

        private void searchBoxName_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> lista = new ArticuloNegocio().ListarArticulos();
            try
            {
                if (searchBoxName.Text == "" || searchBoxName.Text == "Nombre Articulo")
                {
                    RefreshDatos(dgvEliminar);
                }
                else
                {
                    var listaFiltrada = lista.FindAll(k => k.Nombre.ToLower().Contains(searchBoxName.Text.ToLower()));
                    dgvEliminar.DataSource = listaFiltrada;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void searchBoxName_Enter(object sender, EventArgs e)
        {
            if (searchBoxName.Text == "Nombre Articulo")
            {
                searchBoxName.Text = "";
                searchBoxName.ForeColor = Color.Black;
            }

        }

        private void searchBoxName_Leave(object sender, EventArgs e)
        {
            if(searchBoxName.Text == ""){
                searchBoxName.Text = "Nombre Articulo";
                searchBoxName.ForeColor = Color.DarkGray;
            }
        }

        private void searchBoxMarca_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> lista = new ArticuloNegocio().ListarArticulos();
            try
            {
                if (searchBoxMarca.Text == "" || searchBoxMarca.Text == "Marca Articulo")
                {
                    RefreshDatos(dgvEliminar);
                }
                else
                {
                    var listaFiltrada = lista.FindAll(k => k.IdMarca.Descripcion.ToLower().Contains(searchBoxMarca.Text.ToLower()));
                    dgvEliminar.DataSource = listaFiltrada;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void searchBoxMarca_Enter(object sender, EventArgs e)
        {
            if (searchBoxMarca.Text == "Marca Articulo")
            {
                searchBoxMarca.Text = "";
                searchBoxMarca.ForeColor = Color.Black;
            }
        }

        private void searchBoxMarca_Leave(object sender, EventArgs e)
        {
            if (searchBoxMarca.Text == "")
            {
                searchBoxMarca.Text = "Marca Articulo";
                searchBoxMarca.ForeColor = Color.DarkGray;
            }
        }
        private void categoriaBox_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> lista = new ArticuloNegocio().ListarArticulos();
            try
            {
                if (categoriaBox.Text == "" || categoriaBox.Text == "Categoria")
                {
                    RefreshDatos(dgvEliminar);
                }
                else
                {
                    var listaFiltrada = lista.FindAll(k => k.IdCategoria.Descripcion.ToLower().Contains(categoriaBox.Text.ToLower()));
                    dgvEliminar.DataSource = listaFiltrada;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void categoriaBox_Enter(object sender, EventArgs e)
        {
            if (categoriaBox.Text == "Categoria")
            {
                categoriaBox.Text = "";
                categoriaBox.ForeColor = Color.Black;
            }
        }

        private void categoriaBox_Leave(object sender, EventArgs e)
        {
            if (categoriaBox.Text == "")
            {
                categoriaBox.Text = "Categoria";
                categoriaBox.ForeColor = Color.DarkGray;
            }
        }

        private void categoriaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void minBox_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> lista = new ArticuloNegocio().ListarArticulos();
            try
            {
                if (minBox.Text == "" || minBox.Text == "Precio Min")
                {
                    RefreshDatos(dgvEliminar);
                }
                else
                {
                    var listaFiltrada = lista.FindAll(k => k.Precio >= Convert.ToDecimal(minBox.Text));
                    dgvEliminar.DataSource = listaFiltrada;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void minBox_Enter(object sender, EventArgs e)
        {
            if (minBox.Text == "Precio Min")
            {
                minBox.Text = "";
                minBox.ForeColor = Color.Black;
            }
        }

        private void minBox_Leave(object sender, EventArgs e)
        {
            if (minBox.Text == "")
            {
                minBox.Text = "Precio Min";
                minBox.ForeColor = Color.DarkGray;
            }
        }
        private void maxBox_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> lista = new ArticuloNegocio().ListarArticulos();
            try
            {
                if (maxBox.Text == "" || maxBox.Text == "Precio Max")
                {
                    RefreshDatos(dgvEliminar);
                }
                else
                {
                    var listaFiltrada = lista.FindAll(k => k.Precio <= Convert.ToDecimal(maxBox.Text));
                    dgvEliminar.DataSource = listaFiltrada;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void maxBox_Enter(object sender, EventArgs e)
        {
            if (maxBox.Text == "Precio Max")
            {
                maxBox.Text = "";
                maxBox.ForeColor = Color.Black;
            }
        }

        private void maxBox_Leave(object sender, EventArgs e)
        {
            if (maxBox.Text == "")
            {
                maxBox.Text = "Precio Max";
                maxBox.ForeColor = Color.DarkGray;
            }
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            Articulo modificar;
            modificar = (Articulo)dgvEliminar.CurrentRow.DataBoundItem;
            frmAgregar frmAgregar = new frmAgregar(modificar);
            frmAgregar.Text = "Modificar";
            frmAgregar.ShowDialog();
            RefreshDatos(dgvEliminar);
            
        }

        private void EliminarForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Dispose();
            }
        }
    }
}
