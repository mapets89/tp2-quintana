using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;


namespace BusinessLayers
{
    public class ArticuloNegocio
    {
        AccesoDB conexionDB = new AccesoDB();

        public void Agregar(Articulo articuloNuevo)
        {
            try
            {
                conexionDB.setearQuery("INSERT INTO ARTICULOS (Nombre, Codigo, Descripcion, IdCategoria, IdMarca, ImagenUrl," +
                    " Precio) VALUES (@Nombre,@Codigo,@Descripcion,@IdCategoria,@IdMarca,@ImagenUrl,@Precio)");
                conexionDB.agregarParametro("@Nombre", articuloNuevo.Nombre);
                conexionDB.agregarParametro("@Codigo", articuloNuevo.Codigo);
                conexionDB.agregarParametro("@Descripcion", articuloNuevo.Descripcion);
                conexionDB.agregarParametro("@IdCategoria", articuloNuevo.IdCategoria.Id.ToString());
                conexionDB.agregarParametro("@IdMarca", articuloNuevo.IdMarca.Id.ToString());
                conexionDB.agregarParametro("@ImagenUrl", articuloNuevo.ImagenUrl);
                conexionDB.agregarParametro("@Precio", articuloNuevo.Precio);
                conexionDB.ejecutarLector();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexionDB.cerrarConexion();
            }
        }

        public List<Articulo> ListarArticulos()
        {
            List<Articulo> listadoArticulo = new List<Articulo>();
            Articulo articuloAux;
            try
            {
                conexionDB.setearQuery("SELECT a.id, a.codigo, a.Nombre, a.Descripcion, a.ALTA, a.ImagenUrl, a.Precio, " +
                    "m.Descripcion as DescMarca, m.Id as IdMarca, C.Descripcion as DescCat, C.Id as IdCat FROM Articulos " +
                    "as A INNER JOIN MARCAS as M on m.Id = a.IdMarca INNER JOIN Categorias as C on C.Id = a.IdCategoria");
                conexionDB.ejecutarLector();
                while (conexionDB.lector.Read())
                {
                    articuloAux = new Articulo();
                    articuloAux.Id = conexionDB.lector.GetInt32(0);
                    articuloAux.Codigo = conexionDB.lector.GetString(1);
                    articuloAux.Nombre = conexionDB.lector.GetString(2);
                    articuloAux.Descripcion = conexionDB.lector.GetString(3);
                    articuloAux.Alta = conexionDB.lector.GetInt32(4);
                    articuloAux.ImagenUrl = conexionDB.lector.GetString(5);
                    articuloAux.Precio = Decimal.Round((decimal)conexionDB.lector["Precio"], 2);
                    articuloAux.IdMarca = new Marca();
                    articuloAux.IdMarca.Descripcion = (string)conexionDB.lector["DescMarca"];
                    articuloAux.IdMarca.Id = conexionDB.lector.GetInt32(8);
                    articuloAux.IdCategoria = new Categoria();
                    articuloAux.IdCategoria.Descripcion = (string)conexionDB.lector["DescCat"];
                    articuloAux.IdCategoria.Id = conexionDB.lector.GetInt32(10);

                    if (articuloAux.Alta != 0)
                    {
                        listadoArticulo.Add(articuloAux);
                    }

                }
                return listadoArticulo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexionDB.cerrarConexion();
            }
        }

        public void Modificar(Articulo articulo)
        {
            AccesoDB datos = new AccesoDB();
            try
            {
                conexionDB.setearQuery("UPDATE ARTICULOS SET Codigo=@Codigo,Nombre=@Nombre, Descripcion=@Descripcion," +
                    " IdCategoria=@IdCategoria,IdMarca=@IdMarca,ImagenURL=@ImagenURL, Precio=@Precio where Id=@Id");
                conexionDB.agregarParametro("@Codigo", articulo.Codigo);
                conexionDB.agregarParametro("@Nombre", articulo.Nombre);
                conexionDB.agregarParametro("@Descripcion", articulo.Descripcion);
                conexionDB.agregarParametro("@Precio", articulo.Precio);
                conexionDB.agregarParametro("@IdCategoria", articulo.IdCategoria.Id);
                conexionDB.agregarParametro("@IdMarca", articulo.IdMarca.Id);
                conexionDB.agregarParametro("@Id", articulo.Id);
                conexionDB.agregarParametro("@ImagenURL", articulo.ImagenUrl);
                conexionDB.ejecutarLector();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexionDB.cerrarConexion();
            }
        }

        public void Baja(Articulo articulo)
        {
            try
            {
                articulo.Alta = 0;
                conexionDB.setearQuery("UPDATE ARTICULOS SET ALTA=@ALTA where Id=@Id");
                conexionDB.agregarParametro("@Id", articulo.Id);
                conexionDB.agregarParametro("@ALTA", articulo.Alta);
                conexionDB.ejecutarLector();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexionDB.cerrarConexion();
            }
        }
    }
}
