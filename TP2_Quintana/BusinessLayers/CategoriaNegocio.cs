using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace BusinessLayers
{
    public class CategoriaNegocio
    {
        AccesoDB conexionDB = new AccesoDB();
        public List<Categoria> ListarCategoria()
        {

            List<Categoria> listadoCategoria = new List<Categoria>();
            try
            {
                conexionDB.setearQuery("select Id, Descripcion from CATEGORIAS");
                conexionDB.ejecutarLector();
                while (conexionDB.lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = conexionDB.lector.GetInt32(0);
                    aux.Descripcion = conexionDB.lector.GetString(1);


                    listadoCategoria.Add(aux);
                }

                return listadoCategoria;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
