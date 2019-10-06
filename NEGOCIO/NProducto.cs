using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class NProducto
    {
        public List<Producto> listarProductos() {AccesoDatos datos = new AccesoDatos();
            try
            {
                String query = "SELECT Id,Titulo,Descripcion, URLImagen FROM Productos";
                datos.seterQuery(query);
                List<Producto> listarProductos = new List<Producto>();
                Producto aux;
                datos.ejecutarLector();

                while (datos.SqlDataReader.Read())
                {
                    aux = new Producto();
                   // aux.id =(int) datos.SqlDataReader["Id"];
                    aux.titulo = (String)datos.SqlDataReader["Titulo"].ToString();
                    aux.descripcion = (String)datos.SqlDataReader["Descripcion"].ToString();
                    aux.urlImagen = (String)datos.SqlDataReader["URLImagen"].ToString();

                    listarProductos.Add(aux);
                }
                datos.CerrarConexionDB();
                return listarProductos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
       
            
        }

        public Producto elegirProducto(int id)
        {
            //Producto producto = new Producto();
            Producto aux;
            Producto elegido= new Producto();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                String query = "SELECT Id,Titulo,Descripcion, URLImagen FROM Productos";
                datos.seterQuery(query);
                datos.ejecutarLector();

                while (datos.SqlDataReader.Read())
                {
                    aux = new Producto();
                    aux.id = (int)datos.SqlDataReader["Id"];
                    if(aux.id==id)
                    {
                        aux.titulo = (String)datos.SqlDataReader["Titulo"].ToString();
                        aux.descripcion = (String)datos.SqlDataReader["Descripcion"].ToString();
                        aux.urlImagen = (String)datos.SqlDataReader["URLImagen"].ToString();
                        elegido = aux;
                        datos.CerrarConexionDB();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return elegido;
        }
    }
}
