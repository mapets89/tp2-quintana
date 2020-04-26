using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace BusinessLayers
{
    public class MarcaNegocio
    {
        AccesoDB conexionDB = new AccesoDB();
        public List<Marca> ListarMarca()
        {

            List<Marca> listadoMarca = new List<Marca>();
            try
            {
                conexionDB.setearQuery("SELECT Id, Descripcion FROM Marcas");
                conexionDB.ejecutarLector();
                while (conexionDB.lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = conexionDB.lector.GetInt32(0);
                    aux.Descripcion = conexionDB.lector.GetString(1);


                    listadoMarca.Add(aux);
                }

                return listadoMarca;
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
        public void AgregarMarca(string Descripcion)
        {
            try
            {
                conexionDB.setearQuery("INSERT INTO MARCAS (Descripcion) VALUES (@Descripcion)");
                conexionDB.agregarParametro("@Descripcion", Descripcion);
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
