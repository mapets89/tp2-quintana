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
    public partial class ListaForm : Form
    {
        EliminarForm form = new EliminarForm();
        CategoriaNegocio categoria = new CategoriaNegocio();
        List<Articulo> lista = new ArticuloNegocio().ListarArticulos();
        public ListaForm()
        {
            InitializeComponent();
        }

        private void ListaForm_Load(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                dgvArticulo.DataSource = negocio.ListarArticulos();
                dgvArticulo.Columns[0].Visible = false;
                dgvArticulo.Columns[1].Visible = false;
                dgvArticulo.Columns[3].Visible = false;
                dgvArticulo.Columns[6].Visible = false;
                dgvArticulo.Columns[8].Visible = false;
                dgvArticulo.Columns[2].HeaderText = "Nombre de Articulo";
                dgvArticulo.Columns[4].HeaderText = "Marca de Articulo";
                dgvArticulo.Columns[5].HeaderText = "Categoria de Articulo";
                dgvArticulo.Columns[7].HeaderText = "Precio del Articulo";
                categoriaBox.DataSource = categoria.ListarCategoria();
                categoriaBox.ValueMember = "Id";
                categoriaBox.DisplayMember = "Descripcion";
                categoriaBox.SelectedIndex = -1;
                categoriaBox.Text = "Categoria";
                categoriaBox.ForeColor = Color.DarkGray;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
        private void dgvArticulo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Articulo articulo;
                articulo = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                try
                {
                    articuloPicture.Load(articulo.ImagenUrl);
                }
                catch (Exception)
                {

                    articuloPicture.Load("https://i.pinimg.com/originals/cb/15/f6/cb15f6417493b802312984f9e591181c.jpg");
                }
                
                tituloArticulo.Text = articulo.Nombre;
                descripcionText.Text = articulo.Descripcion;
                precioText.Text = "$ " +  articulo.Precio;
                tituloArticulo.Visible = true;
                descripcionText.Visible = true;
                precioText.Visible = true;
                descripcionLabel.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void searchBoxCod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (searchBoxCod.Text == "" || searchBoxCod.Text == "Codigo Articulo")
                {
                    form.RefreshDatos(dgvArticulo);
                }
                else
                {
                    var listaFiltrada = lista.FindAll(k => k.Codigo.ToLower().Contains(searchBoxCod.Text.ToLower()));
                    dgvArticulo.DataSource = listaFiltrada;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void searchBoxCod_Leave(object sender, EventArgs e)
        {
            if (searchBoxCod.Text == "")
            {
                searchBoxCod.Text = "Codigo Articulo";
                searchBoxCod.ForeColor = Color.DarkGray;
            }
        }

        private void searchBoxCod_Enter(object sender, EventArgs e)
        {
            if (searchBoxCod.Text == "Codigo Articulo")
            {
                searchBoxCod.Text = "";
                searchBoxCod.ForeColor = Color.Black;
            }
        }

        private void searchBoxName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (searchBoxName.Text == "" || searchBoxName.Text == "Nombre Articulo")
                {
                    form.RefreshDatos(dgvArticulo);
                }
                else
                {
                    var listaFiltrada = lista.FindAll(k => k.Nombre.ToLower().Contains(searchBoxName.Text.ToLower()));
                    dgvArticulo.DataSource = listaFiltrada;
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
            if (searchBoxName.Text == "")
            {
                searchBoxName.Text = "Nombre Articulo";
                searchBoxName.ForeColor = Color.DarkGray;
            }
        }

        
        private void searchBoxMarca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (searchBoxMarca.Text == "" || searchBoxMarca.Text == "Marca Articulo")
                {
                    form.RefreshDatos(dgvArticulo);
                }
                else
                {
                    var listaFiltrada = lista.FindAll(k => k.IdMarca.Descripcion.ToLower().Contains(searchBoxMarca.Text.ToLower()));
                    dgvArticulo.DataSource = listaFiltrada;
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
            try
            {
                if (categoriaBox.Text == "" || categoriaBox.Text == "Categoria")
                {
                    form.RefreshDatos(dgvArticulo);
                }
                else
                {
                    var listaFiltrada = lista.FindAll(k => k.IdCategoria.Descripcion.ToLower().Contains(categoriaBox.Text.ToLower()));
                    dgvArticulo.DataSource = listaFiltrada;
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
            if(e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
           
        }
        private void minBox_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (minBox.Text == "" || minBox.Text == "Precio Min")
                {
                    form.RefreshDatos(dgvArticulo);
                }
                else
                {
                    var listaFiltrada = lista.FindAll(k => k.Precio >= Convert.ToDecimal(minBox.Text));
                    dgvArticulo.DataSource = listaFiltrada;
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
            
            try
            {
                if (maxBox.Text == "" || maxBox.Text == "Precio Max")
                {
                    form.RefreshDatos(dgvArticulo);
                }
                else
                {
                    var listaFiltrada = lista.FindAll(k => k.Precio <= Convert.ToDecimal(maxBox.Text));
                    dgvArticulo.DataSource = listaFiltrada;
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

        private void ListaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Dispose();
            }
        }
    }
}
