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
    public partial class frmAgregar : Form
    {
        MarcaNegocio marca = new MarcaNegocio();
        CategoriaNegocio categoria = new CategoriaNegocio();
        private Articulo nuevoArticulo = null;
        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.nuevoArticulo = articulo;
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {

            try{
                ToolTip message = new ToolTip();
                message.SetToolTip(addMarca, "Haz click aqui para agregar una Marca Nueva");
                cboMarca.DataSource = marca.ListarMarca();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoria.ListarCategoria();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                if (nuevoArticulo != null){
                    txtBoxNombre.Text = nuevoArticulo.Nombre;
                    txtBoxCodigo.Text = nuevoArticulo.Codigo;
                    txtBoxDescripcion.Text = nuevoArticulo.Descripcion;
                    txtBoxImagen.Text = nuevoArticulo.ImagenUrl;
                    txtBoxPrecio.Text = Convert.ToString(nuevoArticulo.Precio);
                    lblTitulo.Text = "Modificar Articulo";
                    cboMarca.SelectedValue = nuevoArticulo.IdMarca.Id;
                    cboCategoria.SelectedValue = nuevoArticulo.IdCategoria.Id;
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if(nuevoArticulo == null)
                {
                    nuevoArticulo = new Articulo();
                }
                nuevoArticulo.Codigo = txtBoxCodigo.Text.Trim();
                nuevoArticulo.Descripcion = txtBoxDescripcion.Text.Trim();
                nuevoArticulo.IdMarca = (Marca)cboMarca.SelectedItem;
                nuevoArticulo.IdCategoria = (Categoria)cboCategoria.SelectedItem;
                nuevoArticulo.Precio = Convert.ToDecimal(txtBoxPrecio.Text.Trim());
                nuevoArticulo.Nombre = txtBoxNombre.Text.Trim();
                nuevoArticulo.ImagenUrl = txtBoxImagen.Text.Trim();
                if (nuevoArticulo.Codigo == "")
                {
                    throw new System.ArgumentException("No puede dejar el campo CODIGO vacio");
                }
                else if (nuevoArticulo.Nombre == "")
                {
                    throw new System.ArgumentException("No puede dejar el campo NOMBRE vacio");
                }
                else 
                { 
                    if (nuevoArticulo.Id == 0)
                    {
                        negocio.Agregar(nuevoArticulo);
                        MessageBox.Show("Articulo " + nuevoArticulo.Nombre + " se agrego correctamente");
                    }
                    else
                    {
                        negocio.Modificar(nuevoArticulo);
                        MessageBox.Show("Articulo " + nuevoArticulo.Nombre + " se modifico correctamente");
                    }
                }
                
                Dispose();
            }   
            catch (Exception ex)
            {
               if(ex.TargetSite.Name == "StringToNumber")
                {
                    MessageBox.Show("El valor de Precio deber ser numerico");
                }
            }
        }

        private void addMarca_Click(object sender, EventArgs e)
        {
            AddMarCat form = new AddMarCat();
            form.ShowDialog();
            cboMarca.DataSource = marca.ListarMarca();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";
        }

        private void frmAgregar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Dispose();
            }
        }
    }
}
