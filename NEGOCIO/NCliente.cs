using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class NCliente
    {
        public List<Cliente> listarClientes() {
        AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SqlCommand.CommandType = System.Data.CommandType.Text;
                datos.SqlCommand.CommandText = "SELECT ";
                List<Cliente> listaArticulos = new List<Cliente>();
                Cliente aux; 

                datos.SqlConnection.Open();
                datos.SqlDataReader = datos.SqlCommand.ExecuteReader();

                while (datos.SqlDataReader.Read())
                {
                    /*
                    EDITAR 
                    
                    aux = new Cliente();
                    aux.id= (int) datos.SqlDataReader["Id"];
                    aux.Codigo = (string) datos.SqlDataReader["Codigo"];
                    aux.Nombre = (string) datos.SqlDataReader["Nombre"].ToString();
                    aux.Descripcion = datos.SqlDataReader["Descripcion"].ToString();
                    aux.Imagen = datos.SqlDataReader["Imagen"].ToString();

                    aux.Precio = float.Parse(datos.SqlDataReader["Precio"].ToString());

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string) datos.SqlDataReader["Marca"].ToString();
    
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string) datos.SqlDataReader["Categoria"].ToString();
                    */
                    listaArticulos.Add(aux);
                }

                return listaArticulos;
            }
            catch (Exception ex)
            {
                throw ex;
            } }

        public Cliente buscarCliente(int dni)
        {
            Cliente datosCliente=new Cliente();
            //Busco el cliente, en caso de encontrarlo, debo devolver el cliente
            //ESTO LO VOY A USAR CUANDO EL CLIENTE QUIERA REALIZAR EL CANJE DEL VOUCHER
            //EN CASO DE NO EXISTIR DEVUELVE UN REGISTRO NULL
            return datosCliente;
        }
        public void altaCliente(Cliente cliente)
        {
            AccesoDatos bDatos = new AccesoDatos();
            try
            {
                string query = "INSERT INTO ARTICULOS VALUES()";

                bDatos.seterQuery(query);
                bDatos.ejecutarAccion();
                bDatos.CerrarConexionDB();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
